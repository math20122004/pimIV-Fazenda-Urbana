﻿using System;
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
    }
}
