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

        public bool CadastrarUsuario(string idUsuario, string nome, string email)
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
                    return responseMessage == "Usuário inserido com sucesso";
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

        public bool EditarUsuario(string idUsuario, string nome, string email, string status, string novaSenha)
        {
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand("uspEditarUsuario", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@pEmail", email);
                    command.Parameters.AddWithValue("@novaSenha", string.IsNullOrEmpty(novaSenha) ? (object)DBNull.Value : HashSenha(novaSenha));
                    command.Parameters.AddWithValue("@novoStatus", status);

                    SqlParameter outputParam = new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    string responseMessage = outputParam.Value.ToString();
                    if (!string.IsNullOrEmpty(responseMessage))
                    {
                        Console.WriteLine(responseMessage); // Optionally log the response
                    }
                    return responseMessage == "Usuário atualizado com sucesso";
                }
            }
            catch (SqlException ex) when (ex.Number >= 50001 && ex.Number <= 50004)
            {
                Console.WriteLine($"Erro na stored procedure: {ex.Message}");
                return false;
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

        public bool CadastrarPermissoes(string idUsuario, List<int> permissoesIds)
        {
            return permissaoController.CadastrarPermissoes(idUsuario, permissoesIds);
        }
    }
}
