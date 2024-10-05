using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CityGreen.Classes;

namespace Gestão_Usuarios
{
    public class Permissao
    {
        public int IdFuncionalidade { get; set; }
        public string NomeFuncionalidade { get; set; }
        public bool Criar { get; set; }
        public bool Leitura { get; set; }
        public bool Modificacao { get; set; }
        private DatabaseController dbController;

        public Permissao()
        {
            dbController = new DatabaseController();
        }

        public bool EditarPermissao(string idUsuario)
        {
            string query = "UPDATE User_Permissao_Tem SET criar = @criar, leitura = @leitura, modificacao = @modificacao WHERE fk_Usuarios_idUsuario = @idUsuario AND fk_Funcionalidade_idFuncionalidade = @idFuncionalidade";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@idFuncionalidade", IdFuncionalidade);
                    command.Parameters.AddWithValue("@criar", Criar);
                    command.Parameters.AddWithValue("@leitura", Leitura);
                    command.Parameters.AddWithValue("@modificacao", Modificacao);

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

        public bool CadastrarPermissao(string idUsuario)
        {
            string query = "INSERT INTO User_Permissao_Tem (fk_Usuarios_idUsuario, fk_Funcionalidade_idFuncionalidade, criar, leitura, modificacao) VALUES (@idUsuario, @idFuncionalidade, @criar, @leitura, @modificacao)";
            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@idFuncionalidade", IdFuncionalidade);
                    command.Parameters.AddWithValue("@criar", Criar);
                    command.Parameters.AddWithValue("@leitura", Leitura);
                    command.Parameters.AddWithValue("@modificacao", Modificacao);

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

        public List<Permissao> ListarPermissoes(string idUsuario)
        {
            List<Permissao> permissoes = new List<Permissao>();
            string query = @"
                SELECT p.fk_Funcionalidade_idFuncionalidade, f.nome, p.criar, p.leitura, p.modificacao
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
                            NomeFuncionalidade = reader.GetString(1),
                            Criar = reader.GetBoolean(2),
                            Leitura = reader.GetBoolean(3),
                            Modificacao = reader.GetBoolean(4)
                        };
                        permissoes.Add(permissao);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return permissoes;
        }
    }
}
