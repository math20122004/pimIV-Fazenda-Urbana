using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSistema;
using Microsoft.VisualBasic.Logging;

namespace CityGreen
{
    public partial class Form_Login : Form
    {
        private Login login = new Login();

        Thread t1;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Você gostaria de sair do Sistema?";
            string title = "Fehcar Sistema";
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

            if (login.LogarSistema(userLogin, userSenha))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Form_Principal());
        }
    }
}
