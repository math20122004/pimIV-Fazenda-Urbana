using Gestão_Usuarios;

namespace CityGreen
{
    public partial class Form_Principal : Form
    {
        Form_Fornecedores fornecedores;
        Form_Inicio inicio;
        Form_Login login;
        Form_Vendas vendas;
        Form_Producao producao;
        Form_Usuarios usuarios;

        Thread t2;

        private string idUsuario;
        private Button btnSelecionado = null;

        // Definir as cores
        private Color corFundoOriginal = ColorTranslator.FromHtml("#071E22");
        private Color corTextoOriginal = ColorTranslator.FromHtml("#1D7874");
        private Color corFundoSelecionado = ColorTranslator.FromHtml("#1D7874"); // Alterado para "1D7874"
        private Color corTextoSelecionado = ColorTranslator.FromHtml("#ffffff");

        public Form_Principal(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Usuario dadosUsuario = usuario.VerUsuario(idUsuario);

            if (dadosUsuario != null)
            {
                lbl_nome.Text = dadosUsuario.Nome;
                lbl_email.Text = dadosUsuario.Email;
                lbl_RA.Text = idUsuario; // Colocando o ID do usuário no lbl_RA

                List<Permissao> permissoes = usuario.ListarPermissoes(idUsuario);

                // Inicialmente, esconda todos os painéis
                pn_fornecedores.Visible = false;
                pn_usuarios.Visible = false;
                pn_producao.Visible = false;
                pn_vendas.Visible = false;

                // Limpar o lbl_permissao antes de adicionar as permissões
                lbl_permissao.Text = "";

                // Verifique as permissões e mostre os painéis correspondentes
                foreach (var permissao in permissoes)
                {
                    // Adiciona a permissão no lbl_permissao, com "- " e uma nova linha
                    lbl_permissao.Text += "- " + permissao.NomeFuncionalidade + Environment.NewLine;

                    switch (permissao.NomeFuncionalidade)
                    {
                        case "Fornecedores":
                            pn_fornecedores.Visible = true;
                            break;
                        case "Vendas":
                            pn_vendas.Visible = true;
                            break;
                        case "Produção":
                            pn_producao.Visible = true;
                            break;
                        case "Administrador":
                            pn_usuarios.Visible = true;
                            break;
                    }
                }

                btn_inicio.PerformClick();
                btn_usuarios.PerformClick();
                btn_inicio.PerformClick();


            }
            else
            {
                MessageBox.Show("Erro ao carregar os dados do usuário.");
            }
        }

        // Função para resetar a seleção dos botões
        private void ResetBtn()
        {
            if (btnSelecionado != null)
            {
                // Reseta a cor do botão para o padrão
                btnSelecionado.BackColor = corFundoOriginal;
                btnSelecionado.ForeColor = corTextoOriginal;
                btnSelecionado = null;
            }
        }

        // Função para selecionar um botão e mudar o fundo e o texto
        private void SelectBtn(Button btn)
        {
            ResetBtn(); // Reseta qualquer botão previamente selecionado

            btnSelecionado = btn;
            btnSelecionado.BackColor = corFundoSelecionado; // Cor de fundo selecionada ("1D7874")
            btnSelecionado.ForeColor = corTextoSelecionado; // Cor do texto selecionada ("071E22")
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_inicio); // Marca o botão como selecionado

            if (inicio == null)
            {
                inicio = new Form_Inicio();
                inicio.FormClosed += Inicio_FormClosed;
                inicio.MdiParent = this;
                inicio.Show();
            }
            else
            {
                inicio.Activate();
            }
        }

        private void Inicio_FormClosed(object? sender, FormClosedEventArgs e)
        {
            inicio = null;
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_vendas); // Marca o botão como selecionado

            if (vendas == null)
            {
                vendas = new Form_Vendas();
                vendas.FormClosed += Vendas_FormClosed;
                vendas.MdiParent = this;
                vendas.Show();
            }
            else
            {
                vendas.Activate();
            };
        }

        private void Vendas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            vendas = null;
        }

        private void btn_producao_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_producao); // Marca o botão como selecionado

            if (producao == null)
            {
                producao = new Form_Producao();
                producao.FormClosed += Producao_FormClosed;
                producao.MdiParent = this;
                producao.Show();
            }
            else
            {
                producao.Activate();
            };
        }

        private void Producao_FormClosed(object? sender, FormClosedEventArgs e)
        {
            producao = null;
        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_fornecedores); // Marca o botão como selecionado

            if (fornecedores == null)
            {
                fornecedores = new Form_Fornecedores();
                fornecedores.FormClosed += Fornecedores_FormClosed;
                fornecedores.MdiParent = this;
                fornecedores.Show();
            }
            else
            {
                fornecedores.Activate();
            };
        }

        private void Fornecedores_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fornecedores = null;
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_usuarios); // Marca o botão como selecionado

            if (usuarios == null)
            {
                usuarios = new Form_Usuarios(idUsuario);
                usuarios.FormClosed += Usuarios_FormClosed;
                usuarios.MdiParent = this;
                usuarios.Show();
            }
            else
            {
                usuarios.Activate();
            };
        }

        private void Usuarios_FormClosed(object? sender, FormClosedEventArgs e)
        {
            usuarios = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (BarraUser.Height == 0)
            {
                BarraUser.Height = 200;
            }
            else
            {
                BarraUser.Height = 0;
            }
        }

        private void voltarJanela(object obj)
        {
            Application.Run(new Form_Login());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            string message = "Você gostaria de Deslogar?";
            string title = "Deslogar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t2 = new Thread(voltarJanela);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
            }
        }
    }
}
