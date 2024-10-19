using Gestão_Usuarios;
using System;
using System.Collections.Generic;
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
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            rb_naoF.Checked = true;
            rb_naoV.Checked = true;
            rb_naoP.Checked = true;
            rb_naoA.Checked = true;
            rb_naoR.Checked = true;

            if (funcao == "ver")
            {
                pl_confirmar.Hide();
                pl_cancelar.Hide();
                CarregarInformacoesUsuario();
                lbl_funcao.Text = "Visualizar Usuário";
                DesabilitarCampos();
            }
            else if (funcao == "cadastro")
            {
                lbl_funcao.Text = "Cadastrar Usuário";
                pl_editar.Hide();
                pl_cancelar.Hide();
                btn_confirmar.Text = "Cadastrar";
                HabilitarCampos();
                gb_status.Hide();
                lbl_ativo.Hide();
                gb_Senha.Hide();
                lbl_senha.Hide();
            }
        }

        private void DesabilitarCampos()
        {
            tbx_ID.Enabled = false;
            tbx_nome.Enabled = false;
            tbx_email.Enabled = false;
            gb_administrador.Enabled = false;
            gb_fornecedores.Enabled = false;
            gb_producao.Enabled = false;
            gb_vendas.Enabled = false;
            gb_Senha.Enabled = false;
            gb_status.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tbx_ID.Enabled = true;
            tbx_nome.Enabled = true;
            tbx_email.Enabled = true;
            gb_administrador.Enabled = true;
            gb_fornecedores.Enabled = true;
            gb_producao.Enabled = true;
            gb_vendas.Enabled = true;
            gb_Senha.Enabled = true;
            gb_status.Enabled = true;
        }

        private void CarregarInformacoesUsuario()
        {
            Usuario usuario = new Usuario();
            Usuario info = usuario.VerUsuario(idUsuario);

            if (info != null)
            {
                tbx_ID.Text = info.IdUsuario;
                tbx_nome.Text = info.Nome;
                tbx_email.Text = info.Email;
                rb_simS.Checked = info.StatusUsuario == "ativo";
                rb_naoS.Checked = info.StatusUsuario == "inativo";
                rb_naoR.Checked = true;

                List<Permissao> permissoes = info.ListarPermissoes(idUsuario);

                foreach (var permissao in permissoes)
                {
                    switch (permissao.NomeFuncionalidade)
                    {
                        case "Fornecedores":
                            rb_simF.Checked = true;
                            break;
                        case "Vendas":
                            rb_simV.Checked = true;
                            break;
                        case "Produção":
                            rb_simP.Checked = true;
                            break;
                        case "Administrador":
                            rb_simA.Checked = true;
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcao == "cadastro")
                {
                    CadastrarUsuario();
                }
                else if (funcao == "ver")
                {
                    EditarUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a operação: " + ex.Message);
            }
        }

        private void CadastrarUsuario()
        {
            Usuario novoUsuario = new Usuario
            {
                IdUsuario = tbx_ID.Text,
                Nome = tbx_nome.Text,
                Email = tbx_email.Text,
            };

            List<int> permissoesIds = new List<int>();
            if (rb_simF.Checked) permissoesIds.Add(1);
            if (rb_simV.Checked) permissoesIds.Add(2);
            if (rb_simP.Checked) permissoesIds.Add(3);
            if (rb_simA.Checked) permissoesIds.Add(4);

            bool resultado = novoUsuario.CadastrarUsuario(novoUsuario.IdUsuario, novoUsuario.Nome, novoUsuario.Email, permissoesIds);

            if (resultado)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o usuário.");
            }
        }

        private void EditarUsuario()
        {
            // Verifica se a opção de redefinição de senha está marcada
            bool redefinirSenha = rb_simR.Checked;
            string novaSenha = redefinirSenha ? "Troca123" : null; // Define a nova senha se necessário

            // Cria um objeto Usuario com os dados atualizados
            Usuario usuarioEditado = new Usuario
            {
                IdUsuario = idUsuario,
                Nome = tbx_nome.Text,
                Email = tbx_email.Text,
                StatusUsuario = rb_simS.Checked ? "ativo" : "inativo"
            };

            List<int> permissoesIds = new List<int>();
            if (rb_simF.Checked) permissoesIds.Add(1);
            if (rb_simV.Checked) permissoesIds.Add(2);
            if (rb_simP.Checked) permissoesIds.Add(3);
            if (rb_simA.Checked) permissoesIds.Add(4);

            // Edita o usuário no banco de dados
            bool sucesso = usuarioEditado.EditarUsuario(
                usuarioEditado.IdUsuario,
                usuarioEditado.Nome,
                usuarioEditado.Email,
                usuarioEditado.StatusUsuario,
                novaSenha, // Passando a nova senha
                permissoesIds // Passando as permissões
            );

            // Verifica se a edição do usuário foi bem-sucedida
            if (sucesso)
            {
                MessageBox.Show("Usuário atualizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o usuário.");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pl_editar.Hide();
            lbl_funcao.Text = "Editar Usuário";
            HabilitarCampos();
            pl_cancelar.Show();
            pl_confirmar.Show();
            gb_Senha.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarInformacoesUsuario();
            pl_editar.Show();
            lbl_funcao.Text = "Visualizar Usuário";
            pl_cancelar.Hide();
            pl_confirmar.Hide();
        }
    }
}
