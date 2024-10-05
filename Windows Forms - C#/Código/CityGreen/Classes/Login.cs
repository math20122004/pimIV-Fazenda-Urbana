using System;
using System.Data.SqlClient;
using CityGreen.Classes;

namespace LoginSistema
{
    public class Login
    {
        private DatabaseController dbController;

        public Login()
        {
            dbController = new DatabaseController();
        }

        public string VerificarCredenciais(string login, string senha)
        {
            string queryLogin = @"
                SELECT idUsuario
                FROM Usuarios
                WHERE (idUsuario = @login OR email = @login)
                AND status = 'ativo'";

            string querySenha = @"
                SELECT idUsuario
                FROM Usuarios
                WHERE (idUsuario = @login OR email = @login)
                AND senhaHash = HASHBYTES('SHA2_256', @senha)
                AND status = 'ativo'";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand commandLogin = new SqlCommand(queryLogin, connection);
                    commandLogin.Parameters.AddWithValue("@login", login);

                    connection.Open();
                    var resultLogin = commandLogin.ExecuteScalar();
                    connection.Close();

                    if (resultLogin == null)
                    {
                        return "Login inválido";
                    }

                    SqlCommand commandSenha = new SqlCommand(querySenha, connection);
                    commandSenha.Parameters.AddWithValue("@login", login);
                    commandSenha.Parameters.AddWithValue("@senha", senha);

                    connection.Open();
                    var resultSenha = commandSenha.ExecuteScalar();

                    if (resultSenha == null)
                    {
                        return "SenhaInvalida";
                    }

                    return resultSenha.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Erro no sistema";
            }
        }
    }
}
