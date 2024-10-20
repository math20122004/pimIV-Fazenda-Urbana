using GestaoVendas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_Clientes : Form
    {
        Form_VerClientes verClientes;

        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Carregar clientes ao abrir o formulário, se necessário
            CarregarClientes("");
        }

        private void CarregarClientes(string pesquisa)
        {
            Cliente cliente = new Cliente();
            List<Cliente> listaClientes = cliente.ListarClientes(pesquisa);
            dgw_clientes.Rows.Clear(); // Limpa os dados existentes

            if (listaClientes != null && listaClientes.Count > 0)
            {
                lblMensagem.Visible = false;

                foreach (var c in listaClientes)
                {
                    int rowIndex = dgw_clientes.Rows.Add(
                        c.IdCliente,
                        c.NomeCliente,
                        c.StatusCliente,
                        c.Email
                    );

                    // Adiciona o botão "Visualizar" à linha
                    DataGridViewButtonCell btn_verCliente = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_clientes.Rows[rowIndex].Cells["col_VerClientes"] = btn_verCliente;
                }

                // Configura as cores após adicionar todas as linhas
                foreach (DataGridViewRow row in dgw_clientes.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerClientes"];
                    btnCell.FlatStyle = FlatStyle.Flat;
                    btnCell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                    btnCell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                    btnCell.Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1D7874");
                    btnCell.Style.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                }
            }
            else
            {
                lblMensagem.Visible = true;
            }
        }

        private void AbrirFormVerClientes(int idSelecionado, string funcao)
        {
            if (verClientes == null || verClientes.IsDisposed)
            {
                verClientes = new Form_VerClientes(idSelecionado, funcao)
                {
                    MdiParent = this.MdiParent,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                verClientes.FormClosed += VerClientes_FormClosed; // Associa o evento de fechamento
                verClientes.Show();
            }
            else
            {
                verClientes.Activate(); // Ativa o formulário se já estiver aberto
            }
        }

        private void VerClientes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verClientes = null;
        }

        private void btn_VerClientes_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                int idSelecionado = int.Parse(dgw_clientes.Rows[e.RowIndex].Cells["col_ID"].Value.ToString());
                AbrirFormVerClientes(idSelecionado, "ver");
            }
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            CarregarClientes("");
            tbx_pequisa.Text = ""; // Reseta a pesquisa
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisa.Text;
            CarregarClientes(pesquisa); // Filtra a lista de clientes conforme a pesquisa
        }

        private void btn_VerVendas_Click(object sender, EventArgs e)
        {
            // Fecha o Form_Clientes ao clicar no botão Ver Vendas
            this.Close();
        }

        private void btn_CadastrarCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormVerClientes(0, "cadastro"); // Chama para cadastrar um novo cliente
        }

    }
}
