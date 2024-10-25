using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoVendas
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public string NumeroVenda { get; set; }
        public string StatusVenda { get; set; } // "Cancelado", "Entregue", "Em andamento"
        public string InfoAdicionais { get; set; }
        public string NomeCliente { get; set; }
        public int IdCliente { get; set; } // ID do cliente associado

        private readonly DatabaseController dbController;

        public Vendas()
        {
            dbController = new DatabaseController();
        }

        public int CadastrarVenda(string numero, int idCliente, string infoAdicionais)
        {
            int idVendaGerado = 0; // Variável para armazenar o ID gerado

            try
            {
                // Atualiza a query para capturar o ID gerado
                var query = "INSERT INTO Vendas (numero, infoAdicionais, idCliente, statusVenda) OUTPUT INSERTED.idVenda VALUES (@numero, @infoAdicionais, @idCliente, 'Em andamento')";

                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@infoAdicionais", infoAdicionais);
                    command.Parameters.AddWithValue("@idCliente", idCliente);

                    connection.Open();
                    // Captura o ID gerado
                    idVendaGerado = (int)command.ExecuteScalar();
                }

                Console.WriteLine("Venda cadastrada com sucesso! ID da venda: " + idVendaGerado);
                return idVendaGerado; // Retorna o ID da venda
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro de SQL ao cadastrar a venda: {ex.Message} | Código de erro: {ex.ErrorCode}");
                return 0; // Retorna 0 em caso de erro
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar a venda: {ex.Message}");
                return 0; // Retorna 0 em caso de erro
            }
        }


        public List<Vendas> ListarVendas(string termoPesquisa)
        {
            List<Vendas> vendasList = new List<Vendas>();
            // Atualiza a query para incluir o nome do cliente
            string query = @"
        SELECT v.idVenda, v.numero, v.idCliente, c.nome, v.statusVenda 
        FROM Vendas v
        INNER JOIN Cliente c ON v.idCliente = c.idCliente";

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                query += " WHERE v.numero LIKE @termoPesquisa OR v.statusVenda LIKE @termoPesquisa";
            }

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrWhiteSpace(termoPesquisa))
                    {
                        command.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Vendas venda = new Vendas
                        {
                            IdVenda = reader.GetInt32(0),
                            NumeroVenda = reader.GetString(1),
                            IdCliente = reader.GetInt32(2),
                            NomeCliente = reader.GetString(3), // Armazena o nome do cliente
                            StatusVenda = reader.GetString(4)
                        };
                        vendasList.Add(venda);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar vendas: {ex.Message}");
            }

            return vendasList;
        }


        public Vendas VerVenda(int idVenda)
        {
            try
            {
                var query = "SELECT * FROM Vendas WHERE idVenda = @idVenda";
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idVenda", idVenda);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Vendas
                        {
                            IdVenda = reader.GetInt32(reader.GetOrdinal("idVenda")),
                            NumeroVenda = reader.GetString(reader.GetOrdinal("numero")),
                            StatusVenda = reader.GetString(reader.GetOrdinal("statusVenda")),
                            IdCliente = reader.GetInt32(reader.GetOrdinal("idCliente")),
                            InfoAdicionais = reader.GetString(reader.GetOrdinal("infoAdicionais"))
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao visualizar a venda: {ex.Message}");
            }

            return null;
        }


        public bool EditarVenda(int idVenda, int idCliente, string statusVenda)
        {
            try
            {
                var query = "UPDATE Vendas SET numero = @numero, infoAdicionais = @infoAdicionais, idCliente = @idCliente, statusVenda = @statusVenda WHERE idVenda = @idVenda";
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idVenda", idVenda);
                    command.Parameters.AddWithValue("@numero", this.NumeroVenda);
                    command.Parameters.AddWithValue("@infoAdicionais", this.InfoAdicionais);
                    command.Parameters.AddWithValue("@idCliente", idCliente); // Adiciona o parâmetro para o cliente
                    command.Parameters.AddWithValue("@statusVenda", statusVenda); // Adiciona o parâmetro para o status

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Venda editada com sucesso!");
                return true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Erro de SQL ao editar a venda: {sqlEx.Message} | Código de erro: {sqlEx.ErrorCode}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar a venda: {ex.Message}");
                return false;
            }
        }


    }
}
