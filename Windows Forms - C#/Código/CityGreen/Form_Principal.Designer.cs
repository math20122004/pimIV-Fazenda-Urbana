namespace CityGreen
{
    partial class Form_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btn_alternar = new PictureBox();
            barraLateral = new FlowLayoutPanel();
            pn_inicio = new Panel();
            btn_inicio = new Button();
            pn_vendas = new Panel();
            btn_vendas = new Button();
            pn_producao = new Panel();
            btn_producao = new Button();
            pn_fornecedores = new Panel();
            btn_fornecedores = new Button();
            pn_usuarios = new Panel();
            btn_usuarios = new Button();
            TransicaoBarra = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_alternar).BeginInit();
            barraLateral.SuspendLayout();
            pn_inicio.SuspendLayout();
            pn_vendas.SuspendLayout();
            pn_producao.SuspendLayout();
            pn_fornecedores.SuspendLayout();
            pn_usuarios.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_alternar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(996, 69);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(932, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(63, 59);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(71, 14);
            label1.Name = "label1";
            label1.Size = new Size(185, 35);
            label1.TabIndex = 2;
            label1.Text = "City Green";
            // 
            // btn_alternar
            // 
            btn_alternar.Image = (Image)resources.GetObject("btn_alternar.Image");
            btn_alternar.Location = new Point(25, 12);
            btn_alternar.Name = "btn_alternar";
            btn_alternar.Size = new Size(40, 39);
            btn_alternar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_alternar.TabIndex = 1;
            btn_alternar.TabStop = false;
            btn_alternar.Click += btn_alternar_Click;
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.Black;
            barraLateral.Controls.Add(pn_inicio);
            barraLateral.Controls.Add(pn_vendas);
            barraLateral.Controls.Add(pn_producao);
            barraLateral.Controls.Add(pn_fornecedores);
            barraLateral.Controls.Add(pn_usuarios);
            barraLateral.Dock = DockStyle.Left;
            barraLateral.Location = new Point(0, 69);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(247, 553);
            barraLateral.TabIndex = 1;
            // 
            // pn_inicio
            // 
            pn_inicio.Controls.Add(btn_inicio);
            pn_inicio.Location = new Point(3, 40);
            pn_inicio.Margin = new Padding(3, 40, 3, 3);
            pn_inicio.Name = "pn_inicio";
            pn_inicio.Size = new Size(244, 70);
            pn_inicio.TabIndex = 2;
            // 
            // btn_inicio
            // 
            btn_inicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_inicio.BackColor = Color.Black;
            btn_inicio.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = Color.LawnGreen;
            btn_inicio.Image = (Image)resources.GetObject("btn_inicio.Image");
            btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inicio.Location = new Point(-6, -11);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Padding = new Padding(10, 0, 0, 0);
            btn_inicio.Size = new Size(256, 89);
            btn_inicio.TabIndex = 4;
            btn_inicio.Text = "               Inicio";
            btn_inicio.TextAlign = ContentAlignment.MiddleLeft;
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // pn_vendas
            // 
            pn_vendas.Controls.Add(btn_vendas);
            pn_vendas.Location = new Point(3, 116);
            pn_vendas.Name = "pn_vendas";
            pn_vendas.Size = new Size(244, 70);
            pn_vendas.TabIndex = 4;
            // 
            // btn_vendas
            // 
            btn_vendas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_vendas.BackColor = Color.Black;
            btn_vendas.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_vendas.ForeColor = Color.LawnGreen;
            btn_vendas.Image = (Image)resources.GetObject("btn_vendas.Image");
            btn_vendas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_vendas.Location = new Point(-9, -10);
            btn_vendas.Name = "btn_vendas";
            btn_vendas.Padding = new Padding(10, 0, 0, 0);
            btn_vendas.Size = new Size(259, 89);
            btn_vendas.TabIndex = 3;
            btn_vendas.Text = "               Vendas";
            btn_vendas.TextAlign = ContentAlignment.MiddleLeft;
            btn_vendas.UseVisualStyleBackColor = false;
            btn_vendas.Click += btn_vendas_Click;
            // 
            // pn_producao
            // 
            pn_producao.Controls.Add(btn_producao);
            pn_producao.Location = new Point(3, 192);
            pn_producao.Name = "pn_producao";
            pn_producao.Size = new Size(244, 70);
            pn_producao.TabIndex = 6;
            // 
            // btn_producao
            // 
            btn_producao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_producao.BackColor = Color.Black;
            btn_producao.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_producao.ForeColor = Color.LawnGreen;
            btn_producao.Image = (Image)resources.GetObject("btn_producao.Image");
            btn_producao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_producao.Location = new Point(-9, -10);
            btn_producao.Name = "btn_producao";
            btn_producao.Padding = new Padding(10, 0, 0, 0);
            btn_producao.Size = new Size(259, 89);
            btn_producao.TabIndex = 3;
            btn_producao.Text = "               Produção";
            btn_producao.TextAlign = ContentAlignment.MiddleLeft;
            btn_producao.UseVisualStyleBackColor = false;
            btn_producao.Click += btn_producao_Click;
            // 
            // pn_fornecedores
            // 
            pn_fornecedores.Controls.Add(btn_fornecedores);
            pn_fornecedores.Location = new Point(3, 268);
            pn_fornecedores.Name = "pn_fornecedores";
            pn_fornecedores.Size = new Size(244, 70);
            pn_fornecedores.TabIndex = 5;
            // 
            // btn_fornecedores
            // 
            btn_fornecedores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_fornecedores.BackColor = Color.Black;
            btn_fornecedores.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fornecedores.ForeColor = Color.LawnGreen;
            btn_fornecedores.Image = (Image)resources.GetObject("btn_fornecedores.Image");
            btn_fornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fornecedores.Location = new Point(-9, -10);
            btn_fornecedores.Name = "btn_fornecedores";
            btn_fornecedores.Padding = new Padding(10, 0, 0, 0);
            btn_fornecedores.Size = new Size(259, 89);
            btn_fornecedores.TabIndex = 3;
            btn_fornecedores.Text = "               Fornecedores";
            btn_fornecedores.TextAlign = ContentAlignment.MiddleLeft;
            btn_fornecedores.UseVisualStyleBackColor = false;
            btn_fornecedores.Click += btn_fornecedores_Click;
            // 
            // pn_usuarios
            // 
            pn_usuarios.Controls.Add(btn_usuarios);
            pn_usuarios.Location = new Point(3, 466);
            pn_usuarios.Margin = new Padding(3, 125, 3, 3);
            pn_usuarios.Name = "pn_usuarios";
            pn_usuarios.Size = new Size(244, 70);
            pn_usuarios.TabIndex = 7;
            // 
            // btn_usuarios
            // 
            btn_usuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_usuarios.BackColor = Color.Black;
            btn_usuarios.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_usuarios.ForeColor = Color.LawnGreen;
            btn_usuarios.Image = (Image)resources.GetObject("btn_usuarios.Image");
            btn_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usuarios.Location = new Point(-9, -10);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Padding = new Padding(10, 0, 0, 0);
            btn_usuarios.Size = new Size(259, 89);
            btn_usuarios.TabIndex = 3;
            btn_usuarios.Text = "               Usuários";
            btn_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // TransicaoBarra
            // 
            TransicaoBarra.Interval = 10;
            TransicaoBarra.Tick += TransicaoBarra_Tick;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(996, 622);
            Controls.Add(barraLateral);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_alternar).EndInit();
            barraLateral.ResumeLayout(false);
            pn_inicio.ResumeLayout(false);
            pn_vendas.ResumeLayout(false);
            pn_producao.ResumeLayout(false);
            pn_fornecedores.ResumeLayout(false);
            pn_usuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btn_alternar;
        private Label label1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel barraLateral;
        private Panel pn_inicio;
        private Button btn_inicio;
        private Panel pn_fornecedores;
        private Button btn_fornecedores;
        private Panel pn_producao;
        private Button btn_producao;
        private Panel pn_vendas;
        private Button btn_vendas;
        private Panel pn_usuarios;
        private Button btn_usuarios;
        private System.Windows.Forms.Timer TransicaoBarra;
        private Panel panel2;
    }
}
