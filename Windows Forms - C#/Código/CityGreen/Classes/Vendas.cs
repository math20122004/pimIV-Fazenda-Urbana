using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CityGreen.Classes;
using GestaoVendas;

namespace Gestão_Vendas
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public string NumeroVenda { get; set; }
        public string StatusVenda { get; set; } // "Cancelado", "Entregue", "Em andamento"
        public string InfoAdicionais { get; set; }
        public int IdCliente { get; set; } // ID do cliente associado

        private readonly DatabaseController dbController;

        public Vendas()
        {
            dbController = new DatabaseController();
        }

        public bool CadastrarVenda(string numero, int idCliente, string infoAdicionais)
        {
            try
            {
                var query = "INSERT INTO Vendas (numero, infoAdicionais, idCliente) VALUES (@numero, @infoAdicionais, @idCliente)";

                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@infoAdicionais", infoAdicionais);
                    command.Parameters.AddWithValue("@idCliente", idCliente);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Venda cadastrada com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar a venda: {ex.Message}");
                return false;
            }
        }

        public List<Vendas> ListarVendas(string termoPesquisa)
        {
            List<Vendas> vendasList = new List<Vendas>();
            string query = "SELECT idVenda, numero, idCliente, statusVenda FROM Vendas";

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                query += " WHERE numero LIKE @termoPesquisa OR statusVenda LIKE @termoPesquisa";
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
                            StatusVenda = reader.GetString(3)
                        };
                        vendasList.Add(venda);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Erro ao listar vendas: {ex.Message}");
            }

            return vendasList;
        }



        public bool VerVenda(int idVenda)
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
                        Console.WriteLine($"Número da Venda: {reader["numero"]}");
                        Console.WriteLine($"Status: {reader["statusVenda"]}");
                        Console.WriteLine($"Cliente ID: {reader["idCliente"]}");
                        Console.WriteLine($"Info Adicionais: {reader["infoAdicionais"]}");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao visualizar a venda: {ex.Message}");
                return false;
            }
        }

        public bool EditarVenda(int idVenda, string novoStatus, string novasInfoAdicionais)
        {
            try
            {
                var query = "UPDATE Vendas SET statusVenda = @novoStatus, infoAdicionais = @novasInfoAdicionais WHERE idVenda = @idVenda";
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idVenda", idVenda);
                    command.Parameters.AddWithValue("@novoStatus", novoStatus);
                    command.Parameters.AddWithValue("@novasInfoAdicionais", novasInfoAdicionais);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Venda editada com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar a venda: {ex.Message}");
                return false;
            }
        }

        // Método para listar itens de uma venda específica
        public List<ItensVenda> ListarItensVenda(int idVenda)
        {
            ItensVenda itensVenda = new ItensVenda();
            return itensVenda.ListarItens(idVenda);
        }
    }
}
