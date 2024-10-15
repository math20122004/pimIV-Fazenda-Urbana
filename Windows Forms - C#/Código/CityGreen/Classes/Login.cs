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

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand commandLogin = new SqlCommand(queryLogin, connection);
                    commandLogin.Parameters.AddWithValue("@login", login);

                    connection.Open();
                    var resultLogin = commandLogin.ExecuteScalar();

                    if (resultLogin == null)
                    {
                        return "Login inválido";
                    }

                    // A senha é verificada aqui, e se for "Troca123", deve retornar "TrocaSenha".
                    if (senha == "Troca123")
                    {
                        return "TrocaSenha"; // Indica que deve solicitar nova senha
                    }

                    string querySenha = @"
                        SELECT idUsuario
                        FROM Usuarios
                        WHERE (idUsuario = @login OR email = @login)
                        AND senhaHash = HASHBYTES('SHA2_256', @senha)
                        AND status = 'ativo'";

                    SqlCommand commandSenha = new SqlCommand(querySenha, connection);
                    commandSenha.Parameters.AddWithValue("@login", login);
                    commandSenha.Parameters.AddWithValue("@senha", senha);

                    var resultSenha = commandSenha.ExecuteScalar();

                    if (resultSenha == null)
                    {
                        return "SenhaInvalida"; // Para senhas inválidas
                    }

                    return resultLogin.ToString(); // Retorna o id do usuário
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao verificar credenciais: {ex.Message}");
                return "Erro no sistema"; // Mensagem de erro
            }
        }

        public bool EditarSenha(string login, string novaSenha)
        {
            string query = @"
                UPDATE Usuarios
                SET senhaHash = HASHBYTES('SHA2_256', @novaSenha)
                WHERE (idUsuario = @login OR email = @login) AND status = 'ativo'";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@novaSenha", novaSenha);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // Retorna true se a senha foi atualizada
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao editar senha: {ex.Message}");
                return false; // Retorna false em caso de erro
            }
        }
    }
}
