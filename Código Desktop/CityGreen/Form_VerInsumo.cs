﻿using Gestão_Fornecedores;
using System;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerInsumo : Form
    {
        private string funcao;
        private int Id_Insumo;
        private string CNPJ; // Alterado de Id_Fornecedor para CNPJ

        public Form_VerInsumo(string funcao, int idInsumo = 0, string cnpj = "") // Alterado para usar CNPJ
        {
            InitializeComponent();
            this.funcao = funcao;
            this.Id_Insumo = idInsumo;
            this.CNPJ = cnpj; // Inicializa CNPJ

        }

        private void Form_VerInsumo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (funcao == "visualizar")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                CarregarInformacoesInsumo();
                lbl_funcao.Text = "Visualizar Insumo";
                DesabilitarCampos();
            }
            else
            {
                lbl_funcao.Text = "Cadastrar Insumo";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                HabilitarCampos();
                lbl_validade2.Hide();
                lbl_valida.Hide();
            }
        }

        private void CarregarInformacoesInsumo()
        {
            try
            {
                Insumo insumo = new Insumo().VerInsumo(Id_Insumo);

                if (insumo != null)
                {
                    tbx_ID.Text = insumo.IdInsumo.ToString();
                    tbx_nome.Text = insumo.NomeInsumo;
                    nud_Quantidade.Value = insumo.QuantidadeInsumo;
                    date_validade.Value = insumo.DataValidade; // Usando o DateTimePicker
                    lbl_validade2.Text = insumo.Validade;

                    // Carregamento do nome do fornecedor pelo CNPJ, se necessário
                    // lbl_nomeFornecedor.Text = ...; 
                }
                else
                {
                    MessageBox.Show("Erro ao carregar as informações do insumo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o insumo: " + ex.Message);
            }
        }

        private void EditarInsumo()
        {
            Insumo insumo = new Insumo
            {
                IdInsumo = Id_Insumo,
                NomeInsumo = tbx_nome.Text,
                QuantidadeInsumo = (int)nud_Quantidade.Value,
                DataValidade = date_validade.Value.Date, // Captura a data do DateTimePicker
                Validade = lbl_validade2.Text,
                CNPJ = CNPJ // Usar CNPJ para edição
            };

            if (insumo.EditarInsumo())
            {
                MessageBox.Show("Insumo editado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao editar o insumo.");
            }
        }

        private void CadastrarInsumo()
        {
            try
            {
                // Verificação do campo de ID
                if (string.IsNullOrWhiteSpace(tbx_ID.Text))
                {
                    MessageBox.Show("O ID do insumo é obrigatório.");
                    return;
                }

                // Verifica se o ID é um número válido
                if (!int.TryParse(tbx_ID.Text, out int insumoID))
                {
                    MessageBox.Show("O ID do insumo deve ser um número válido.");
                    return;
                }

                // Validações básicas dos outros campos
                if (string.IsNullOrWhiteSpace(tbx_nome.Text))
                {
                    MessageBox.Show("O nome do insumo é obrigatório.");
                    return;
                }

                if (nud_Quantidade.Value <= 0)
                {
                    MessageBox.Show("A quantidade do insumo deve ser maior que zero.");
                    return;
                }

                // Criando uma nova instância da classe Insumo com os valores do formulário
                Insumo novoInsumo = new Insumo
                {
                    IdInsumo = insumoID, // ID do insumo validado
                    NomeInsumo = tbx_nome.Text.Trim(), // Nome do insumo
                    QuantidadeInsumo = (int)nud_Quantidade.Value, // Quantidade do insumo
                    DataValidade = date_validade.Value.Date, // Data de validade do insumo
                    CNPJ = CNPJ // Usando o CNPJ da variável global
                };

                // Tentativa de cadastro usando o método CadastrarInsumo da classe Insumo
                if (novoInsumo.CadastrarInsumo())
                {
                    MessageBox.Show("Insumo cadastrado com sucesso!");
                    this.Close(); // Fecha o formulário após o sucesso
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o insumo. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erros inesperados
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            tbx_nome.Enabled = false;
            nud_Quantidade.Enabled = false;
            date_validade.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tbx_nome.Enabled = true;
            nud_Quantidade.Enabled = true;
            date_validade.Enabled = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "cadastrar")
                {
                    CadastrarInsumo();
                }
                else if (funcao == "visualizar")
                {
                    EditarInsumo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Insumo";
            HabilitarCampos();
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarInformacoesInsumo();
            pl_editar.Show();
            lbl_funcao.Text = "Visualizar Insumo";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
