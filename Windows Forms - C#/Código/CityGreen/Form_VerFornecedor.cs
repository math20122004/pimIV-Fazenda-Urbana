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
            InitializeComponent();
            this.idFornecedor = idFornecedor;
            this.funcao = funcao;
        }



        private void Form_VerFornecedor_Load(object sender, EventArgs e)
        {
            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                lab_funcao.Text = "Visualizar Fornecedor";
            }
            else 
            {
                lab_funcao.Text = "Cadastrar Fornecedor";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
            }
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Usuário";
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "cadastro")
                {

                }
                else if (funcao == "ver")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            lbl_funcao.Text = "Visualizar Fornecedor";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
        }
    }
}
