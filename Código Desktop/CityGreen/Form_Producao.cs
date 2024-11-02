using GestaoProducao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_Producao : Form
    {
        Form_VerProducao verProducao;
        private Producao producaoController;

        public Form_Producao()
        {
            InitializeComponent();
            producaoController = new Producao(); // Controlador de produção
        }

        private void Form_Producao_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CarregarProducao("");
        }

        private void CarregarProducao(string pesquisa)
        {
            List<Producao> listaProducao = producaoController.ListarProducoes(pesquisa);
            dgw_producao.Rows.Clear(); // Limpa os dados existentes

            if (listaProducao != null && listaProducao.Count > 0)
            {
                lblMensagem.Visible = false;

                foreach (var p in listaProducao)
                {
                    int rowIndex = dgw_producao.Rows.Add(
                        p.IdPlantio,
                        p.Produto,
                        p.DataInicio.ToString("dd/MM/yyyy"),
                        p.DataFim?.ToString("dd/MM/yyyy") ?? "-",
                        p.StatusProducao
                    );

                    // Adiciona o botão "Visualizar" à linha
                    DataGridViewButtonCell btn_verProducao = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_producao.Rows[rowIndex].Cells["col_VerProducao"] = btn_verProducao;
                }

                // Configura as cores após adicionar todas as linhas
                foreach (DataGridViewRow row in dgw_producao.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerProducao"];
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

        private void AbrirFormVerProducao(int IDSelecionado, string funcao)
        {
            if (verProducao == null || verProducao.IsDisposed)
            {
                verProducao = new Form_VerProducao(funcao, IDSelecionado)
                {
                    MdiParent = this.MdiParent
                };

                verProducao.ControlBox = false;
                verProducao.FormBorderStyle = FormBorderStyle.FixedDialog;
                verProducao.FormClosed += VerProducao_FormClosed;
                verProducao.Show();
            }
            else
            {
                verProducao.Activate();
            }
        }

        private void VerProducao_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verProducao = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_producao.PerformClick(); // Simula o clique
            }

            this.Activate();
        }

        private void btn_CadastrarFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormVerProducao(0, "cadastro");
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            CarregarProducao("");
            tbx_pequisa.Text = "";
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisa.Text;
            CarregarProducao(pesquisa);
        }

        private void btn_VerProducao_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idSelecionado = int.Parse(dgw_producao.Rows[e.RowIndex].Cells["col_ID"].Value.ToString());
                AbrirFormVerProducao(idSelecionado, "ver");
            }
        }
    }
}
