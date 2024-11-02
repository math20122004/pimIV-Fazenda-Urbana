using System;
using System.Collections.Generic;
using System.Linq; // Para usar o método ToList()
using System.Windows.Forms;
using CityGreen.Classes;
using GestaoProducao;

namespace CityGreen
{
    public partial class Form_VerLote : Form
    {
        private string funcao;
        private int Id_Generico; // Manteremos para uso interno, mas agora será substituído pelo ID do lote
        private Lote lote;

        public Form_VerLote(string funcao, int idGenerico = 0) // O parâmetro permanece, mas não será usado para o cadastro
        {
            this.funcao = funcao;
            this.Id_Generico = idGenerico;

            InitializeComponent();
            lote = new Lote(); // Instância da classe Lote
        }

        private void Form_VerLote_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ListarProdutos();

            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                CarregarInformacoesLote();
                lbl_funcao.Text = "Visualizar Lote";
                DesabilitarCampos();
            }
            else
            {
                lbl_funcao.Text = "Cadastrar Lote";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                HabilitarCampos();
                lbl_status.Hide();
                lbl_valida.Hide();
                tbx_ID.Hide();
                lbl_ID.Hide();
            }
        }

        private void ListarProdutos()
        {
            try
            {
                var produtos = lote.ListarProdutos();

                cbx_produto.Items.Clear();

                foreach (var produto in produtos)
                {
                    string item = $"{produto.IdProduto} - {produto.NomeProduto}";
                    cbx_produto.Items.Add(new { Text = item, Value = produto.IdProduto });
                }

                cbx_produto.DisplayMember = "Text";
                cbx_produto.ValueMember = "Value";
                cbx_produto.DataSource = produtos.Select(p => new { Text = $"{p.IdProduto} - {p.NomeProduto}", Value = p.IdProduto }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos: " + ex.Message);
            }
        }

        private void CadastrarLote()
        {
            try
            {
                // Verifica se um produto foi selecionado
                if (cbx_produto.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um produto.");
                    return;
                }

                int idProduto = (int)cbx_produto.SelectedValue; // ID do produto selecionado
                int quantidade = (int)nud_Quantidade.Value;

                // Verifica se a quantidade é maior que zero
                if (quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser maior que zero.");
                    return;
                }

                // Captura a data validade
                DateTime dataValidade = date_validade.Value;

                // Formatando a data no formato 'yyyy-MM-dd'
                string dataValidadeFormatada = dataValidade.ToString("yyyy-MM-dd");

                // Exibindo a mensagem com os dados formatados
                MessageBox.Show($"Cadastrando Lote: Produto {idProduto}, Quantidade {quantidade}, Data de Validade {dataValidadeFormatada}");

                // Cadastrando o lote no banco de dados
                if (lote.CadastrarLote(idProduto, quantidade, Id_Generico, dataValidade)) // Passando 0 para idProducao, se não necessário
                {
                    MessageBox.Show("Lote cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar lote.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar lote: " + ex.Message);
            }
        }


        private void EditarLote()
        {
            try
            {
                int quantidade = (int)nud_Quantidade.Value;
                string status = "disponível";
                DateTime dataValidade = date_validade.Value;

                if (lote.EditarLote(Id_Generico, quantidade, status, dataValidade))
                {
                    MessageBox.Show("Lote editado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar lote: " + ex.Message);
            }
        }

        private void CarregarInformacoesLote()
        {
            if (Id_Generico > 0) // Certifique-se de que Id_Generico esteja correto
            {
                Lote loteInfo = lote.VerLote(Id_Generico);
                if (loteInfo != null)
                {
                    tbx_ID.Text = loteInfo.IdLote.ToString();
                    if (cbx_produto.DataSource != null)
                    {
                        cbx_produto.SelectedValue = loteInfo.IdProduto;
                    }
                    nud_Quantidade.Value = loteInfo.Quantidade;
                    date_validade.Value = loteInfo.DataValidade;
                    lbl_status.Text = loteInfo.Status;
                }
                else
                {
                    MessageBox.Show("Lote não encontrado.");
                }
            }
        }

        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            cbx_produto.Enabled = false;
            nud_Quantidade.Enabled = false;
            date_validade.Enabled = false;
        }

        private void HabilitarCampos()
        {
            cbx_produto.Enabled = true;
            nud_Quantidade.Enabled = true;
            date_validade.Enabled = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Lote";
            HabilitarCampos();
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "ver")
                {
                    EditarLote();
                }
                else
                {
                    CadastrarLote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarInformacoesLote();
            pl_editar.Show();
            lbl_funcao.Text = "Visualizar Lote";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
