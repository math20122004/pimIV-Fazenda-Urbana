using GestaoProducao;
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
using GestaoVendas;
using static GestaoVendas.ItensVenda;

namespace CityGreen
{
    public partial class Form_VerProducao : Form
    {
        private string funcao;
        private int Id_Producao;
        private Producao producaoAtual;
        private Form_VerLote formVerLotes;
        private List<Insumo> insumosDisponiveis = new List<Insumo>();
        private List<Insumo> insumosUsados = new List<Insumo>();
        private List<Insumo> insumosBanco = new List<Insumo>();

        public Form_VerProducao(string funcao, int idProducao = 0)
        {
            this.funcao = funcao;
            this.Id_Producao = idProducao;


            InitializeComponent();
        }

        private void Form_VerProducao_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Location = new Point(0, 0);

            CarregarInsumos();

            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                DesabilitarCampos();
                lbl_funcao.Text = "Visualizar Produção";
                CarregarProducao();
                CarregarInsumosUtilizados();
                CarregarLotes();
            }
            else
            {
                lb_ID.Hide();
                tbx_ID.Hide();
                pn_Insumo.Hide();
                lbl_funcao.Text = "Cadastrar Produção";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                gb_status.Hide();
                label8.Hide();
            }
        }

        private void HabilitarCampos()
        {
            date_Fim.Enabled = true;
            gb_status.Enabled = true;
            cbx_Insumo.Enabled = true;
            nud_Quantidade.Enabled = true;
            btn_Adicionar.Enabled = true;
            btn_Adicionar.Visible = true;
            dgw_Insumo2.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            tbx_produto.Enabled = false;
            date_inicio.Enabled = false;
            date_Fim.Enabled = false;
            gb_status.Enabled = false;
            cbx_Insumo.Enabled = false;
            nud_Quantidade.Enabled = false;
            btn_Adicionar.Enabled = false;
            dgw_Insumo2.Enabled = false;
            btn_Adicionar.Visible = false;
        }

        private void CarregarProducao(string pesquisa = "")
        {
            producaoAtual = ObterProducao(this.Id_Producao, pesquisa); // Usa a variável global e o parâmetro de pesquisa.

            if (producaoAtual != null)
            {
                // Preenche os campos com os dados da produção
                tbx_ID.Text = producaoAtual.IdPlantio.ToString();
                tbx_produto.Text = producaoAtual.Produto;
                date_inicio.Value = producaoAtual.DataInicio;
                date_Fim.Value = producaoAtual.DataFim ?? DateTime.Now; // Define a data atual se DataFim for nula.

                // Define o status da produção e seleciona o RadioButton correspondente
                switch (producaoAtual.StatusProducao)
                {
                    case "Ativa":
                        rb_ativa.Checked = true;
                        break;
                    case "Cancelada":
                        rb_Cancelado.Checked = true;
                        break;
                    case "Completa":
                        rb_Completa.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Status desconhecido da produção.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Produção não encontrada.");
            }
        }

        // Método para buscar a produção no banco com o ID e opcionalmente por um termo de pesquisa
        private Producao ObterProducao(int idPlantio, string pesquisa = "")
        {
            Producao producao = new Producao();
            var producoes = producao.ListarProducoes(pesquisa); // Passa o termo de pesquisa para a listagem.

            return producoes.Find(p => p.IdPlantio == idPlantio);
        }


        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Producao";
            pl_cancelar.Show();
            pl_confirmar.Show();

        }

        private void AbrirFormVerLotes(string funcao, int idProducao = 0)
        {
            int ID = idProducao;

            if(ID == 0)
            {
                ID = Id_Producao;
            }
            
            formVerLotes = new Form_VerLote(funcao, ID) // Assume que Form_VerLotes tem um construtor semelhante
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            formVerLotes.FormClosed += (s, e) => this.Activate(); // Reativa o formulário pai quando este é fechado
            formVerLotes.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pl_editar.Show();
            DesabilitarCampos();
            lbl_funcao.Text = "Visualizar Produção";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
            CarregarProducao();
            CarregarInsumosUtilizados();
            CarregarLotes();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "ver")
                {
                    EditarProducao();
                }
                else if (funcao == "cadastro")
                {
                    CadastrarProducao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void CarregarInsumosUtilizados()
        {
            // Carrega os insumos do banco e os armazena nas listas locais.
            var insumos = new Producao().ListarInsumosProducao(Id_Producao);

            // Verifica se a lista de insumos retornou nula ou vazia
            if (insumos == null || !insumos.Any())
            {
                return; // Sai do método se não houver insumos
            }

            // Copia a lista do banco para insumosBanco e insumosUsados
            insumosBanco = new List<Insumo>(insumos);
            insumosUsados = new List<Insumo>(insumos);

            // Chama o método para carregar a lista de insumos utilizados na interface
            CarregarListaInsumos();
        }


        private void CarregarListaInsumos()
        {
            dgw_Insumo2.Rows.Clear();
            lblMensagem1.Hide();

            foreach (var insumo in insumosUsados)
            {
                // Adicione uma mensagem para verificar os insumos que estão sendo carregados
                Console.WriteLine($"Adicionando insumo: {insumo.NomeInsumo}");

                int rowIndex = dgw_Insumo2.Rows.Add();
                DataGridViewRow row = dgw_Insumo2.Rows[rowIndex];

                row.Cells["col_IDInsumo"].Value = insumo.IdInsumo;
                row.Cells["col_NomeInsumo"].Value = insumo.NomeInsumo;
                row.Cells["col_Quantidade"].Value = insumo.QuantidadeInsumo;

                var btn_Retirar = new DataGridViewButtonCell { Value = "Retirar" };
                row.Cells["col_Retirar"] = btn_Retirar;
            }

            foreach (DataGridViewRow row in dgw_Insumo2.Rows)
            {
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_Retirar"];
                btnCell.FlatStyle = FlatStyle.Flat;
                btnCell.Style.BackColor = ColorTranslator.FromHtml("#EE2E31");
                btnCell.Style.ForeColor = Color.White;
                btnCell.Style.SelectionBackColor = ColorTranslator.FromHtml("#B22222");
                btnCell.Style.SelectionForeColor = Color.White;
            }

            lblMensagem1.Visible = insumosUsados.Count == 0;

        }

        private void cbx_Insumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Insumo.SelectedItem != null)
            {
                var selectedText = cbx_Insumo.SelectedItem.ToString();
                var selectedId = int.Parse(selectedText.Split('-')[0].Trim()); // Obtém o ID do insumo

                var insumoSelecionado = insumosDisponiveis.FirstOrDefault(i => i.IdInsumo == selectedId);
                if (insumoSelecionado != null)
                {
                    nud_Quantidade.Maximum = insumoSelecionado.QuantidadeInsumo;
                    nud_Quantidade.Value = 1;
                }
            }
        }


        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (cbx_Insumo.SelectedItem != null)
            {
                // Obtém o texto selecionado e extrai o ID
                var selectedText = cbx_Insumo.SelectedItem.ToString();
                var selectedId = int.Parse(selectedText.Split('-')[0].Trim()); // Obtém o ID do insumo

                var insumoSelecionado = insumosDisponiveis.FirstOrDefault(i => i.IdInsumo == selectedId);

                if (insumoSelecionado != null)
                {
                    int quantidade = (int)nud_Quantidade.Value;

                    Insumo novoInsumo = new Insumo
                    {
                        IdInsumo = insumoSelecionado.IdInsumo,
                        NomeInsumo = insumoSelecionado.NomeInsumo,
                        QuantidadeInsumo = quantidade
                    };

                    insumosUsados.Add(novoInsumo);

                    CarregarListaInsumos();

                    nud_Quantidade.Value = 1;
                    cbx_Insumo.SelectedItem = null; // Limpa a seleção do ComboBox
                }
                else
                {
                    MessageBox.Show("Insumo selecionado não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um insumo.");
            }
        }


        private void dgw_Insumo2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_Insumo2.Columns[e.ColumnIndex].Name == "col_Retirar" && e.RowIndex >= 0)
            {
                int idInsumo = (int)dgw_Insumo2.Rows[e.RowIndex].Cells["col_IDInsumo"].Value;
                RetirarInsumo(idInsumo);
            }
        }

        private void dgw_Lote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é a do botão "Ver Lote"
            if (dgw_Lote.Columns[e.ColumnIndex].Name == "col_VerLote" && e.RowIndex >= 0)
            {
                // Obtém o ID do lote da linha clicada
                int idLote = (int)dgw_Lote.Rows[e.RowIndex].Cells["col_IDLote"].Value;

                // Abre o formulário de visualização do lote
                AbrirFormVerLotes("ver", idLote);
            }
        }

        private void RetirarInsumo(int idInsumo)
        {
            var insumoParaRemover = insumosUsados.FirstOrDefault(i => i.IdInsumo == idInsumo);
            if (insumoParaRemover != null)
            {
                insumosUsados.Remove(insumoParaRemover);
                CarregarListaInsumos();
            }
        }

        private void CadastrarProducao()
        {
            var novaProducao = new Producao();
            DateTime dataInicio = date_inicio.Value;
            DateTime? dataFim = date_Fim.Checked ? date_Fim.Value : (DateTime?)null;
            string produto = tbx_produto.Text;

            // Cadastra a produção e obtém o ID gerado para associar os insumos
            bool sucesso = novaProducao.CadastrarProducao(dataInicio, produto, dataFim);

            if (sucesso)
            {
                // Adicionar os insumos utilizados após cadastrar a produção
                foreach (var insumo in insumosUsados) // Lista de insumos selecionados no formulário
                {
                    novaProducao.CadastrarInsumosProducao(novaProducao.IdPlantio, insumo.IdInsumo, insumo.QuantidadeInsumo);
                }

                MessageBox.Show("Produção e insumos cadastrados com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProducao()
        {
            var producao = new Producao();
            int idPlantio = int.Parse(tbx_ID.Text);
            DateTime? dataFim = date_Fim.Checked ? date_Fim.Value : (DateTime?)null;

            string statusProducao = rb_ativa.Checked ? "Ativa" :
                                    rb_Cancelado.Checked ? "Cancelada" : "Completa";

            bool sucesso = producao.EditarProducao(idPlantio, dataFim, statusProducao);

            if (sucesso)
            {
                EditarInsumosProducao(); // Atualiza os insumos da produção

                MessageBox.Show("Produção atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar produção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditarInsumosProducao()
        {
            var producao = new Producao();
            int idPlantio = int.Parse(tbx_ID.Text);

            // Remover insumos que estão em insumosBanco, mas não em insumosUsados
            foreach (var insumoBanco in insumosBanco)
            {
                if (!insumosUsados.Any(i => i.IdInsumo == insumoBanco.IdInsumo))
                {
                    producao.RemoverInsumosProducao(idPlantio, insumoBanco.IdInsumo);
                }
            }

            // Adicionar insumos que estão em insumosUsados
            foreach (var insumoUsado in insumosUsados)
            {
                // Verifica se o insumo já existe no banco para evitar duplicações
                if (!insumosBanco.Any(i => i.IdInsumo == insumoUsado.IdInsumo))
                {
                    producao.CadastrarInsumosProducao(idPlantio, insumoUsado.IdInsumo, insumoUsado.QuantidadeInsumo);
                }
            }

            MessageBox.Show("Insumos atualizados com sucesso!", "Atualização de Insumos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CadastrarInsumosProducao(int idPlantio)
        {
            var producao = new Producao();
            foreach (var insumo in insumosUsados) // Insumos selecionados no formulário
            {
                producao.CadastrarInsumosProducao(idPlantio, insumo.IdInsumo, insumo.QuantidadeInsumo);
            }

            MessageBox.Show("Insumos cadastrados com sucesso!", "Cadastro de Insumos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void CarregarInsumos()
        {
            cbx_Insumo.Items.Clear();
            insumosDisponiveis.Clear();

            // Obtém a lista de insumos do banco
            var insumos = new Insumo().ListarInsumos();

            foreach (var insumo in insumos)
            {
                insumosDisponiveis.Add(new Insumo
                {
                    IdInsumo = insumo.IdInsumo,
                    NomeInsumo = insumo.NomeInsumo,
                    QuantidadeInsumo = insumo.QuantidadeInsumo,
                });

                // Adiciona o insumo no ComboBox
                cbx_Insumo.Items.Add($"{insumo.IdInsumo} - {insumo.NomeInsumo}");
            }
        }

        private void CarregarLotes(string pesquisa = null)
        {
            dgw_Lote.Rows.Clear(); // Limpa as linhas existentes na DataGridView
            List<GestaoProducao.Lote> lotes; // Especificando o namespace para a lista de lotes

            try
            {
                // Cria uma instância da classe Lote e obtém os lotes disponíveis
                GestaoProducao.Lote lote = new GestaoProducao.Lote(); // Especificando o namespace
                lotes = lote.ListarLotesDisponiveis();

                // Filtra os lotes se houver uma pesquisa
                if (!string.IsNullOrWhiteSpace(pesquisa))
                {
                    lotes = lotes.Where(l => l.IdLote.ToString().Contains(pesquisa) ||
                                              l.IdProduto.ToString().Contains(pesquisa) ||
                                              l.Quantidade.ToString().Contains(pesquisa) ||
                                              l.DataValidade.ToString().Contains(pesquisa)).ToList();
                }

                // Verifica se há registros e atualiza a visibilidade do lb_Mensagem2
                if (lotes.Count > 0)
                {
                    lbl_Mensagem2.Visible = false; // Oculta a mensagem se houver registros
                }
                else
                {
                    lbl_Mensagem2.Visible = true; // Mostra a mensagem se não houver registros
                    lbl_Mensagem2.Text = "Nenhum lote encontrado."; // Mensagem padrão
                }

                foreach (var item in lotes)
                {
                    int rowIndex = dgw_Lote.Rows.Add();
                    DataGridViewRow row = dgw_Lote.Rows[rowIndex];

                    // Preenchendo as células da DataGridView
                    row.Cells["col_IDLote"].Value = item.IdLote;
                    row.Cells["col_Produto"].Value = item.IdProduto; // Assumindo que você tem um método para buscar o nome do produto usando o IdProduto
                    row.Cells["col_QuantidadeLote"].Value = item.Quantidade;
                    row.Cells["col_data"].Value = item.DataValidade.ToShortDateString(); // Formata a data de validade

                    // Criando um botão "Ver Lote"
                    var btn_VerLote = new DataGridViewButtonCell { Value = "Ver Lote" };
                    row.Cells["col_VerLote"] = btn_VerLote;
                }

                // Estilizando os botões
                foreach (DataGridViewRow row in dgw_Lote.Rows)
                {

                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerLote"];
                    btnCell.FlatStyle = FlatStyle.Flat; // Define o estilo do botão como flat
                    btnCell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff"); // Cor de fundo branca
                    btnCell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22"); // Cor da fonte
                    btnCell.Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1D7874"); // Cor de fundo ao selecionar
                    btnCell.Style.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22"); //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lotes: " + ex.Message);
            }
        }


        private void tbx_pequisarLotes_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisarLotes.Text;
            CarregarLotes(pesquisa);
        }

        private void btn_RecarregarLotes_Click(object sender, EventArgs e)
        {
            CarregarLotes("");
            tbx_pequisarLotes.Text = "";
        }


        private void btn_CadastrarLote_Click(object sender, EventArgs e)
        {
            // Exibe o valor de Id_Producao no Console para verificar se está correto
            MessageBox.Show("Id_Producao: " + Id_Producao);

            // Passa o ID da produção para o método AbrirFormVerLotes
            AbrirFormVerLotes("cadastro", Id_Producao);
        }

    }
}
