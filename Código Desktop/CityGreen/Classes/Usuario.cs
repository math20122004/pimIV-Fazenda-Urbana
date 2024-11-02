using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using CityGreen.Classes;

namespace Gestão_Usuarios
{
    public class Usuario : Permissao
    {
        public string Nome { get; set; }
        public string IdUsuario { get; set; }
        public string StatusUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        private readonly DatabaseController dbController;
        private readonly Permissao permissaoController;

        public Usuario()
        {
            dbController = new DatabaseController();
            permissaoController = new Permissao();
        }

        public bool CadastrarUsuario(string idUsuario, string nome, string email, List<int> permissoesIds)
        {
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand("uspAddUsuario", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@pEmail", email);
                    command.Parameters.AddWithValue("@status", "ativo");

                    SqlParameter outputParam = new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    string responseMessage = outputParam.Value.ToString();
                    bool usuarioCadastrado = responseMessage == "Usuário inserido com sucesso";

                    // Se o usuário foi cadastrado, cadastra as permissões
                    if (usuarioCadastrado)
                    {
                        return permissaoController.CadastrarPermissoes(idUsuario, permissoesIds);
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao cadastrar usuário: {ex.Message}");
                return false;
            }
        }

        public Usuario VerUsuario(string idUsuario)
        {
            string query = "SELECT idUsuario, nome, email, status FROM Usuarios WHERE idUsuario = @idUsuario";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            IdUsuario = reader.GetString(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2),
                            StatusUsuario = reader.GetString(3)
                        };
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao visualizar usuário: {ex.Message}");
                return null;
            }
        }

        public List<Usuario> ListarUsuarios(string termoPesquisa)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT idUsuario, nome, email, status FROM Usuarios";

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                query += " WHERE idUsuario LIKE @termoPesquisa OR nome LIKE @termoPesquisa OR email LIKE @termoPesquisa";
            }

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrWhiteSpace(termoPesquisa))
                    {
                        command.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            IdUsuario = reader.GetString(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2),
                            StatusUsuario = reader.GetString(3)
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao listar usuários: {ex.Message}");
            }

            return usuarios;
        }

        public bool EditarUsuario(string idUsuario, string nome, string email, string status, string novaSenha, List<int> permissoesIds)
        {
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    string query = @"
                        UPDATE Usuarios
                        SET 
                            nome = @nome,
                            email = @pEmail,
                            status = @novoStatus,
                            senhaHash = CASE 
                                WHEN @novaSenha IS NOT NULL AND @novaSenha != '' 
                                THEN HASHBYTES('SHA2_256', @novaSenha) 
                                ELSE senhaHash 
                            END
                        WHERE idUsuario = @idUsuario";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@pEmail", email);
                    command.Parameters.AddWithValue("@novoStatus", status);
                    command.Parameters.AddWithValue("@novaSenha", string.IsNullOrEmpty(novaSenha) ? (object)DBNull.Value : novaSenha);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Atualiza permissões se o usuário foi editado com sucesso
                    if (rowsAffected > 0)
                    {
                        return permissaoController.EditarPermissoes(idUsuario, permissoesIds);
                    }
                    return false; // Retorna false se a edição não alterou nenhum registro
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao editar usuário: {ex.Message}");
                return false;
            }
        }

        private byte[] HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}
