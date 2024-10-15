using System;
using System.Threading;
using System.Windows.Forms;
using LoginSistema;

namespace CityGreen
{
    public partial class Form_Login : Form
    {
        private Login login = new Login();
        private Thread t1;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Você gostaria de sair do Sistema?";
            string title = "Fechar Sistema";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userLogin = txtB_login.Text;
            string userSenha = txtB_senha.Text;

            string resultado = login.VerificarCredenciais(userLogin, userSenha);

            if (resultado == "Login inválido")
            {
                MessageBox.Show("Login inválido. Tente novamente.");
            }
            else if (resultado == "SenhaInvalida")
            {
                MessageBox.Show("Senha inválida. Tente novamente.");
            }
            else if (resultado == "Erro no sistema")
            {
                MessageBox.Show("Ocorreu um erro no sistema. Tente novamente mais tarde.");
            }
            else if (resultado == "TrocaSenha") // Se a senha for 'Troca123'
            {
                MessageBox.Show("Você está utilizando a senha padrão. Por favor, escolha uma nova senha.");

                string novaSenha = PromptNovaSenha(); // Método para solicitar a nova senha
                if (!string.IsNullOrEmpty(novaSenha))
                {
                    // Atualiza a senha no banco de dados
                    bool senhaAtualizada = login.EditarSenha(userLogin, novaSenha);

                    if (senhaAtualizada)
                    {
                        MessageBox.Show("Senha alterada com sucesso!");

                        // Verifica as credenciais após a troca de senha
                        resultado = login.VerificarCredenciais(userLogin, novaSenha);
                        if (resultado != "Login inválido" && resultado != "SenhaInvalida" && resultado != "Erro no sistema")
                        {
                            MessageBox.Show("Login bem-sucedido!");
                            this.Close();
                            t1 = new Thread(abrirJanela);
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start(resultado);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar login com a nova senha. Tente novamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar a senha. Tente novamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start(resultado);
            }
        }

        private void abrirJanela(object obj)
        {
            string idUsuario = obj as string;
            Application.Run(new Form_Principal(idUsuario));
        }

        private string PromptNovaSenha()
        {
            using (Form form = new Form())
            {
                // Configuração do formulário
                form.Text = "Alterar Senha";
                form.ClientSize = new System.Drawing.Size(350, 200); // Tamanho do formulário
                form.StartPosition = FormStartPosition.CenterScreen; // Centralizar na tela
                form.FormBorderStyle = FormBorderStyle.FixedDialog; // Evita redimensionamento
                form.MaximizeBox = false; // Desativa o botão maximizar

                // Label "Nova senha:"
                Label label = new Label()
                {
                    Text = "Nova senha:",
                    Font = new System.Drawing.Font("Verdana", 12, System.Drawing.FontStyle.Bold),
                    AutoSize = true,
                    Top = 20,
                    Left = (form.ClientSize.Width - 150) / 2 // Centralizar horizontalmente
                };

                // TextBox para a nova senha
                TextBox textBox = new TextBox()
                {
                    PasswordChar = '*',
                    Font = new System.Drawing.Font("Verdana", 12),
                    Top = label.Bottom + 10, // Abaixo do label
                    Width = 200,
                    Left = (form.ClientSize.Width - 200) / 2 // Centralizar horizontalmente
                };

                // Botão Confirmar (verde)
                Button buttonConfirmar = new Button()
                {
                    Text = "Confirmar",
                    DialogResult = DialogResult.OK,
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#006400"), // Verde escuro
                    ForeColor = System.Drawing.Color.White, // Fonte branca
                    FlatStyle = FlatStyle.Flat,
                    Width = 120,
                    Height = 40,
                    Top = textBox.Bottom + 20,
                    Left = 40
                };

                // Botão Cancelar (vermelho)
                Button buttonCancel = new Button()
                {
                    Text = "Cancelar",
                    DialogResult = DialogResult.Cancel,
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#EE2E31"), // Vermelho
                    ForeColor = System.Drawing.Color.White, // Fonte branca
                    FlatStyle = FlatStyle.Flat,
                    Width = 120,
                    Height = 40,
                    Top = textBox.Bottom + 20,
                    Left = form.ClientSize.Width - 160 // Alinhar à direita
                };

                // Adicionar controles ao formulário
                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(buttonConfirmar);
                form.Controls.Add(buttonCancel);

                // Define o botão Confirmar como padrão de confirmação
                form.AcceptButton = buttonConfirmar;
                form.CancelButton = buttonCancel;

                // Retorna a nova senha ou null se Cancelar for clicado
                return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }

    }
}
