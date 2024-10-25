using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoVendas
{
    public class ItensVenda
    {
        public int IdVenda { get; set; }
        public int IdLote { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public string NomeProduto { get; set; } // Nome do produto
        public int IdProduto { get; set; } // ID do produto

        private readonly DatabaseController dbController;

        public ItensVenda()
        {
            dbController = new DatabaseController();
        }

        // Método para obter a lista de itens de uma venda
        public List<ItensVenda> ListarItensVenda(int idVenda)
        {
            List<ItensVenda> itensVendaList = new List<ItensVenda>();

            // Consulta SQL modificada para incluir as junções necessárias
            string query = @"
        SELECT iv.idLote, iv.quantidade, iv.valor_total, p.nomeProduto 
        FROM Itens_Venda iv 
        INNER JOIN Lote l ON iv.idLote = l.idLote 
        INNER JOIN Produto p ON l.idProduto = p.idProduto 
        WHERE iv.idVenda = @idVenda";

            using (SqlConnection connection = dbController.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idVenda", idVenda);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItensVenda item = new ItensVenda
                        {
                            IdVenda = idVenda,
                            IdLote = reader.GetInt32(reader.GetOrdinal("idLote")),
                            Quantidade = reader.GetInt32(reader.GetOrdinal("quantidade")),
                            ValorUnitario = (double)reader.GetDecimal(reader.GetOrdinal("valor_total")), // Você pode manter ou modificar essa linha se precisar
                            NomeProduto = reader.GetString(reader.GetOrdinal("nomeProduto")),
                            // O IdProduto não está sendo retornado pela nova consulta, se necessário, você pode modificar
                        };
                        itensVendaList.Add(item);
                    }
                }
            }

            return itensVendaList;
        }


        // Método para adicionar um item à venda
        public bool CadastrarItemVenda(int idVenda, int idLote, int quantidade, double valorUnitario)
        {
            try
            {
                var query = "INSERT INTO Itens_Venda (idVenda, idLote, quantidade, valor_total) VALUES (@idVenda, @idLote, @quantidade, @valorUnitario)";
                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idVenda", idVenda);
                    command.Parameters.AddWithValue("@idLote", idLote);
                    command.Parameters.AddWithValue("@quantidade", quantidade);
                    command.Parameters.AddWithValue("@valorUnitario", valorUnitario);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar item: {ex.Message}");
                return false;
            }
        }

        // Método para remover um item da venda
        // Método para remover um item da venda
        public bool RemoverItem(int idLote)
        {
            try
            {
                var query = "DELETE FROM Itens_Venda WHERE idLote = @idLote"; // Modifiquei para usar idLote
                using (SqlConnection connection = dbController.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idLote", idLote);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover item: {ex.Message}");
                return false;
            }
        }


        // Método para listar todos os lotes disponíveis com nome do produto
        public List<Lote> ListarLotes()
        {
            List<Lote> lotes = new List<Lote>();
            string query = @"
                SELECT l.idLote, p.nomeProduto, l.quantidade
                FROM Lote l
                INNER JOIN Produto p ON l.idProduto = p.idProduto
                WHERE l.status = 'disponível'";

            using (SqlConnection conn = dbController.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lote lote = new Lote
                        {
                            IdLote = reader.GetInt32(reader.GetOrdinal("idLote")),
                            NomeProduto = reader.GetString(reader.GetOrdinal("nomeProduto")),
                            Quantidade = reader.GetInt32(reader.GetOrdinal("quantidade"))
                        };
                        lotes.Add(lote);
                    }
                }
            }

            return lotes;
        }

        public class Lote
        {
            public int IdLote { get; set; }
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }

            public override string ToString()
            {
                return $"Lote {IdLote} - {NomeProduto} (Quantidade: {Quantidade})";
            }
        }

        public class ItemVenda
        {
            public int IDLote { get; set; }
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }
        }
    }
}
