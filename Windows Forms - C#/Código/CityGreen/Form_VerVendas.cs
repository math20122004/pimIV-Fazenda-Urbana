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
    public partial class Form_VerVendas : Form
    {
        private string funcao;
        private int IdVenda;


        public Form_VerVendas(int idVenda, string funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            this.IdVenda = idVenda;

        }

        private void Form_VerVendas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                DesabilitarCampos();
                lbl_funcao.Text = "Visualizar Cliente";
                VerCliente();
            }
            else
            {
                this.Height = 539;
                lbl_funcao.Text = "Cadastrar Cliente";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                gb_status.Hide();
                label8.Hide();
            }

        }

        private void DesabilitarCampos()
        {
            tbx_CNPJ.Enabled = false;
            tbx_nome.Enabled = false;
            tbx_email.Enabled = false;
            txb_RazaoSocial.Enabled = false;
            txb_Endereco.Enabled = false;
            txb_Numero.Enabled = false;
            txb_Bairro.Enabled = false;
            txb_Cidade.Enabled = false;
            txb_Estado.Enabled = false;
            txb_CEP.Enabled = false;
            txb_InfoAdicional.Enabled = false;
            gb_status.Enabled = false;
            tbx_fone1.Enabled = false;
            tbx_fone2.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tbx_CNPJ.Enabled = true;
            tbx_nome.Enabled = true;
            tbx_email.Enabled = true;
            txb_RazaoSocial.Enabled = true;
            txb_Endereco.Enabled = true;
            txb_Numero.Enabled = true;
            txb_Bairro.Enabled = true;
            txb_Cidade.Enabled = true;
            txb_Estado.Enabled = true;
            txb_CEP.Enabled = true;
            txb_InfoAdicional.Enabled = true;
            gb_status.Enabled = true;
            tbx_fone1.Enabled = true;
            tbx_fone2.Enabled = true;
        }


        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Cliente";
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "visualizar")
                {
                    EditarCliente(); // Chama o método para salvar as informações do fornecedor
                }
                else if (funcao == "cadastro")
                {
                    CadastrarCliente(); // Chama o método para cadastrar um novo fornecedor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void CadastrarCliente()
        {

        }

        private void EditarCliente()
        {

        }

        private void VerCliente()
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            DesabilitarCampos();
            lbl_funcao.Text = "Visualizar Fornecedor";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
            VerCliente();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
