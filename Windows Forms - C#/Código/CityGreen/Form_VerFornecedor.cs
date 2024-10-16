using Gestão_Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerFornecedor : Form
    {

        private string idFornecedor;
        private string funcao;
        private Fornecedor fornecedor;

        public Form_VerFornecedor(string idFornecedor, string funcao)
        {
            this.Location = new Point(0, 0);
            InitializeComponent();
            this.idFornecedor = idFornecedor;
            this.funcao = funcao;
        }


        private void Form_VerFornecedor_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.AutoScroll = true;

            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                DesabilitarCampos();
                lbl_funcao.Text = "Visualizar Fornecedor";
                CarregarInsumos("");
                VerUsuario();
            }
            else
            {
                this.Height = 539;
                pn_Insumo.Hide();
                lbl_funcao.Text = "Cadastrar Fornecedor";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
            }
        }

        private void VerUsuario()
        {
            fornecedor = new Fornecedor().VerFornecedor(int.Parse(idFornecedor));

            if (fornecedor != null)
            {
                tbx_ID.Text = fornecedor.IdFornecedor.ToString();
                tbx_nome.Text = fornecedor.NomeFornecedor;
                tbx_email.Text = fornecedor.Email;
                tbx_CNPJ.Text = fornecedor.CNPJ;
                txb_RazaoSocial.Text = fornecedor.RazaoSocial;
                txb_Endereco.Text = fornecedor.Endereco;
                txb_Numero.Text = fornecedor.NumeroEndereco.ToString();
                txb_Bairro.Text = fornecedor.Bairro;
                txb_Cidade.Text = fornecedor.Cidade;
                txb_Estado.Text = fornecedor.Estado;
                txb_CEP.Text = fornecedor.CEP;
                txb_InfoAdicional.Text = fornecedor.InfAdicionais;
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado.");
                this.Close();
            }
        }



        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            tbx_nome.Enabled = false;
            tbx_email.Enabled = false;
            tbx_CNPJ.Enabled = false;
            txb_RazaoSocial.Enabled = false;
            txb_Endereco.Enabled = false;
            txb_Numero.Enabled = false;
            txb_Bairro.Enabled = false;
            txb_Cidade.Enabled = false;
            txb_Estado.Enabled = false;
            txb_CEP.Enabled = false;
            txb_InfoAdicional.Enabled = false;

        }

        private void HabilitarCampos()
        {
            tbx_ID.Enabled = true;
            tbx_nome.Enabled = true;
            tbx_email.Enabled = true;
            tbx_CNPJ.Enabled = true;
            txb_RazaoSocial.Enabled = true;
            txb_Endereco.Enabled = true;
            txb_Numero.Enabled = true;
            txb_Bairro.Enabled = true;
            txb_Cidade.Enabled = true;
            txb_Estado.Enabled = true;
            txb_CEP.Enabled = true;
            txb_InfoAdicional.Enabled = true;

        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Usuário";
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "ver")
                {
                    SalvarFornecedor(); // Chama o método para salvar as informações do fornecedor
                }
                else if (funcao == "cadastro")
                {
                    CadastrarFornecedor(); // Chama o método para cadastrar um novo fornecedor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        // Método para cadastrar um novo fornecedor
        private void CadastrarFornecedor()
        {
            // Cria um novo objeto fornecedor e preenche os dados do formulário
            Fornecedor novoFornecedor = new Fornecedor
            {
                NomeFornecedor = tbx_nome.Text,
                Email = tbx_email.Text,
                CNPJ = tbx_CNPJ.Text,
                RazaoSocial = txb_RazaoSocial.Text,
                Endereco = txb_Endereco.Text,
                NumeroEndereco = int.TryParse(txb_Numero.Text, out var numero) ? numero : 0, // Converte o número
                Bairro = txb_Bairro.Text,
                Cidade = txb_Cidade.Text,
                Estado = txb_Estado.Text,
                CEP = txb_CEP.Text,
                InfAdicionais = txb_InfoAdicional.Text,
                Telefone1 = "" // Adicione os valores dos telefones se necessário
                               // Telefone2 = ...
            };

            // Tenta cadastrar no banco de dados
            if (novoFornecedor.CadastrarFornecedor())
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o fornecedor. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para salvar as informações do fornecedor
        private void SalvarFornecedor()
        {
            // Preencher o objeto fornecedor com os dados atualizados do formulário
            fornecedor.NomeFornecedor = tbx_nome.Text;
            fornecedor.Email = tbx_email.Text;
            fornecedor.CNPJ = tbx_CNPJ.Text;
            fornecedor.RazaoSocial = txb_RazaoSocial.Text;
            fornecedor.Endereco = txb_Endereco.Text;
            fornecedor.NumeroEndereco = int.TryParse(txb_Numero.Text, out var numero) ? numero : 0; // Converte o número
            fornecedor.Bairro = txb_Bairro.Text;
            fornecedor.Cidade = txb_Cidade.Text;
            fornecedor.Estado = txb_Estado.Text;
            fornecedor.CEP = txb_CEP.Text;
            fornecedor.InfAdicionais = txb_InfoAdicional.Text;

            // Tenta atualizar no banco de dados
            if (fornecedor.EditarFornecedor())
            {
                MessageBox.Show("Fornecedor atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o fornecedor. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            DesabilitarCampos();
            lbl_funcao.Text = "Visualizar Fornecedor";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
            VerUsuario();

        }

        private void CarregarInsumos(string pesquisa)
        {
            Insumo insumo = new Insumo();
            List<Insumo> listaInsumos = insumo.ListarInsumos(int.Parse(idFornecedor), pesquisa);

            dgw_Insumo.Rows.Clear();

            if (listaInsumos != null && listaInsumos.Count > 0)
            {
                lbl_Mensagem.Hide();

                foreach (var ins in listaInsumos)
                {
                    int rowIndex = dgw_Insumo.Rows.Add(
                        ins.IdInsumo,
                        ins.NomeInsumo,
                        ins.Validade,
                        ins.DataValidade.ToShortDateString()
                    );

                    DataGridViewButtonCell btn_verInsumo = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_Insumo.Rows[rowIndex].Cells["col_VerInsumo"] = btn_verInsumo;
                }
                foreach (DataGridViewRow row in dgw_Insumo.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerInsumo"];
                    btnCell.FlatStyle = FlatStyle.Flat;
                    btnCell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                    btnCell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                    btnCell.Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1D7874");
                    btnCell.Style.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                }
            }
            else
            {
                lbl_Mensagem.Show();
            }
        }


        private void btn_CadastrarInsumo_Click(object sender, EventArgs e)
        {

            CarregarInsumos(""); // Recarrega a lista de insumos após o cadastro
        }

        private void btn_RecarregarInsumo_Click(object sender, EventArgs e)
        {
            tbx_pequisarInsumo.Text = "";
            CarregarInsumos("");
        }

        private void tbx_pequisarInsumo_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisarInsumo.Text;
            CarregarInsumos(pesquisa);
        }

        private void dgw_Insumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgw_Insumo.Columns["col_VerInsumo"].Index && e.RowIndex >= 0)
            {
                string idInsumo = dgw_Insumo.Rows[e.RowIndex].Cells["col_IDInsumo"].Value.ToString();
                Form_VerInsumo verInsumo = new Form_VerInsumo(idInsumo);
                verInsumo.ShowDialog();
            }
        }
    }
}
