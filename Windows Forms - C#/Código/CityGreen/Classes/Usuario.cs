using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using CityGreen.Classes;

namespace Gestão_Usuarios
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string IdUsuario { get; set; }
        public string StatusUsuario { get; set; }
        public string Email { get; set; }
        public List<Permissao> Permissoes { get; set; }
        private DatabaseController dbController;

        public Usuario()
        {
            dbController = new DatabaseController();
            Permissoes = new List<Permissao>();
        }

        public bool CadastrarUsuario(string idUsuario, string nome, string email, string senha)
        {
            string query = "INSERT INTO Usuarios (idUsuario, nome, email, senhaHash, status) VALUES (@idUsuario, @nome, @senhaHash, 'ativo')";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@senhaHash", HashPassword(senha));
                    command.Parameters.AddWithValue("@status", "ativo");

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (ex) if necessary
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
                // Log the exception (ex) if necessary
                return null;
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT idUsuario, nome, email, status FROM Usuarios";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
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
                // Log the exception (ex) if necessary
            }
            return usuarios;
        }

        public List<Permissao> ListarPermissoes(string idUsuario)
        {
            Permissao permissao = new Permissao();
            return permissao.ListarPermissoes(idUsuario);
        }

        private byte[] HashPassword(string senha)
        {
            // Implementação do hash da senha
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}
