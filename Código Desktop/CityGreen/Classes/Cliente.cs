using CityGreen.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoVendas
{
    /// <summary>
    /// Classe Cliente responsável pelo gerenciamento de clientes.
    /// </summary>
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string ClienteTipo { get; set; }
        public string StatusCliente { get; set; } = "Ativo";

        private DatabaseController databaseController;

        public Cliente()
        {
            // Inicializa a classe de controle do banco de dados
            databaseController = new DatabaseController();
        }

        // Método para listar clientes
        public List<Cliente> ListarClientes(string termoPesquisa = null)
        {
            List<Cliente> clientes = new List<Cliente>();
            string query = "SELECT * FROM Cliente";

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                query += " WHERE nome LIKE @termoPesquisa OR cpf LIKE @termoPesquisa OR cnpj LIKE @termoPesquisa";
            }

            using (SqlConnection conn = databaseController.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(termoPesquisa))
                    {
                        cmd.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = reader.GetInt32(reader.GetOrdinal("idCliente")),
                            NomeCliente = reader.GetString(reader.GetOrdinal("nome")),
                            Telefone1 = reader.GetString(reader.GetOrdinal("telefone1")),
                            Telefone2 = reader.IsDBNull(reader.GetOrdinal("telefone2")) ? null : reader.GetString(reader.GetOrdinal("telefone2")),
                            CNPJ = reader.IsDBNull(reader.GetOrdinal("cnpj")) ? null : reader.GetString(reader.GetOrdinal("cnpj")),
                            Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString(reader.GetOrdinal("email")),
                            Endereco = reader.IsDBNull(reader.GetOrdinal("nomeEndereco")) ? null : reader.GetString(reader.GetOrdinal("nomeEndereco")),
                            NumeroEndereco = reader.IsDBNull(reader.GetOrdinal("numeroEndereco")) ? 0 : reader.GetInt32(reader.GetOrdinal("numeroEndereco")),
                            Bairro = reader.IsDBNull(reader.GetOrdinal("bairro")) ? null : reader.GetString(reader.GetOrdinal("bairro")),
                            Cidade = reader.IsDBNull(reader.GetOrdinal("cidade")) ? null : reader.GetString(reader.GetOrdinal("cidade")),
                            Estado = reader.IsDBNull(reader.GetOrdinal("estado")) ? null : reader.GetString(reader.GetOrdinal("estado")),
                            CEP = reader.IsDBNull(reader.GetOrdinal("cep")) ? null : reader.GetString(reader.GetOrdinal("cep")),
                            ClienteTipo = reader.IsDBNull(reader.GetOrdinal("clienteTipo")) ? null : reader.GetString(reader.GetOrdinal("clienteTipo")),
                            StatusCliente = reader.IsDBNull(reader.GetOrdinal("statusCliente")) ? null : reader.GetString(reader.GetOrdinal("statusCliente"))
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        // Método para visualizar um cliente específico pelo ID
        public Cliente VerCliente(int idCliente)
        {
            Cliente cliente = null;

            using (SqlConnection conn = databaseController.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Cliente WHERE idCliente = @idCliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            IdCliente = reader.GetInt32(reader.GetOrdinal("idCliente")),
                            NomeCliente = reader.GetString(reader.GetOrdinal("nome")),
                            Telefone1 = reader.GetString(reader.GetOrdinal("telefone1")),
                            Telefone2 = reader.IsDBNull(reader.GetOrdinal("telefone2")) ? null : reader.GetString(reader.GetOrdinal("telefone2")),
                            CNPJ = reader.IsDBNull(reader.GetOrdinal("cnpj")) ? null : reader.GetString(reader.GetOrdinal("cnpj")),
                            Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString(reader.GetOrdinal("email")),
                            Endereco = reader.IsDBNull(reader.GetOrdinal("nomeEndereco")) ? null : reader.GetString(reader.GetOrdinal("nomeEndereco")),
                            NumeroEndereco = reader.IsDBNull(reader.GetOrdinal("numeroEndereco")) ? 0 : reader.GetInt32(reader.GetOrdinal("numeroEndereco")),
                            Bairro = reader.IsDBNull(reader.GetOrdinal("bairro")) ? null : reader.GetString(reader.GetOrdinal("bairro")),
                            Cidade = reader.IsDBNull(reader.GetOrdinal("cidade")) ? null : reader.GetString(reader.GetOrdinal("cidade")),
                            Estado = reader.IsDBNull(reader.GetOrdinal("estado")) ? null : reader.GetString(reader.GetOrdinal("estado")),
                            CEP = reader.IsDBNull(reader.GetOrdinal("cep")) ? null : reader.GetString(reader.GetOrdinal("cep")),
                            ClienteTipo = reader.IsDBNull(reader.GetOrdinal("clienteTipo")) ? null : reader.GetString(reader.GetOrdinal("clienteTipo")),
                            StatusCliente = reader.IsDBNull(reader.GetOrdinal("statusCliente")) ? null : reader.GetString(reader.GetOrdinal("statusCliente"))
                        };
                    }
                }
            }
            return cliente;
        }

        // Método para cadastrar um cliente
        public bool CadastrarCliente()
        {
            using (SqlConnection conn = databaseController.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Cliente (nome, telefone1, telefone2, cpf, cnpj, email, nomeEndereco, numeroEndereco, bairro, cidade, estado, cep, clienteTipo, statusCliente) " +
                               "VALUES (@NomeCliente, @Telefone1, @Telefone2, @CPF, @CNPJ, @Email, @Endereco, @NumeroEndereco, @Bairro, @Cidade, @Estado, @CEP, @ClienteTipo, @StatusCliente)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
                    cmd.Parameters.AddWithValue("@Telefone1", Telefone1);
                    cmd.Parameters.AddWithValue("@Telefone2", Telefone2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CNPJ", CNPJ ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@NumeroEndereco", NumeroEndereco);
                    cmd.Parameters.AddWithValue("@Bairro", Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@ClienteTipo", ClienteTipo);
                    cmd.Parameters.AddWithValue("@StatusCliente", StatusCliente);

                    return cmd.ExecuteNonQuery() > 0; // Retorna true se inseriu com sucesso
                }
            }
        }

        // Método para editar um cliente
        public bool EditarCliente()
        {
            using (SqlConnection conn = databaseController.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Cliente SET nome = @NomeCliente, telefone1 = @Telefone1, telefone2 = @Telefone2, cpf = @CPF, cnpj = @CNPJ, email = @Email, " +
                               "nomeEndereco = @Endereco, numeroEndereco = @NumeroEndereco, bairro = @Bairro, cidade = @Cidade, estado = @Estado, cep = @CEP, " +
                               "clienteTipo = @ClienteTipo, statusCliente = @StatusCliente WHERE idCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                    cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
                    cmd.Parameters.AddWithValue("@Telefone1", Telefone1);
                    cmd.Parameters.AddWithValue("@Telefone2", Telefone2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CNPJ", CNPJ ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@NumeroEndereco", NumeroEndereco);
                    cmd.Parameters.AddWithValue("@Bairro", Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@ClienteTipo", ClienteTipo);
                    cmd.Parameters.AddWithValue("@StatusCliente", StatusCliente);

                    return cmd.ExecuteNonQuery() > 0; // Retorna true se atualizou com sucesso
                }
            }
        }
    }
}
