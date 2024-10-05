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

            // Adiciona a coluna do botão "Visualizar"
            if (!dgw_usuarios.Columns.Contains("col_VerUsuario"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Ação";
                buttonColumn.Name = "col_VerUsuario"; // Nome da coluna para identificação
                buttonColumn.Text = "Visualizar";
                buttonColumn.UseColumnTextForButtonValue = true; // Usar o texto para todos os botões na coluna
                dgw_usuarios.Columns.Add(buttonColumn);
            }

            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            Usuario usuario = new Usuario();
            List<Usuario> listaUsuarios = usuario.ListarUsuarios();

            dgw_usuarios.Rows.Clear(); // Limpa os dados existentes

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                foreach (var usr in listaUsuarios)
                {
                    dgw_usuarios.Rows.Add(
                        usr.IdUsuario,    // Coluna ID
                        usr.Nome,         // Coluna Nome
                        usr.StatusUsuario, // Coluna Status
                        usr.Email         // Coluna Email
                    );
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado.");
            }
        }

        private void dgw_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a coluna clicada é a do botão "Visualizar"
            if (e.ColumnIndex == dgw_usuarios.Columns["col_VerUsuario"].Index && e.RowIndex >= 0)
            {
                string idUsuarioSelecionado = dgw_usuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
                AbrirFormVerUsuario(idUsuarioSelecionado, "ver"); // Passa o ID e a string "ver"
            }
        }

        private void AbrirFormVerUsuario(string idUsuarioSelecionado, string funcao)
        {
            // Verifica se o formulário já está aberto
            if (verUsuario == null || verUsuario.IsDisposed)
            {
                verUsuario = new Form_VerUsuario(idUsuarioSelecionado, funcao)
                {
                    MdiParent = this.MdiParent // Define o pai como o Form_Principal
                };
                verUsuario.FormClosed += VerUsuario_FormClosed;
                verUsuario.Show(); // Abre o formulário
            }
            else
            {
                verUsuario.Activate(); // Ativa o formulário se ele já estiver aberto
            }
        }

        private void VerUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verUsuario = null; // Limpa a referência ao fechar o form
        }

        private void btn_CadastrarUser_Click(object sender, EventArgs e)
        {
            
            var formVerUsuario = new Form_VerUsuario(idUsuario, "cadastro")
            {
                MdiParent = this.MdiParent
            };
            formVerUsuario.Show(); // Mostra o formulário

            this.Close();
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            // Chama o método que carrega os usuários novamente
            CarregarUsuarios();
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            // Lógica de pesquisa (se necessário)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Ação de algum botão adicional se necessário
        }
    }
}
