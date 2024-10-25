using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GestaoVendas;
using static GestaoVendas.ItensVenda;

namespace CityGreen
{
    public partial class Form_VerVendas : Form
    {
        private string funcao;
        private int IdVenda;
        private Vendas vendaAtual;
        private List<ItensVenda> itensVenda;
        private List<ItensVenda> itensBanco;
        private List<Cliente> clientes = new List<Cliente>();

        public Form_VerVendas(int idVenda, string funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            this.IdVenda = idVenda;
            vendaAtual = new Vendas();
            itensVenda = new List<ItensVenda>();
            itensBanco = new List<ItensVenda>(); // Inicializa a lista itensBanco
        }

        private void Form_VerVendas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Location = new Point(0, 0);

            CarregarClientes();
            CarregarLotes();

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
            tbx_numero.Enabled = false;
            txb_InfoAdicional.Enabled = false;
            gb_status.Enabled = false;
            cbx_Cliente.Enabled = false;
            cbx_ItensCompra.Enabled = false;
            nud_Quantidade.Enabled = false;
            txb_valor.Enabled = false;
            dgw_Item.Enabled = false;
            btn_Adicionar.Visible = false;
        }

        private void HabilitarCampos()
        {
            tbx_numero.Enabled = true;
            txb_InfoAdicional.Enabled = true;
            gb_status.Enabled = true;
            cbx_Cliente.Enabled = true;
            cbx_ItensCompra.Enabled = true;
            nud_Quantidade.Enabled = true;
            txb_valor.Enabled = true;
            dgw_Item.Enabled = true;
            btn_Adicionar.Visible = true;
        }

        private void CarregarClientes()
        {
            cbx_Cliente.Items.Clear();
            clientes.Clear(); // Limpa a lista de clientes antes de carregar novos

            // Carrega os clientes e armazena na lista
            var clientesDoBanco = new Cliente().ListarClientes();
            foreach (var cliente in clientesDoBanco)
            {
                clientes.Add(cliente); // Adiciona o cliente à lista
                cbx_Cliente.Items.Add(cliente.IdCliente + " - " + cliente.NomeCliente);
            }
        }

        private List<Lote> lotesDisponiveis = new List<Lote>();

        private void CarregarLotes()
        {
            cbx_ItensCompra.Items.Clear();
            lotesDisponiveis.Clear();

            var lotes = new ItensVenda().ListarLotes();

            foreach (var lote in lotes)
            {
                lotesDisponiveis.Add(new Lote
                {
                    IdLote = lote.IdLote,
                    NomeProduto = lote.NomeProduto,
                    Quantidade = lote.Quantidade
                });

                cbx_ItensCompra.Items.Add(lote);
            }
        }

        private void VerVenda()
        {
            vendaAtual = vendaAtual.VerVenda(IdVenda);

            if (vendaAtual != null)
            {
                tbx_numero.Text = vendaAtual.NumeroVenda;
                txb_InfoAdicional.Text = vendaAtual.InfoAdicionais;
                cbx_Cliente.SelectedItem = vendaAtual.IdCliente + " - " + new Cliente().VerCliente(vendaAtual.IdCliente).NomeCliente;

                switch (vendaAtual.StatusVenda)
                {
                    case "Em andamento":
                        rb_Andamento.Checked = true;
                        break;
                    case "Entregue":
                        rb_Entregue.Checked = true;
                        break;
                    case "Cancelado":
                        rb_Cancelado.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Status desconhecido da venda.");
                        break;
                }

                // Carrega os itens da venda e armazena em itensBanco
                CarregarItensVenda(IdVenda);
            }
            else
            {
                MessageBox.Show("Venda não encontrada.");
            }
        }

        private void CarregarItensVenda(int idVenda)
        {
            itensVenda.Clear(); // Limpa a lista local de itens da venda
            itensBanco.Clear(); // Limpa a lista de itens do banco para a comparação

            // Faz a consulta ao banco de dados e adiciona itens à lista de itensBanco
            ItensVenda itemVendaObj = new ItensVenda();
            itensBanco = itemVendaObj.ListarItensVenda(idVenda);

            // Adiciona os itens do banco na lista local
            foreach (var item in itensBanco)
            {
                itensVenda.Add(item);
            }

            // Chama a função para exibir os itens na DataGridView
            CarregarItens();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Venda";
            pl_cancelar.Show();
            pl_confirmar.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "ver")
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
            try
            {
                // Validações antes de tentar cadastrar
                if (string.IsNullOrWhiteSpace(tbx_numero.Text))
                {
                    MessageBox.Show("Por favor, insira o número da venda.");
                    return;
                }

                if (cbx_Cliente.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um cliente.");
                    return;
                }

                if (itensVenda.Count == 0)
                {
                    MessageBox.Show("Adicione ao menos um item à venda.");
                    return;
                }

                string numero = tbx_numero.Text;
                int idCliente = clientes[cbx_Cliente.SelectedIndex].IdCliente;
                string infoAdicional = txb_InfoAdicional.Text;

                // Cadastra a venda e captura o ID gerado
                int idVendaGerado = vendaAtual.CadastrarVenda(numero, idCliente, infoAdicional);
                if (idVendaGerado > 0)
                {
                    // Agora, para cada item na lista de itensVenda, cadastrar no banco
                    foreach (var item in itensVenda)
                    {
                        // Cadastrar o item da venda
                        bool itemCadastrado = item.CadastrarItemVenda(idVendaGerado, item.IdLote, item.Quantidade, item.ValorUnitario);
                        if (!itemCadastrado)
                        {
                            MessageBox.Show($"Erro ao cadastrar o item: {item.NomeProduto}");
                        }
                    }

                    MessageBox.Show("Venda cadastrada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a venda. Verifique os dados e tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a venda: " + ex.Message);
            }
        }



