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


        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
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
            if (usuarios == null)
            {
                usuarios = new Form_Usuarios();
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

        //Codigo para fazer a transição da barra.
        bool exapasaoBarra = true;

        private void TransicaoBarra_Tick(object sender, EventArgs e)
        {
            if (exapasaoBarra)
            {
                barraLateral.Width -= 5;

                if (barraLateral.Width <= 86)
                {
                    exapasaoBarra = false;
                    TransicaoBarra.Stop();
                }
            }
            else
            {
                barraLateral.Width += 5;
                if (barraLateral.Width >= 247)
                {
                    exapasaoBarra = true;
                    TransicaoBarra.Stop();
                }
            }
        }

        private void btn_alternar_Click(object sender, EventArgs e)
        {
            TransicaoBarra.Start();
        }

    }
}
