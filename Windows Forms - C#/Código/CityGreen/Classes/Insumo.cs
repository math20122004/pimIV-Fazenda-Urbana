using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CityGreen.Classes;

namespace Gestão_Fornecedores
{
    public class Insumo
    {
        // Atributos
        public int IdInsumo { get; set; }
        public string NomeInsumo { get; set; }
        public int QuantidadeInsumo { get; set; }
        public DateTime DataValidade { get; set; }
        public string Validade { get; set; }
        public string CNPJ { get; set; } // Alterado de IdFornecedor para CNPJ
        public Fornecedor Fornecedor { get; set; }
        private DatabaseController dbController;

        public Insumo()
        {
            dbController = new DatabaseController();
        }

        // Método para cadastrar um novo insumo
        public bool CadastrarInsumo()
        {
            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = "INSERT INTO Insumo (nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor) " +
                                 "VALUES (@nomeInsumo, @quantidadeInsumo, @validade, @dataValidade, @cnpj)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeInsumo", NomeInsumo);
                        cmd.Parameters.AddWithValue("@quantidadeInsumo", QuantidadeInsumo);
                        cmd.Parameters.AddWithValue("@validade", Validade);
                        cmd.Parameters.AddWithValue("@dataValidade", DataValidade);
                        cmd.Parameters.AddWithValue("@cnpj", CNPJ);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastrar insumo: " + ex.Message);
                    return false;
                }
            }
        }

        // Método para editar um insumo existente
        public bool EditarInsumo()
        {
            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = "UPDATE Insumo SET nomeInsumo = @nomeInsumo, quantidadeInsumo = @quantidadeInsumo, " +
                                 "validade = @validade, dataValidade = @dataValidade, idFornecedor = @cnpj " +
                                 "WHERE idInsumo = @idInsumo";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idInsumo", IdInsumo);
                        cmd.Parameters.AddWithValue("@nomeInsumo", NomeInsumo);
                        cmd.Parameters.AddWithValue("@quantidadeInsumo", QuantidadeInsumo);
                        cmd.Parameters.AddWithValue("@validade", Validade);
                        cmd.Parameters.AddWithValue("@dataValidade", DataValidade);
                        cmd.Parameters.AddWithValue("@cnpj", CNPJ);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao editar insumo: " + ex.Message);
                    return false;
                }
            }
        }

        // Método para visualizar um insumo por ID
        public Insumo VerInsumo(int idInsumo)
        {
            Insumo insumo = null;

            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = "SELECT idInsumo, nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor " +
                                 "FROM Insumo WHERE idInsumo = @idInsumo";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                insumo = new Insumo
                                {
                                    IdInsumo = reader.GetInt32(0),
                                    NomeInsumo = reader.GetString(1),
                                    QuantidadeInsumo = reader.GetInt32(2),
                                    Validade = reader.GetString(3),
                                    DataValidade = reader.GetDateTime(4),
                                    CNPJ = reader.GetString(5)
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar insumo: " + ex.Message);
                }
            }

            return insumo;
        }

        // Método para listar insumos filtrando por CNPJ e pesquisa
        public List<Insumo> ListarInsumos(string cnpj, string pesquisa)
        {
            List<Insumo> insumos = new List<Insumo>();

            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = "SELECT idInsumo, nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor " +
                                 "FROM Insumo WHERE idFornecedor = @cnpj";

                    if (!string.IsNullOrEmpty(pesquisa))
                    {
                        sql += " AND nomeInsumo LIKE @pesquisa";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);

                        if (!string.IsNullOrEmpty(pesquisa))
                        {
                            cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                        }

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Insumo insumo = new Insumo
                                {
                                    IdInsumo = reader.GetInt32(0),
                                    NomeInsumo = reader.GetString(1),
                                    QuantidadeInsumo = reader.GetInt32(2),
                                    Validade = reader.GetString(3),
                                    DataValidade = reader.GetDateTime(4),
                                    CNPJ = reader.GetString(5)
                                };

                                insumos.Add(insumo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao listar insumos: " + ex.Message);
                }
            }

            return insumos;
        }
    }
}
