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
            if (!dgw_usuarios.Columns.Contains("col_VerUsuario"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Ação",
                    Name = "col_VerUsuario",
                    Text = "Visualizar",
                    UseColumnTextForButtonValue = true
                };
                dgw_usuarios.Columns.Add(buttonColumn);
            }
            CarregarUsuarios("");
        }

        private void CarregarUsuarios(string pesquisa)
        {
            Usuario usuario = new Usuario();
            List<Usuario> listaUsuarios = usuario.ListarUsuarios(pesquisa);
            dgw_usuarios.Rows.Clear(); // Limpa os dados existentes

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                lblMensagem.Visible = false;

                foreach (var usr in listaUsuarios)
                {
                    int rowIndex = dgw_usuarios.Rows.Add(
                        usr.IdUsuario,
                        usr.Nome,
                        usr.StatusUsuario,
                        usr.Email
                    );

                    // Adiciona o botão "Visualizar" à linha
                    DataGridViewButtonCell btn_verUsuario = new DataGridViewButtonCell
                    {
                        Value = "Visualizar"
                    };
                    dgw_usuarios.Rows[rowIndex].Cells["col_VerUsuario"] = btn_verUsuario;
                }

                // Configura as cores após adicionar todas as linhas
                foreach (DataGridViewRow row in dgw_usuarios.Rows)
                {
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["col_VerUsuario"];
                    btnCell.FlatStyle = FlatStyle.Flat;
                    btnCell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                    btnCell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                    btnCell.Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1D7874");
                    btnCell.Style.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#071E22");
                }
            }
            else
            {
                lblMensagem.Visible = true;
            }
        }

        private void dgw_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgw_usuarios.Columns["col_VerUsuario"].Index && e.RowIndex >= 0)
            {
                btn_verUsuario_Click(sender, e);
            }
        }

        private void btn_verUsuario_Click(object sender, DataGridViewCellEventArgs e)
        {
            string idUsuarioSelecionado = dgw_usuarios.Rows[e.RowIndex].Cells["col_RA"].Value.ToString();
            AbrirFormVerUsuario(idUsuarioSelecionado, "ver"); // Passa o ID e a string "ver"
        }

        public void AbrirFormVerUsuario(string idUsuarioSelecionado, string funcao)
        {
            if (verUsuario == null || verUsuario.IsDisposed)
            {
                verUsuario = new Form_VerUsuario(idUsuarioSelecionado, funcao)
                {
                    MdiParent = this.MdiParent
                };

                verUsuario.ControlBox = false;
                verUsuario.FormBorderStyle = FormBorderStyle.FixedDialog;
                verUsuario.FormClosed += VerUsuario_FormClosed;
                verUsuario.Show();
            }
            else
            {
                verUsuario.Activate();
            }
        }

        private void VerUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            verUsuario = null;

            if (this.MdiParent is Form_Principal principalForm)
            {
                principalForm.btn_usuarios.PerformClick(); // Simula o clique
            }

            this.Activate();
        }

        private void btn_CadastrarUser_Click(object sender, EventArgs e)
        {
            // Aqui você pode passar um ID de usuário vazio ou um específico
            string idUsuarioParaCadastrar = ""; // ou um ID específico se necessário
            AbrirFormVerUsuario(idUsuarioParaCadastrar, "cadastro");
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios("");
            tbx_pequisa.Text = "";
        }

        private void tbx_pequisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = tbx_pequisa.Text;
            CarregarUsuarios(pesquisa);
        }
    }
}
