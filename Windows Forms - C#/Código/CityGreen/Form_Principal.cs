using Gestão_Usuarios;

namespace CityGreen
{
    public partial class Form_Principal : Form
    {
        private Form_Fornecedores fornecedores;
        private Form_Inicio inicio;
        private Form_Login login;
        private Form_Vendas vendas;
        private Form_Producao producao;
        private Form_Usuarios usuarios;

        private string idUsuario;
        private Button btnSelecionado = null;

        // Definir as cores
        private Color corFundoOriginal = ColorTranslator.FromHtml("#071E22");
        private Color corTextoOriginal = ColorTranslator.FromHtml("#1D7874");
        private Color corFundoSelecionado = ColorTranslator.FromHtml("#1D7874");
        private Color corTextoSelecionado = ColorTranslator.FromHtml("#ffffff");

        public Form_Principal(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            btn_inicio.PerformClick();

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
            btnSelecionado.BackColor = corFundoSelecionado;
            btnSelecionado.ForeColor = corTextoSelecionado;
        }

        private void AbrirForm<T>(ref T form) where T : Form, new()
        {
            // Tenta encontrar o botão correspondente
            Button btn = (Button)this.Controls.Find($"btn_{typeof(T).Name.ToLower()}", true).FirstOrDefault();

            if (btn != null)
            {
                SelectBtn(btn);
            }

            if (form == null || form.IsDisposed)
            {
                form = new T { MdiParent = this };
                form.FormClosed += Form_FormClosed; // Lida com o fechamento do formulário
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }




        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Atualiza a referência do formulário que foi fechado
            if (sender is Form closedForm)
            {
                if (closedForm is Form_Fornecedores)
                {
                    fornecedores = null;
                }
                else if (closedForm is Form_Inicio)
                {
                    inicio = null;
                }
                else if (closedForm is Form_Vendas)
                {
                    vendas = null;
                }
                else if (closedForm is Form_Producao)
                {
                    producao = null;
                }
                else if (closedForm is Form_Usuarios)
                {
                    usuarios = null;
                }
            }
        }

        private void btn_inicio_Click(object sender, EventArgs e) => AbrirForm(ref inicio);
        private void btn_vendas_Click(object sender, EventArgs e) => AbrirForm(ref vendas);
        private void btn_producao_Click(object sender, EventArgs e) => AbrirForm(ref producao);
        private void btn_fornecedores_Click(object sender, EventArgs e) => AbrirForm(ref fornecedores);
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            // Para Form_Usuarios, passando o idUsuario se necessário
            if (usuarios == null || usuarios.IsDisposed)
            {
                usuarios = new Form_Usuarios(idUsuario) { MdiParent = this };
                usuarios.FormClosed += Form_FormClosed; // Lida com o fechamento do formulário
                usuarios.Show();
            }
            else
            {
                usuarios.Activate();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BarraUser.Height = BarraUser.Height == 0 ? 200 : 0;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            string message = "Você gostaria de Deslogar?";
            string title = "Deslogar";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Thread(() => Application.Run(new Form_Login())).Start();
            }
        }
    }
}
