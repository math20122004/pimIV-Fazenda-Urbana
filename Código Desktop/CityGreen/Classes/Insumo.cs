using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        public string CNPJ { get; set; } // Alterado para referenciar o fornecedor através do CNPJ
        private DatabaseController dbController;

        public Insumo()
        {
            dbController = new DatabaseController();
        }

        // Método para cadastrar um novo insumo
        // Método para cadastrar um novo insumo
        public bool CadastrarInsumo()
        {
            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = @"INSERT INTO Insumo (idInsumo, nomeInsumo, quantidadeInsumo, dataValidade, idFornecedor) 
                           VALUES (@idInsumo, @nomeInsumo, @quantidadeInsumo, @dataValidade, @cnpj)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idInsumo", IdInsumo);
                        cmd.Parameters.AddWithValue("@nomeInsumo", NomeInsumo);
                        cmd.Parameters.AddWithValue("@quantidadeInsumo", QuantidadeInsumo);
                        cmd.Parameters.AddWithValue("@dataValidade", DataValidade);
                        cmd.Parameters.AddWithValue("@cnpj", CNPJ);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar insumo: " + ex.Message);
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
                    string sql = @"UPDATE Insumo 
                                   SET nomeInsumo = @nomeInsumo, quantidadeInsumo = @quantidadeInsumo, 
                                   validade = @validade, dataValidade = @dataValidade, idFornecedor = @cnpj 
                                   WHERE idInsumo = @idInsumo";

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
                    string sql = @"SELECT idInsumo, nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor 
                                   FROM Insumo 
                                   WHERE idInsumo = @idInsumo";

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
        public List<Insumo> ListarInsumos(string cnpj = null, string pesquisa = null)
        {
            List<Insumo> insumos = new List<Insumo>();

            using (SqlConnection conn = dbController.GetConnection())
            {
                try
                {
                    string sql = @"SELECT idInsumo, nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor 
                           FROM Insumo";

                    // Condição para filtrar por validade 'Disponivel' quando nenhum parâmetro é passado
                    if (string.IsNullOrEmpty(cnpj) && string.IsNullOrEmpty(pesquisa))
                    {
                        sql += " WHERE validade = 'Disponivel'";
                    }
                    else
                    {
                        // Adiciona a condição de CNPJ apenas se ele não estiver nulo
                        if (!string.IsNullOrEmpty(cnpj))
                        {
                            sql += " WHERE idFornecedor = @cnpj";
                        }

                        // Adiciona a pesquisa pelo nome do insumo, considerando se já existe uma condição WHERE
                        if (!string.IsNullOrEmpty(pesquisa))
                        {
                            sql += !string.IsNullOrEmpty(cnpj) ? " AND " : " WHERE ";
                            sql += "nomeInsumo LIKE @pesquisa";
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrEmpty(cnpj))
                        {
                            cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        }

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
