using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gestão_Usuarios
{
    public class Permissao
    {
        public int IdFuncionalidade { get; set; }
        public string NomeFuncionalidade { get; set; }
        private DatabaseController dbController;

        public Permissao()
        {
            dbController = new DatabaseController();
        }

        public List<Permissao> ListarPermissoes(string idUsuario)
        {
            List<Permissao> permissoes = new List<Permissao>();
            string query = @"
                SELECT p.fk_Funcionalidade_idFuncionalidade, f.nome
                FROM User_Permissao_Tem p
                JOIN Funcionalidade f ON p.fk_Funcionalidade_idFuncionalidade = f.idFuncionalidade
                WHERE p.fk_Usuarios_idUsuario = @idUsuario";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Permissao permissao = new Permissao
                        {
                            IdFuncionalidade = reader.GetInt32(0),
                            NomeFuncionalidade = reader.GetString(1)
                        };
                        permissoes.Add(permissao);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao listar permissões: {ex.Message}");
            }

            return permissoes;
        }

        public bool CadastrarPermissoes(string idUsuario, List<int> permissoesIds)
        {
            foreach (var idFuncionalidade in permissoesIds)
            {
                if (!CadastrarPermissao(idUsuario, idFuncionalidade))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CadastrarPermissao(string idUsuario, int idFuncionalidade)
        {
            string query = "INSERT INTO User_Permissao_Tem (fk_Usuarios_idUsuario, fk_Funcionalidade_idFuncionalidade) VALUES (@idUsuario, @idFuncionalidade)";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@idFuncionalidade", idFuncionalidade);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao cadastrar permissão: {ex.Message}");
                return false;
            }
        }

        public bool EditarPermissoes(string idUsuario, List<int> permissoesIds)
        {
            RemoverPermissoes(idUsuario);
            return CadastrarPermissoes(idUsuario, permissoesIds);
        }

        private bool RemoverPermissoes(string idUsuario)
        {
            string query = "DELETE FROM User_Permissao_Tem WHERE fk_Usuarios_idUsuario = @idUsuario";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao remover permissões: {ex.Message}");
                return false;
            }
        }
    }
}
