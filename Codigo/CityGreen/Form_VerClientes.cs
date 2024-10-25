using GestaoVendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerClientes : Form
    {
        private string funcao;
        private int IdVenda;
        private Cliente clienteAtual;

        public Form_VerClientes(int idVenda, string funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            this.IdVenda = idVenda;
            clienteAtual = new Cliente(); // Inicializa o objeto cliente
        }

        private void Form_VerClientes_Load(object sender, EventArgs e)
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
            tbx_CPF.Enabled = false;
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
            tbx_CPF.Enabled = true;
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
                if (funcao == "ver")
                {
                    EditarCliente(); // Chama o método para editar as informações do cliente
                }
                else if (funcao == "cadastro")
                {
                    CadastrarCliente(); // Chama o método para cadastrar um novo cliente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void CadastrarCliente()
        {
            // Preenche as propriedades do cliente com os dados do formulário
            clienteAtual.NomeCliente = tbx_nome.Text;
            clienteAtual.Telefone1 = tbx_fone1.Text;
            clienteAtual.Telefone2 = tbx_fone2.Text;
            clienteAtual.CPF = tbx_CPF.Text;
            clienteAtual.CNPJ = tbx_CNPJ.Text;
            clienteAtual.Email = tbx_email.Text;
            clienteAtual.Endereco = txb_Endereco.Text;
            clienteAtual.NumeroEndereco = int.Parse(txb_Numero.Text);
            clienteAtual.Bairro = txb_Bairro.Text;
            clienteAtual.Cidade = txb_Cidade.Text;
            clienteAtual.Estado = txb_Estado.Text;
            clienteAtual.CEP = txb_CEP.Text;
            clienteAtual.ClienteTipo = "Cliente"; // Você pode alterar isso conforme necessário
            clienteAtual.StatusCliente = gb_status.Enabled ? "Ativo" : "Inativo";

            if (clienteAtual.CadastrarCliente())
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                this.Close(); // Fecha o formulário após o cadastro
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cliente.");
            }
        }

        private void EditarCliente()
        {
            // Preenche as propriedades do cliente com os dados do formulário
            clienteAtual.IdCliente = IdVenda; // Defina a ID do cliente que está sendo editado
            clienteAtual.NomeCliente = tbx_nome.Text;
            clienteAtual.Telefone1 = tbx_fone1.Text;
            clienteAtual.Telefone2 = tbx_fone2.Text;
            clienteAtual.CPF = tbx_CPF.Text;
            clienteAtual.CNPJ = tbx_CNPJ.Text;
            clienteAtual.Email = tbx_email.Text;
            clienteAtual.Endereco = txb_Endereco.Text;
            clienteAtual.NumeroEndereco = int.Parse(txb_Numero.Text);
            clienteAtual.Bairro = txb_Bairro.Text;
            clienteAtual.Cidade = txb_Cidade.Text;
            clienteAtual.Estado = txb_Estado.Text;
            clienteAtual.CEP = txb_CEP.Text;
            clienteAtual.ClienteTipo = "Cliente"; // Ajuste conforme necessário

            if (rb_naoS.Checked == true)
            {
                clienteAtual.StatusCliente = "Inativo";

            }
            if (rb_simS.Checked == true)
            {
                clienteAtual.StatusCliente = "Ativo";
            }

            if (clienteAtual.EditarCliente())
            {
                MessageBox.Show("Cliente editado com sucesso!");
                this.Close(); // Fecha o formulário após a edição
            }
            else
            {
                MessageBox.Show("Erro ao editar o cliente.");
            }
        }

        private void VerCliente()
        {
            clienteAtual = clienteAtual.VerCliente(IdVenda); // Obtém as informações do cliente
            if (clienteAtual != null)
            {
                tbx_nome.Text = clienteAtual.NomeCliente;
                tbx_fone1.Text = clienteAtual.Telefone1;
                tbx_fone2.Text = clienteAtual.Telefone2;
                tbx_CPF.Text = clienteAtual.CPF;
                tbx_CNPJ.Text = clienteAtual.CNPJ;
                tbx_email.Text = clienteAtual.Email;
                txb_Endereco.Text = clienteAtual.Endereco;
                txb_Numero.Text = clienteAtual.NumeroEndereco.ToString();
                txb_Bairro.Text = clienteAtual.Bairro;
                txb_Cidade.Text = clienteAtual.Cidade;
                txb_Estado.Text = clienteAtual.Estado;
                txb_CEP.Text = clienteAtual.CEP;

                rb_simS.Checked = clienteAtual.StatusCliente == "Ativo";
                rb_naoS.Checked = clienteAtual.StatusCliente == "Inativo";
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            DesabilitarCampos();
            lbl_funcao.Text = "Visualizar Cliente"; // Corrigido para 'Cliente'
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
