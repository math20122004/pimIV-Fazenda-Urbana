using System;
using System.Data.SqlClient;

namespace LoginSistema
{
    public class Login
    {
        private string connectionString = "Server=DESKTOP-C8MJ6C3;Database=CityGreen;Trusted_Connection=True;";

        public bool VerificarCredenciais(string login, string senha)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Usuarios
                WHERE (idUsuario = @login OR email = @login)
                AND senhaHash = HASHBYTES('SHA2_256', @senha)
                AND status = 'ativo'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool LogarSistema(string login, string senha)
        {
            return VerificarCredenciais(login, senha);
        }
    }
}
