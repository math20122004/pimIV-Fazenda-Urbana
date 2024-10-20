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
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Location = new Point(0, 0);


            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                DesabilitarCampos();
                lbl_funcao.Text = "Visualizar Venda";
                VerVenda();
            }
            else
            {
                this.Height = 539;
                lbl_funcao.Text = "Cadastrar Venda";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                gb_status.Hide();
                label8.Hide();
            }

        }

        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            tbx_numero.Enabled = false;
            txb_InfoAdicional.Enabled = false;
            gb_status.Enabled = false;
            cbx_Cliente.Enabled = false;
            tbx_numero.Enabled = false;
            cbx_ItensCompra.Enabled = false;
            nud_Quantidade.Enabled = false;
            txb_valor.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tbx_ID.Enabled = true;
            tbx_numero.Enabled = true;
            txb_InfoAdicional.Enabled = true;
            gb_status.Enabled = true;
            cbx_Cliente.Enabled = true;
            tbx_numero.Enabled = true;
            cbx_ItensCompra.Enabled = true;
            nud_Quantidade.Enabled = true;
            txb_valor.Enabled = true;
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
                    EditarVenda();
                }
                else if (funcao == "cadastro")
                {
                    CadastrarVenda();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void CadastrarVenda()
        {

        }

        private void EditarVenda()
        {

        }

        private void VerVenda()
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            DesabilitarCampos();
            lbl_funcao.Text = "Visualizar Venda";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
            VerVenda();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {

        }

        private void gb_status_Enter(object sender, EventArgs e)
        {

        }
    }
}