        private void EditarVenda()
        {
            // Atualiza as propriedades da venda atual
            vendaAtual.NumeroVenda = tbx_numero.Text;
            vendaAtual.InfoAdicionais = txb_InfoAdicional.Text;

            // Obtém os novos valores do cliente
            int novoIdCliente = clientes[cbx_Cliente.SelectedIndex].IdCliente;

            // Inicializa a variável para o novo status da venda
            string novoStatusVenda = string.Empty;

            // Define o novo status da venda com base no RadioButton selecionado
            if (rb_Andamento.Checked)
            {
                novoStatusVenda = "Em andamento";
            }
            else if (rb_Entregue.Checked)
            {
                novoStatusVenda = "Entregue";
            }
            else if (rb_Cancelado.Checked)
            {
                novoStatusVenda = "Cancelado";
            }

            // Chama o método EditarVenda com os novos parâmetros
            if (vendaAtual.EditarVenda(IdVenda, novoIdCliente, novoStatusVenda))
            {
                // Remove itens que estão apenas no banco e não na lista de edição local
                foreach (var itemBanco in itensBanco)
                {
                    if (!itensVenda.Any(item => item.IdLote == itemBanco.IdLote))
                    {
                        itemBanco.RemoverItem(itemBanco.IdLote); // Aqui pode estar o problema
                    }
                }

                // Adiciona novos itens que estão apenas na lista local e não no banco
                foreach (var item in itensVenda)
                {
                    if (!itensBanco.Any(itemBanco => itemBanco.IdLote == item.IdLote))
                    {
                        item.IdVenda = IdVenda; // Certifique-se de que item.IdVenda está sendo definido
                                                // Chame o método com todos os parâmetros necessários
                        item.CadastrarItemVenda(IdVenda, item.IdLote, item.Quantidade, (double)item.ValorUnitario);
                    }
                }

                MessageBox.Show("Venda editada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao editar a venda.");
            }
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

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (cbx_ItensCompra.SelectedItem is Lote loteSelecionado)
            {
                int quantidade = (int)nud_Quantidade.Value;
                decimal valor = decimal.Parse(txb_valor.Text);

                ItensVenda novoItem = new ItensVenda
                {
                    IdLote = loteSelecionado.IdLote,
                    NomeProduto = loteSelecionado.NomeProduto,
                    Quantidade = quantidade,
                    ValorUnitario = (double)valor // Converte decimal para double aqui
                };

                itensVenda.Add(novoItem);

                CarregarItens();

                nud_Quantidade.Value = 0;
                txb_valor.Text = string.Empty;
                cbx_ItensCompra.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um lote.");
            }
        }

        private void CarregarItens()
        {
            dgw_Item.Rows.Clear();

            foreach (var item in itensVenda)
            {
                int rowIndex = dgw_Item.Rows.Add();
                DataGridViewRow row = dgw_Item.Rows[rowIndex];

                row.Cells["col_IDLote"].Value = item.IdLote;
                row.Cells["col_NomeProduto"].Value = item.NomeProduto;
                row.Cells["col_Quantidade"].Value = item.Quantidade;
                row.Cells["col_Valor"].Value = item.ValorUnitario;

                DataGridViewButtonCell btn_Retirar = new DataGridViewButtonCell
                {
                    Value = "Retirar"
                };
                row.Cells["col_Retirar"] = btn_Retirar;
            }

            foreach (DataGridViewRow row in dgw_Item.Rows)
            {
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_Retirar"];
                btnCell.FlatStyle = FlatStyle.Flat;
                btnCell.Style.BackColor = ColorTranslator.FromHtml("#EE2E31");
                btnCell.Style.ForeColor = Color.White;
                btnCell.Style.SelectionBackColor = ColorTranslator.FromHtml("#B22222");
                btnCell.Style.SelectionForeColor = Color.White;
            }

            lblMensagem.Visible = itensVenda.Count == 0;
        }

        private void dgw_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_Item.Columns[e.ColumnIndex].Name == "col_Retirar" && e.RowIndex >= 0)
            {
                int idLote = (int)dgw_Item.Rows[e.RowIndex].Cells["col_IDLote"].Value;
                btn_Remover_Click(idLote);
            }
        }

        private void btn_Remover_Click(int idLote)
        {
            var itemParaRemover = itensVenda.FirstOrDefault(item => item.IdLote == idLote);
            if (itemParaRemover != null)
            {
                itensVenda.Remove(itemParaRemover);
            }

            CarregarItens();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_ItensCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_ItensCompra.SelectedItem is Lote selectedLote)
            {
                nud_Quantidade.Maximum = selectedLote.Quantidade;
                nud_Quantidade.Value = 1;
            }
        }
    }
}
