using Gestão_Fornecedores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerFornecedor : Form
    {
        private string cnpj; // Alterado de idFornecedor para cnpj
        private string funcao;
        private Fornecedor fornecedor;
        private Form_VerInsumo verInsumo;

        public Form_VerFornecedor(string cnpj, string funcao) // Alterado aqui
        {
            this.Location = new Point(0, 0);
            InitializeComponent();
            this.cnpj = cnpj; // Alterado de idFornecedor para cnpj
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
                VerFornecedor();
            }
            else
            {
                this.Height = 539;
                pn_Insumo.Hide();
                lbl_funcao.Text = "Cadastrar Fornecedor";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                gb_status.Hide();
                label8.Hide();
            }
        }

        private void VerFornecedor()
        {
            fornecedor = new Fornecedor().VerFornecedor(cnpj); // Alterado aqui

            if (fornecedor != null)
            {
                tbx_CNPJ.Text = fornecedor.CNPJ;
                tbx_nome.Text = fornecedor.NomeFornecedor;
                tbx_email.Text = fornecedor.Email;
                txb_RazaoSocial.Text = fornecedor.RazaoSocial;
                txb_Endereco.Text = fornecedor.Endereco;
                tbx_fone2.Text = fornecedor.Telefone2;
                tbx_fone1.Text = fornecedor.Telefone1;
                txb_Numero.Text = fornecedor.NumeroEndereco.ToString();
                txb_Bairro.Text = fornecedor.Bairro;
                txb_Cidade.Text = fornecedor.Cidade;
                txb_Estado.Text = fornecedor.Estado;
                txb_CEP.Text = fornecedor.CEP;
                txb_InfoAdicional.Text = fornecedor.InfAdicionais;

                rb_simS.Checked = fornecedor.StatusFornecedor == "ativo";
                rb_naoS.Checked = fornecedor.StatusFornecedor == "inativo";
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado.");
                this.Close();
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

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Fornecedor";
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
                Telefone2 = tbx_fone2.Text,
                Telefone1 = tbx_fone1.Text,
                Endereco = txb_Endereco.Text,
                NumeroEndereco = int.TryParse(txb_Numero.Text, out var numero) ? numero : 0, // Converte o número
                Bairro = txb_Bairro.Text,
                Cidade = txb_Cidade.Text,
                Estado = txb_Estado.Text,
                CEP = txb_CEP.Text,
                InfAdicionais = txb_InfoAdicional.Text,
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
            fornecedor.Telefone2 = tbx_fone2.Text;
            fornecedor.Telefone1 = tbx_fone1.Text;
            fornecedor.NumeroEndereco = int.TryParse(txb_Numero.Text, out var numero) ? numero : 0;
            fornecedor.Bairro = txb_Bairro.Text;
            fornecedor.Cidade = txb_Cidade.Text;
            fornecedor.Estado = txb_Estado.Text;
            fornecedor.CEP = txb_CEP.Text;
            fornecedor.InfAdicionais = txb_InfoAdicional.Text;

            if(rb_naoS.Checked == true)
            {
                fornecedor.StatusFornecedor = "inativo";

            }
            if (rb_simS.Checked == true)
            {
                fornecedor.StatusFornecedor = "ativo";
            }

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
            VerFornecedor();
        }

        private void CarregarInsumos(string pesquisa)
        {
            try
            {
                Insumo insumo = new Insumo();

                // Altere aqui o método para incluir o cnpj no parâmetro
                List<Insumo> listaInsumos = insumo.ListarInsumos(cnpj, pesquisa);

                // Limpa as linhas existentes no DataGridView antes de adicionar novas
                dgw_Insumo.Rows.Clear();

                // Verifica se a lista de insumos não é nula e possui itens
                if (listaInsumos != null && listaInsumos.Count > 0)
                {
                    lbl_Mensagem.Hide(); // Esconde o label de mensagem, caso haja insumos a exibir

                    // Adiciona cada insumo da lista ao DataGridView
                    foreach (var ins in listaInsumos)
                    {
                        // Adiciona uma nova linha ao DataGridView com os dados do insumo
                        int rowIndex = dgw_Insumo.Rows.Add(
                            ins.IdInsumo,
                            ins.NomeInsumo,
                            ins.Validade,
                            ins.DataValidade.ToShortDateString() // Exibe a data de validade formatada
                        );

                        // Cria um botão de visualização para cada insumo
                        DataGridViewButtonCell btn_verInsumo = new DataGridViewButtonCell
                        {
                            Value = "Visualizar" // Define o texto do botão
                        };

                        // Adiciona o botão na coluna específica da linha recém-adicionada
                        dgw_Insumo.Rows[rowIndex].Cells["col_VerInsumo"] = btn_verInsumo;
                    }

                    // Estiliza os botões de visualização
                    foreach (DataGridViewRow row in dgw_Insumo.Rows)
                    {
                        DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerInsumo"];
                        btnCell.FlatStyle = FlatStyle.Flat; // Define o estilo do botão como flat
                        btnCell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff"); // Cor de fundo branca
                        btnCell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22"); // Cor da fonte
                        btnCell.Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1D7874"); // Cor de fundo ao selecionar
                        btnCell.Style.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22"); // Cor da fonte ao selecionar
                    }
                }
                else
                {
                    lbl_Mensagem.Show(); // Exibe uma mensagem caso não haja insumos
                }
            }
            catch (Exception ex)
            {
                // Trate o erro exibindo uma mensagem ao usuário
                Console.WriteLine($"Erro ao carregar insumos: {ex.Message}");
                lbl_Mensagem.Text = "Ocorreu um erro ao carregar os insumos."; // Define a mensagem de erro no label
                lbl_Mensagem.Show(); // Exibe o label com a mensagem de erro
            }
        }


        private void AbrirFormVerInsumo(int idInsumo, string funcao)
        {
            if (verInsumo == null || verInsumo.IsDisposed)
            {
                verInsumo = new Form_VerInsumo(funcao, idInsumo, cnpj) // Alterado aqui
                {
                    MdiParent = this.MdiParent
                };

                verInsumo.ControlBox = false;
                verInsumo.FormBorderStyle = FormBorderStyle.FixedDialog;
                verInsumo.FormClosed += VerInsumo_FormClosed;
                verInsumo.Show();
            }
            else
            {
                verInsumo.Activate();
            }
        }

        private void VerInsumo_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verInsumo = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_fornecedores.PerformClick();
            }

            this.Activate();
        }

        private void btn_CadastrarInsumo_Click(object sender, EventArgs e)
        {
            AbrirFormVerInsumo(0, "cadastrar");
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
                int idInsumo = Convert.ToInt32(dgw_Insumo.Rows[e.RowIndex].Cells["col_IDInsumo"].Value);
                AbrirFormVerInsumo(idInsumo, "visualizar");
            }
        }
    }
}
