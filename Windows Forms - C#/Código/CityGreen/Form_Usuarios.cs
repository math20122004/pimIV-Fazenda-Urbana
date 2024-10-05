using Gestão_Usuarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CityGreen
{
    public partial class Form_Usuarios : Form
    {
        private string idUsuario;
        private Form_VerUsuario verUsuario;

        public Form_Usuarios(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Desabilitar botões de controle
            CarregarUsuarios();
            AdicionarBotaoVerUsuario();
        }

        private void CarregarUsuarios()
        {
            Usuario usuario = new Usuario();
            List<Usuario> listaUsuarios = usuario.ListarUsuarios();

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                dgw_usuarios.DataSource = listaUsuarios;
                dgw_usuarios.Columns["idUsuario"].Visible = false; // Oculta a coluna do ID para não exibir diretamente
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado.");
            }
        }

        private void AdicionarBotaoVerUsuario()
        {
            DataGridViewButtonColumn btnVerUsuario = new DataGridViewButtonColumn();
            btnVerUsuario.Name = "btnVerUsuario";
            btnVerUsuario.HeaderText = "Ver Usuário";
            btnVerUsuario.Text = "Ver";
            btnVerUsuario.UseColumnTextForButtonValue = true;
            dgw_usuarios.Columns.Add(btnVerUsuario); // Adiciona o botão "Ver Usuário"
        }

        private void dgw_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna do botão "Ver Usuário"
            if (e.ColumnIndex == dgw_usuarios.Columns["btnVerUsuario"].Index && e.RowIndex >= 0)
            {
                // Pega o valor da célula "idUsuario" da linha selecionada
                string idUsuarioSelecionado = dgw_usuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();

                // Abre o Form_VerUsuario com base no id do usuário
                AbrirFormVerUsuario(idUsuarioSelecionado);
            }
        }

        private void AbrirFormVerUsuario(string idUsuarioSelecionado)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AbrirFormVerUsuario), idUsuarioSelecionado);
            }
            else
            {
                // Inicializa o formulário de visualização de usuário e abre como MDI
                if (verUsuario == null)
                {
                    verUsuario = new Form_VerUsuario(idUsuarioSelecionado);
                    verUsuario.MdiParent = this.MdiParent; // Define o pai como o form principal
                    verUsuario.FormClosed += VerUsuario_FormClosed;
                    verUsuario.Show();
                }
                else
                {
                    verUsuario.Activate();
                }
            }
        }

        private void VerUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verUsuario = null; // Limpa a referência ao fechar o form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ação de algum botão adicional se necessário
        }
    }
}
