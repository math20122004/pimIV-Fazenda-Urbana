using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoProducao
{
    public class Lote
    {
        public int IdLote { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdProducao { get; set; }
        public string Status { get; set; } 
        public DateTime DataValidade { get; set; }
        public string NomeProduto { get; set; } 


        private readonly DatabaseController dbController;

        public Lote()
        {
            dbController = new DatabaseController();
        }

        public bool CadastrarLote(int idProduto, int quantidade, int idProducao, DateTime dataValidade)
        {
            try
            {
                // Query para inserir o lote sem especificar o ID, assumindo que ele é auto-incrementado
                string query = "INSERT INTO Lote (idProduto, quantidade, idProducao, dataValidade, status) VALUES (@idProduto, @quantidade, @idProducao, @dataValidade, 'disponível')";

                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idProduto", idProduto);
                    command.Parameters.AddWithValue("@quantidade", quantidade);
                    command.Parameters.AddWithValue("@idProducao", idProducao);
                    command.Parameters.AddWithValue("@dataValidade", dataValidade);
                    connection.Open();
                    command.ExecuteNonQuery(); // Não precisamos capturar o ID aqui, já que é auto-incrementado
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar lote: {ex.Message}");
                return false;
            }
        }


        public List<Lote> ListarLotesDisponiveis()
        {
            List<Lote> lotes = new List<Lote>();
            string query = "SELECT idLote, idProduto, quantidade, idProducao, status, dataValidade FROM Lote WHERE status = 'disponível'";

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lotes.Add(new Lote
                        {
                            IdLote = reader.GetInt32(0),
                            IdProduto = reader.GetInt32(1),
                            Quantidade = reader.GetInt32(2),
                            IdProducao = reader.GetInt32(3),
                            Status = reader.GetString(4),
                            DataValidade = reader.GetDateTime(5)
                        });
                    }
                }
            }
            return lotes;
        }

        public bool EditarLote(int idLote, int quantidade, string status, DateTime dataValidade)
        {
            try
            {
                string query = "UPDATE Lote SET quantidade = @quantidade, status = @status, dataValidade = @dataValidade WHERE idLote = @idLote";
                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idLote", idLote);
                    command.Parameters.AddWithValue("@quantidade", quantidade);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@dataValidade", dataValidade);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar lote: {ex.Message}");
                return false;
            }
        }

        public Lote VerLote(int idLote)
        {
            Lote lote = null;
            string query = "SELECT L.idLote, L.idProduto, L.quantidade, L.idProducao, L.status, L.dataValidade, P.nomeProduto " +
                           "FROM Lote L INNER JOIN Produto P ON L.idProduto = P.idProduto " +
                           "WHERE L.idLote = @idLote";

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idLote", idLote);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lote = new Lote
                        {
                            IdLote = reader.GetInt32(0),
                            IdProduto = reader.GetInt32(1),
                            Quantidade = reader.GetInt32(2),
                            IdProducao = reader.GetInt32(3),
                            Status = reader.GetString(4),
                            DataValidade = reader.GetDateTime(5),
                            NomeProduto = reader.GetString(6) // Capturando o nome do produto
                        };
                    }
                }
            }
            return lote;
        }

        public List<(int IdProduto, string NomeProduto)> ListarProdutos()
        {
            List<(int IdProduto, string NomeProduto)> produtos = new List<(int IdProduto, string NomeProduto)>();
            string query = "SELECT idProduto, nomeProduto FROM Produto";

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add((reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            return produtos;
        }


    }
}
