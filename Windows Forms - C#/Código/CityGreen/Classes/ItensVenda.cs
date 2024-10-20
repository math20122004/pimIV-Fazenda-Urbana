using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoVendas
{
    public class ItensVenda
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public int IdLote { get; set; }
        public int IdVenda { get; set; }

        // Método para adicionar item à venda
        public void AdicionarItem(int idVenda, int idLote, int quantidade, double valorUnitario)
        {
            using (SqlConnection conn = new SqlConnection("sua_connection_string"))
            {
                conn.Open();
                string query = "INSERT INTO Itens_Venda (quantidade, valor_total, lote, fk_Venda_idVenda) " +
                               "VALUES (@quantidade, @valorTotal, @lote, @idVenda)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@valorTotal", quantidade * valorUnitario);
                    cmd.Parameters.AddWithValue("@lote", idLote);
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para listar itens de uma venda específica
        public List<ItensVenda> ListarItens(int idVenda)
        {
            List<ItensVenda> itensVenda = new List<ItensVenda>();
            string query = "SELECT quantidade, valor_total, lote FROM Itens_Venda WHERE fk_Venda_idVenda = @idVenda";

            using (SqlConnection conn = new SqlConnection("sua_connection_string"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ItensVenda item = new ItensVenda
                        {
                            Quantidade = reader.GetInt32(0),
                            ValorUnitario = reader.GetDouble(1) / reader.GetInt32(0), // Calculo do valor unitário
                            IdLote = reader.GetInt32(2),
                            IdVenda = idVenda
                        };
                        itensVenda.Add(item);
                    }
                }
            }

            return itensVenda;
        }
    }
}
