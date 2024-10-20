using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestão_Vendas;
using GestaoVendas;

namespace CityGreen
{
    public partial class Form_Vendas : Form
    {
        Form_VerVendas verVendas;
        private Vendas vendasController;
        Form_Clientes clientesController; // Controlador de clientes

        public Form_Vendas()
        {
            InitializeComponent();
            vendasController = new Vendas(); // Instância do controlador de vendas
        }

        private void Form_Vendas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CarregarVendas("");
        }

        private void CarregarVendas(string pesquisa)
        {
            Vendas venda = new Vendas();
            List<Vendas> listaVendas = venda.ListarVendas(pesquisa);
            dgw_Vendas.Rows.Clear(); // Limpa os dados existentes

            if (listaVendas != null && listaVendas.Count > 0)
            {
                lblMensagem.Visible = false;

                foreach (var v in listaVendas)
                {
                    int rowIndex = dgw_Vendas.Rows.Add(
                        v.IdVenda,
                        v.NumeroVenda,
                        v.IdCliente,
                        v.StatusVenda
                    );

                    // Adiciona o botão "Visualizar" à linha
                    DataGridViewButtonCell btn_verVenda = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_Vendas.Rows[rowIndex].Cells["col_VerVenda"] = btn_verVenda;
                }

                // Configura as cores após adicionar todas as linhas
                foreach (DataGridViewRow row in dgw_Vendas.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerVenda"];
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

        private void AbrirFormVerVendas(int IDSelecionado, string funcao)
        {
            if (verVendas == null || verVendas.IsDisposed)
            {
                verVendas = new Form_VerVendas(IDSelecionado, funcao)
                {
                    MdiParent = this.MdiParent
                };

                verVendas.ControlBox = false;
                verVendas.FormBorderStyle = FormBorderStyle.FixedDialog;
                verVendas.FormClosed += VerVendas_FormClosed;
                verVendas.Show();
            }
            else
            {
                verVendas.Activate();
            }
        }

        private void VerVendas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verVendas = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_vendas.PerformClick(); // Simula o clique
            }

            this.Activate();
        }

        private void AbrirFormClientes()
        {
            if (clientesController == null || clientesController.IsDisposed)
            {
                clientesController = new Form_Clientes
                {
                    MdiParent = this.MdiParent,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                clientesController.FormClosed += Clientes_FormClosed; // Associa o evento de fechamento
                clientesController.Show();
            }
            else
            {
                clientesController.Activate(); // Ativa o formulário se já estiver aberto
            }
        }

        private void Clientes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            clientesController = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_vendas.PerformClick(); // Simula o clique
            }

            this.Activate();
        }

        private void btn_verInsumo_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                int idSelecionado = int.Parse(dgw_Vendas.Rows[e.RowIndex].Cells["col_ID"].Value.ToString());
                AbrirFormVerVendas(idSelecionado, "ver");
            }
        }

        private void btn_CadastrarVendas_Click(object sender, EventArgs e)
        {
            AbrirFormVerVendas(0, "cadastro");
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            CarregarVendas("");
            tbx_pequisa.Text = "";
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisa.Text;
            CarregarVendas(pesquisa);
        }

        private void btn_VerCliente_Click(object sender, EventArgs e)
        {
            AbrirFormClientes(); 
        }
    }
}
