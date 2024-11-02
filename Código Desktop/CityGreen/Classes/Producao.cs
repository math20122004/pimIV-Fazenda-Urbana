using CityGreen.Classes;
using Gestão_Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoProducao
{
    public class Producao
    {
        public int IdPlantio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; } // DataFim é opcional
        public string Produto { get; set; }
        public string StatusProducao { get; set; } // "Ativa", "Cancelada", "Completa"

        private readonly DatabaseController dbController;

        public Producao()
        {
            dbController = new DatabaseController();
        }

        // Método para cadastrar produção
        public bool CadastrarProducao(DateTime dataInicio, string produto, DateTime? dataFim = null)
        {
            try
            {
                string query = "INSERT INTO Producao (dataInicio, produto, dataFim, statusProducao) OUTPUT INSERTED.idPlantio VALUES (@dataInicio, @produto, @dataFim, 'Ativa')";
                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataInicio", dataInicio);
                    command.Parameters.AddWithValue("@produto", produto);
                    command.Parameters.AddWithValue("@dataFim", (object)dataFim ?? DBNull.Value);

                    connection.Open();
                    this.IdPlantio = (int)command.ExecuteScalar();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar produção: {ex.Message}");
                return false;
            }
        }

        // Método para listar produções com filtro opcional
        public List<Producao> ListarProducoes(string pesquisa = "")
        {
            List<Producao> producoes = new List<Producao>();

            string query = "SELECT idPlantio, dataInicio, dataFim, produto, statusProducao FROM Producao";
            if (!string.IsNullOrEmpty(pesquisa))
            {
                query += " WHERE produto LIKE @pesquisa";
            }

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (!string.IsNullOrEmpty(pesquisa))
                {
                    command.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                }

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        producoes.Add(new Producao
                        {
                            IdPlantio = reader.GetInt32(0),
                            DataInicio = reader.GetDateTime(1),
                            DataFim = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                            Produto = reader.GetString(3),
                            StatusProducao = reader.GetString(4)
                        });
                    }
                }
            }
            return producoes;
        }

        // Método para editar produção
        public bool EditarProducao(int idPlantio, DateTime? dataFim, string statusProducao)
        {
            try
            {
                string query = "UPDATE Producao SET dataFim = @dataFim, statusProducao = @statusProducao WHERE idPlantio = @idPlantio";
                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlantio", idPlantio);
                    command.Parameters.AddWithValue("@dataFim", (object)dataFim ?? DBNull.Value);
                    command.Parameters.AddWithValue("@statusProducao", statusProducao);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar produção: {ex.Message}");
                return false;
            }
        }

        // Método para cadastrar insumos na produção
        public bool CadastrarInsumosProducao(int idPlantio, int idInsumo, int quantidade)
        {
            try
            {
                string query = "INSERT INTO InsumoProducao (idInsumo, idPlantio, quantidade) VALUES (@idInsumo, @idPlantio, @quantidade)";

                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idInsumo", idInsumo);
                    command.Parameters.AddWithValue("@idPlantio", idPlantio);
                    command.Parameters.AddWithValue("@quantidade", quantidade);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Insumo cadastrado com sucesso na produção!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar insumo: {ex.Message}");
                return false;
            }
        }

        public bool RemoverInsumosProducao(int idPlantio, int idInsumo)
        {
            try
            {
                string query = "DELETE FROM InsumoProducao WHERE idPlantio = @idPlantio AND idInsumo = @idInsumo";

                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlantio", idPlantio);
                    command.Parameters.AddWithValue("@idInsumo", idInsumo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Insumo removido com sucesso da produção!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover insumo: {ex.Message}");
                return false;
            }
        }


        // Método para listar insumos cadastrados na produção
        public List<Insumo> ListarInsumosProducao(int idPlantio)
        {
            List<Insumo> insumos = new List<Insumo>();

            string query = "SELECT i.idInsumo, i.nomeInsumo, ip.quantidade FROM InsumoProducao ip JOIN Insumo i ON ip.idInsumo = i.idInsumo WHERE ip.idPlantio = @idPlantio";

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idPlantio", idPlantio);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        insumos.Add(new Insumo
                        {
                            IdInsumo = reader.GetInt32(0),
                            NomeInsumo = reader.GetString(1),
                            QuantidadeInsumo = reader.GetInt32(2)
                        });
                    }
                }
            }

            return insumos;
        }
    }
}
