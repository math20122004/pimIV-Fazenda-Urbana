using System;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_VerUsuario : Form
    {
        private string idUsuario;
        private string funcao;

        public Form_VerUsuario(string idUsuario, string funcao)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.funcao = funcao;
        }

        private void Form_VerUsuario_Load(object sender, EventArgs e)
        {
            // Aqui você pode usar a variável funcao para determinar o que fazer quando o formulário abrir
            if (funcao == "ver")
            {
            }
            else if (funcao == "cadastro")
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para lidar com cliques nas células do DataGridView (se necessário)
        }
    }
}
