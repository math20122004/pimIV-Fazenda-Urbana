using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CityGreen.Classes;
using Gestão_Fornecedores;

namespace CityGreen
{
    public partial class Form_Fornecedores : Form
    {
        Form_VerFornecedor verFornecedor;

        public Form_Fornecedores()
        {
            InitializeComponent();
        }

        private void Form_Fornecedores_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CarregarFornecedores("");
        }

        private void CarregarFornecedores(string pesquisa)
        {
            Fornecedor fornecedor = new Fornecedor();
            List<Fornecedor> listaFornecedores = fornecedor.ListarFornecedores(pesquisa);
            dgw_fornecedores.Rows.Clear(); // Limpa os dados existentes

            if (listaFornecedores != null && listaFornecedores.Count > 0)
            {
                lblMensagem.Visible = false;

                foreach (var forn in listaFornecedores)
                {
                    int rowIndex = dgw_fornecedores.Rows.Add(
                        forn.IdFornecedor,
                        forn.NomeFornecedor,
                        forn.StatusFornecedor,
                        forn.Email
                    );

                    // Adiciona o botão "Visualizar" à linha
                    DataGridViewButtonCell btn_verFornecedor = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_fornecedores.Rows[rowIndex].Cells["col_VerFornecedor"] = btn_verFornecedor;
                }

                // Configura as cores após adicionar todas as linhas
                foreach (DataGridViewRow row in dgw_fornecedores.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerFornecedor"];
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

        private void dgw_fornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgw_fornecedores.Columns["col_VerFornecedor"].Index && e.RowIndex >= 0)
            {
                btn_verFornecedor_Click(sender, e);
            }
        }

        private void btn_verFornecedor_Click(object sender, DataGridViewCellEventArgs e)
        {
            string idFornecedorSelecionado = dgw_fornecedores.Rows[e.RowIndex].Cells["col_ID"].Value.ToString();
            AbrirFormVerFornecedor(idFornecedorSelecionado, "ver"); // Passa o ID e a string "ver"
        }

        public void AbrirFormVerFornecedor(string idFornecedorSelecionado, string funcao)
        {
            if (verFornecedor == null || verFornecedor.IsDisposed)
            {
                Form_VerFornecedor verFornecedor = new Form_VerFornecedor(idFornecedorSelecionado, funcao)
                {
                    MdiParent = this.MdiParent
                };

                verFornecedor.ControlBox = false;
                verFornecedor.FormBorderStyle = FormBorderStyle.FixedDialog;
                verFornecedor.FormClosed += VerFornecedor_FormClosed;
                verFornecedor.Show();
            }
            else
            {
                verFornecedor.Activate();
            }
        }

        private void VerFornecedor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verFornecedor = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_usuarios.PerformClick(); // Simula o clique
            }

            this.Activate();
        }


        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            CarregarFornecedores("");
            tbx_pequisa.Text = "";
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisa.Text;
            CarregarFornecedores(pesquisa);
        }

        private void btn_CadastrarFornecedor_Click(object sender, EventArgs e)
        {
            string idFornecedorParaCadastrar = ""; // ou um ID específico se necessário
            AbrirFormVerFornecedor(idFornecedorParaCadastrar, "cadastro");
        }

    }
}
