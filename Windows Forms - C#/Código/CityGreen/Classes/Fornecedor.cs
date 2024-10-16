using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CityGreen.Classes;
using CityGreen.Classes;


namespace Gestão_Fornecedores
{
    public class Fornecedor
    {
        // Atributos
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string StatusFornecedor { get; set; } = "ativo";
        public string Tipo { get; set; }
        public string InfAdicionais { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        private DatabaseController dbController;

        public Fornecedor()
        {
            dbController = new DatabaseController();
        }

        // Método para listar fornecedores
public List<Fornecedor> ListarFornecedores(string pesquisa = "")
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();

            string query = "SELECT idFornecedor, nome, status, email FROM Fornecedores WHERE nome LIKE @pesquisa OR email LIKE @pesquisa";
            using (SqlConnection connection = dbController.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor
                    {
                        IdFornecedor = reader.GetInt32(0),
                        NomeFornecedor = reader.GetString(1),
                        StatusFornecedor = reader.GetString(2),
                        Email = reader.GetString(3)
                    };
                    listaFornecedores.Add(fornecedor);
                }
            }
            return listaFornecedores;
        }


        public Fornecedor VerFornecedor(int idFornecedor)
        {
            string query = "SELECT * FROM Fornecedores WHERE idFornecedor = @idFornecedor";

            using (SqlConnection connection = dbController.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Fornecedor
                    {
                        IdFornecedor = reader.GetInt32(reader.GetOrdinal("idFornecedor")),
                        NomeFornecedor = reader["nome"] as string ?? "",
                        RazaoSocial = reader["razaoSocial"] as string ?? "",
                        CNPJ = reader["cnpj"] as string ?? "",
                        Telefone1 = reader["telefone1"] as string ?? "",
                        Telefone2 = reader["telefone2"] as string ?? "",
                        Email = reader["email"] as string ?? "",
                        StatusFornecedor = reader["status"] as string ?? "",
                        Tipo = reader["tipo"] as string ?? "",
                        InfAdicionais = reader["infAdicionais"] as string ?? "",
                        Endereco = reader["endereco"] as string ?? "",
                        NumeroEndereco = reader["numeroEndereco"] as int? ?? 0,
                        Bairro = reader["bairro"] as string ?? "",
                        Cidade = reader["cidade"] as string ?? "",
                        Estado = reader["estado"] as string ?? "",
                        Pais = reader["pais"] as string ?? "",
                        CEP = reader["cep"] as string ?? ""
                    };
                }
            }

            return null;
        }


        // Método para cadastrar fornecedor
        public bool CadastrarFornecedor()
        {
            string query = @"
        INSERT INTO Fornecedores 
        (nome, razaoSocial, cnpj, telefone1, telefone2, email, status, tipo, infAdicionais, endereco, numeroEndereco, bairro, cidade, estado, pais, cep) 
        VALUES 
        (@nome, @razaoSocial, @cnpj, @telefone1, @telefone2, @Email, @status, @tipo, @infAdicionais, @endereco, @numeroEndereco, @bairro, @cidade, @estado, @pais, @cep)";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(NomeFornecedor) ? (object)DBNull.Value : NomeFornecedor);
                    command.Parameters.AddWithValue("@razaoSocial", string.IsNullOrEmpty(RazaoSocial) ? (object)DBNull.Value : RazaoSocial);
                    command.Parameters.AddWithValue("@cnpj", string.IsNullOrEmpty(CNPJ) ? (object)DBNull.Value : CNPJ);
                    command.Parameters.AddWithValue("@telefone1", string.IsNullOrEmpty(Telefone1) ? (object)DBNull.Value : Telefone1);
                    command.Parameters.AddWithValue("@telefone2", string.IsNullOrEmpty(Telefone2) ? (object)DBNull.Value : Telefone2);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                    command.Parameters.AddWithValue("@status", StatusFornecedor);
                    command.Parameters.AddWithValue("@tipo", string.IsNullOrEmpty(Tipo) ? (object)DBNull.Value : Tipo);
                    command.Parameters.AddWithValue("@infAdicionais", string.IsNullOrEmpty(InfAdicionais) ? (object)DBNull.Value : InfAdicionais);
                    command.Parameters.AddWithValue("@endereco", string.IsNullOrEmpty(Endereco) ? (object)DBNull.Value : Endereco);
                    command.Parameters.AddWithValue("@numeroEndereco", NumeroEndereco == 0 ? (object)DBNull.Value : NumeroEndereco);
                    command.Parameters.AddWithValue("@bairro", string.IsNullOrEmpty(Bairro) ? (object)DBNull.Value : Bairro);
                    command.Parameters.AddWithValue("@cidade", string.IsNullOrEmpty(Cidade) ? (object)DBNull.Value : Cidade);
                    command.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(Estado) ? (object)DBNull.Value : Estado);
                    command.Parameters.AddWithValue("@pais", string.IsNullOrEmpty(Pais) ? (object)DBNull.Value : Pais);
                    command.Parameters.AddWithValue("@cep", string.IsNullOrEmpty(CEP) ? (object)DBNull.Value : CEP);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar fornecedor: {ex.Message}");
                return false;
            }
        }

        // Método para editar fornecedor
        public bool EditarFornecedor()
        {
            string query = @"
                UPDATE Fornecedores SET nome = @nome, razaoSocial = @razaoSocial, telefone1 = @telefone1, telefone2 = @telefone2, email = @Email, status = @status, tipo = @tipo, 
                infAdicionais = @infAdicionais, endereco = @endereco, numeroEndereco = @numeroEndereco, bairro = @bairro, cidade = @cidade, estado = @estado, pais = @pais, cep = @cep 
                WHERE idFornecedor = @idFornecedor";

            try
            {
                using (SqlConnection connection = dbController.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", NomeFornecedor);
                    command.Parameters.AddWithValue("@razaoSocial", RazaoSocial);
                    command.Parameters.AddWithValue("@telefone1", Telefone1);
                    command.Parameters.AddWithValue("@telefone2", Telefone2);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@status", StatusFornecedor);
                    command.Parameters.AddWithValue("@tipo", Tipo);
                    command.Parameters.AddWithValue("@infAdicionais", InfAdicionais);
                    command.Parameters.AddWithValue("@endereco", Endereco);
                    command.Parameters.AddWithValue("@numeroEndereco", NumeroEndereco);
                    command.Parameters.AddWithValue("@bairro", Bairro);
                    command.Parameters.AddWithValue("@cidade", Cidade);
                    command.Parameters.AddWithValue("@estado", Estado);
                    command.Parameters.AddWithValue("@pais", Pais);
                    command.Parameters.AddWithValue("@cep", CEP);
                    command.Parameters.AddWithValue("@idFornecedor", IdFornecedor);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar fornecedor: {ex.Message}");
                return false;
            }
        }
    }
}
