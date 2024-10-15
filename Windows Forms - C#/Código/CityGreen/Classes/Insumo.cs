using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CityGreen.Classes;
using CityGreen.Classes;

namespace Gestão_Fornecedores
{
    public class Insumo
    {
        // Atributos
        public int IdInsumo { get; set; }
        public string NomeInsumo { get; set; }
        public int QuantidadeInsumo { get; set; }
        public string Validade { get; set; } = "Disponivel"; // 'Vencido', 'Disponivel', 'Esgotado'
        public DateTime DataValidade { get; set; }
        public DateTime DataCompra { get; set; }
        public int IdCompra { get; set; }
        public Fornecedor Fornecedor { get; set; }
        private DatabaseController dbController;

        public Insumo()
        {
            dbController = new DatabaseController();
        }

        // Método para listar insumos com fornecedor e compra relacionados
        public List<Insumo> ListarInsumos()
        {
            string query = @"
                SELECT i.*, f.nome AS NomeFornecedor, f.cnpj, c.dataCompra 
                FROM Insumo i
                JOIN CompraInsumo c ON i.idCompra = c.idCompra
                JOIN Fornecedores f ON c.idFornecedor = f.idFornecedor";

            List<Insumo> insumos = new List<Insumo>();

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            insumos.Add(new Insumo
                            {
                                IdInsumo = (int)reader["idInsumo"],
                                NomeInsumo = reader["nomeInsumo"].ToString(),
                                QuantidadeInsumo = (int)reader["quantidadeInsumo"],
                                Validade = reader["validade"].ToString(),
                                DataValidade = Convert.ToDateTime(reader["dataValidade"]),
                                DataCompra = Convert.ToDateTime(reader["dataCompra"]),
                                IdCompra = (int)reader["idCompra"],
                                Fornecedor = new Fornecedor
                                {
                                    IdFornecedor = (int)reader["idFornecedor"],
                                    NomeFornecedor = reader["NomeFornecedor"].ToString(),
                                    CNPJ = reader["cnpj"].ToString()
                                }
                            });
                        }
                    }
                }
                return insumos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar insumos: {ex.Message}");
                return null;
            }
        }

        // Método para cadastrar insumo com referência à compra e fornecedor
        public bool CadastrarInsumo()
        {
            string query = @"
                INSERT INTO Insumo (nomeInsumo, quantidadeInsumo, validade, dataValidade, idCompra) 
                VALUES (@nomeInsumo, @quantidadeInsumo, @validade, @dataValidade, @idCompra)";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeInsumo", NomeInsumo);
                    command.Parameters.AddWithValue("@quantidadeInsumo", QuantidadeInsumo);
                    command.Parameters.AddWithValue("@validade", Validade);
                    command.Parameters.AddWithValue("@dataValidade", DataValidade);
                    command.Parameters.AddWithValue("@idCompra", IdCompra);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar insumo: {ex.Message}");
                return false;
            }
        }

        // Método para editar um insumo existente
        public bool EditarInsumo()
        {
            string query = @"
                UPDATE Insumo 
                SET nomeInsumo = @nomeInsumo, quantidadeInsumo = @quantidadeInsumo, validade = @validade, dataValidade = @dataValidade 
                WHERE idInsumo = @idInsumo";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeInsumo", NomeInsumo);
                    command.Parameters.AddWithValue("@quantidadeInsumo", QuantidadeInsumo);
                    command.Parameters.AddWithValue("@validade", Validade);
                    command.Parameters.AddWithValue("@dataValidade", DataValidade);
                    command.Parameters.AddWithValue("@idInsumo", IdInsumo);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar insumo: {ex.Message}");
                return false;
            }
        }

        // Método para visualizar detalhes de um insumo específico
        public Insumo VerInsumo(int idInsumo)
        {
            string query = @"
                SELECT i.*, f.nome AS NomeFornecedor, f.cnpj, c.dataCompra 
                FROM Insumo i
                JOIN CompraInsumo c ON i.idCompra = c.idCompra
                JOIN Fornecedores f ON c.idFornecedor = f.idFornecedor
                WHERE i.idInsumo = @idInsumo";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idInsumo", idInsumo);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Insumo
                            {
                                IdInsumo = (int)reader["idInsumo"],
                                NomeInsumo = reader["nomeInsumo"].ToString(),
                                QuantidadeInsumo = (int)reader["quantidadeInsumo"],
                                Validade = reader["validade"].ToString(),
                                DataValidade = Convert.ToDateTime(reader["dataValidade"]),
                                DataCompra = Convert.ToDateTime(reader["dataCompra"]),
                                IdCompra = (int)reader["idCompra"],
                                Fornecedor = new Fornecedor
                                {
                                    IdFornecedor = (int)reader["idFornecedor"],
                                    NomeFornecedor = reader["NomeFornecedor"].ToString(),
                                    CNPJ = reader["cnpj"].ToString()
                                }
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao visualizar insumo: {ex.Message}");
                return null;
            }
        }
    }
}
