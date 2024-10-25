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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            panel1 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            lbl_email = new Label();
            panel2 = new Panel();
            btn_User = new PictureBox();
            label1 = new Label();
            btn_alternar = new PictureBox();
            panel3 = new Panel();
            lbl_nome = new Label();
            barraLateral = new FlowLayoutPanel();
            pn_inicio = new Panel();
            btn_inicio = new Button();
            pn_fornecedores = new Panel();
            btn_fornecedores = new Button();
            pn_vendas = new Panel();
            btn_vendas = new Button();
            pn_producao = new Panel();
            btn_producao = new Button();
            pn_usuarios = new Panel();
            btn_usuarios = new Button();
            BarraUser = new Panel();
            btn_sair = new Button();
            lbl_permissao = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lbl_RA = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_alternar).BeginInit();
            panel3.SuspendLayout();
            barraLateral.SuspendLayout();
            pn_inicio.SuspendLayout();
            pn_fornecedores.SuspendLayout();
            pn_vendas.SuspendLayout();
            pn_producao.SuspendLayout();
            pn_usuarios.SuspendLayout();
            BarraUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_alternar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(996, 69);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lbl_email);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(604, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(311, 17);
            panel4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(311, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 0;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Cursor = Cursors.UpArrow;
            lbl_email.Dock = DockStyle.Right;
            lbl_email.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = Color.White;
            lbl_email.ImageAlign = ContentAlignment.MiddleRight;
            lbl_email.Location = new Point(311, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(0, 14);
            lbl_email.TabIndex = 1;
            lbl_email.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(btn_User);
            panel2.Location = new Point(932, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(63, 59);
            panel2.TabIndex = 3;
            // 
            // btn_User
            // 
            btn_User.BackColor = Color.FromArgb(7, 30, 34);
            btn_User.Image = (Image)resources.GetObject("btn_User.Image");
            btn_User.Location = new Point(-2, -1);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(65, 60);
            btn_User.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_User.TabIndex = 1;
            btn_User.TabStop = false;
            btn_User.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 120, 116);
            label1.Location = new Point(71, 14);
            label1.Name = "label1";
            label1.Size = new Size(185, 35);
            label1.TabIndex = 2;
            label1.Text = "City Green";
            // 
            // btn_alternar
            // 
            btn_alternar.Image = (Image)resources.GetObject("btn_alternar.Image");
            btn_alternar.Location = new Point(12, 6);
            btn_alternar.Name = "btn_alternar";
            btn_alternar.Size = new Size(53, 57);
            btn_alternar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_alternar.TabIndex = 1;
            btn_alternar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_nome);
            panel3.Location = new Point(604, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(311, 22);
            panel3.TabIndex = 5;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Dock = DockStyle.Right;
            lbl_nome.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = Color.WhiteSmoke;
            lbl_nome.ImageAlign = ContentAlignment.MiddleRight;
            lbl_nome.Location = new Point(311, 0);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 18);
            lbl_nome.TabIndex = 0;
            lbl_nome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(7, 30, 34);
            barraLateral.Controls.Add(pn_inicio);
            barraLateral.Controls.Add(pn_fornecedores);
            barraLateral.Controls.Add(pn_vendas);
            barraLateral.Controls.Add(pn_producao);
            barraLateral.Controls.Add(pn_usuarios);
            barraLateral.Dock = DockStyle.Left;
            barraLateral.Location = new Point(0, 69);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(138, 553);
            barraLateral.TabIndex = 1;
            // 
            // pn_inicio
            // 
            pn_inicio.Controls.Add(btn_inicio);
            pn_inicio.Location = new Point(3, 20);
            pn_inicio.Margin = new Padding(3, 20, 3, 3);
            pn_inicio.Name = "pn_inicio";
            pn_inicio.Size = new Size(132, 100);
            pn_inicio.TabIndex = 2;
            // 
            // btn_inicio
            // 
            btn_inicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_inicio.BackColor = Color.FromArgb(7, 30, 34);
            btn_inicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = Color.FromArgb(29, 120, 116);
            btn_inicio.Image = (Image)resources.GetObject("btn_inicio.Image");
            btn_inicio.Location = new Point(-6, -7);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Padding = new Padding(5, 0, 5, 0);
            btn_inicio.Size = new Size(143, 115);
            btn_inicio.TabIndex = 4;
            btn_inicio.Text = "Inicio";
            btn_inicio.TextAlign = ContentAlignment.BottomCenter;
            btn_inicio.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // pn_fornecedores
            // 
            pn_fornecedores.Controls.Add(btn_fornecedores);
            pn_fornecedores.Location = new Point(3, 126);
            pn_fornecedores.Name = "pn_fornecedores";
            pn_fornecedores.Size = new Size(132, 101);
            pn_fornecedores.TabIndex = 5;
            // 
            // btn_fornecedores
            // 
            btn_fornecedores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_fornecedores.BackColor = Color.FromArgb(7, 30, 34);
            btn_fornecedores.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fornecedores.ForeColor = Color.FromArgb(29, 120, 116);
            btn_fornecedores.Image = (Image)resources.GetObject("btn_fornecedores.Image");
            btn_fornecedores.Location = new Point(-6, -4);
            btn_fornecedores.Name = "btn_fornecedores";
            btn_fornecedores.Padding = new Padding(5, 0, 5, 0);
            btn_fornecedores.Size = new Size(143, 112);
            btn_fornecedores.TabIndex = 3;
            btn_fornecedores.Text = "Fornecedores";
            btn_fornecedores.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_fornecedores.UseVisualStyleBackColor = false;
            btn_fornecedores.Click += btn_fornecedores_Click;
            // 
            // pn_vendas
            // 
            pn_vendas.Controls.Add(btn_vendas);
            pn_vendas.Location = new Point(3, 233);
            pn_vendas.Name = "pn_vendas";
            pn_vendas.Size = new Size(132, 101);
            pn_vendas.TabIndex = 4;
            // 
            // btn_vendas
            // 
            btn_vendas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_vendas.BackColor = Color.FromArgb(7, 30, 34);
            btn_vendas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_vendas.ForeColor = Color.FromArgb(29, 120, 116);
            btn_vendas.Image = (Image)resources.GetObject("btn_vendas.Image");
            btn_vendas.Location = new Point(-6, -6);
            btn_vendas.Name = "btn_vendas";
            btn_vendas.Padding = new Padding(5, 0, 5, 0);
            btn_vendas.Size = new Size(143, 115);
            btn_vendas.TabIndex = 3;
            btn_vendas.Text = "Vendas";
            btn_vendas.TextAlign = ContentAlignment.BottomCenter;
            btn_vendas.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_vendas.UseVisualStyleBackColor = false;
            btn_vendas.Click += btn_vendas_Click;
            // 
            // pn_producao
            // 
            pn_producao.Controls.Add(btn_producao);
            pn_producao.Location = new Point(3, 340);
            pn_producao.Name = "pn_producao";
            pn_producao.Size = new Size(132, 101);
            pn_producao.TabIndex = 6;
            // 
            // btn_producao
            // 
            btn_producao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_producao.BackColor = Color.FromArgb(7, 30, 34);
            btn_producao.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_producao.ForeColor = Color.FromArgb(29, 120, 116);
            btn_producao.Image = (Image)resources.GetObject("btn_producao.Image");
            btn_producao.Location = new Point(-5, -6);
            btn_producao.Name = "btn_producao";
            btn_producao.Padding = new Padding(5, 0, 5, 0);
            btn_producao.Size = new Size(141, 115);
            btn_producao.TabIndex = 3;
            btn_producao.Text = "Produção";
            btn_producao.TextAlign = ContentAlignment.BottomCenter;
            btn_producao.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_producao.UseVisualStyleBackColor = false;
            btn_producao.Click += btn_producao_Click;
            // 
            // pn_usuarios
            // 
            pn_usuarios.Controls.Add(btn_usuarios);
            pn_usuarios.Location = new Point(3, 447);
            pn_usuarios.Name = "pn_usuarios";
            pn_usuarios.Size = new Size(132, 101);
            pn_usuarios.TabIndex = 7;
            // 
            // btn_usuarios
            // 
            btn_usuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_usuarios.BackColor = Color.FromArgb(7, 30, 34);
            btn_usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_usuarios.ForeColor = Color.FromArgb(29, 120, 116);
            btn_usuarios.Image = (Image)resources.GetObject("btn_usuarios.Image");
            btn_usuarios.Location = new Point(-5, -5);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Padding = new Padding(5, 0, 5, 0);
            btn_usuarios.Size = new Size(143, 115);
            btn_usuarios.TabIndex = 3;
            btn_usuarios.Text = "Usuários";
            btn_usuarios.TextAlign = ContentAlignment.BottomCenter;
            btn_usuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // BarraUser
            // 
            BarraUser.BackColor = Color.FromArgb(7, 30, 34);
            BarraUser.Controls.Add(btn_sair);
            BarraUser.Controls.Add(lbl_permissao);
            BarraUser.Controls.Add(panel5);
            BarraUser.Controls.Add(label3);
            BarraUser.Controls.Add(lbl_RA);
            BarraUser.Location = new Point(730, 69);
            BarraUser.Name = "BarraUser";
            BarraUser.Size = new Size(266, 0);
            BarraUser.TabIndex = 3;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            btn_sair.ForeColor = Color.IndianRed;
            btn_sair.Location = new Point(197, 159);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(61, 32);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // lbl_permissao
            // 
            lbl_permissao.AutoSize = true;
            lbl_permissao.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_permissao.ForeColor = Color.White;
            lbl_permissao.Location = new Point(20, 88);
            lbl_permissao.Name = "lbl_permissao";
            lbl_permissao.Size = new Size(19, 18);
            lbl_permissao.TabIndex = 8;
            lbl_permissao.Text = "P";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(3, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 3);
            panel5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 57);
            label3.Name = "label3";
            label3.Size = new Size(109, 18);
            label3.TabIndex = 7;
            label3.Text = "Permissões:";
            // 
            // lbl_RA
            // 
            lbl_RA.AutoSize = true;
            lbl_RA.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RA.ForeColor = Color.White;
            lbl_RA.Location = new Point(20, 16);
            lbl_RA.Name = "lbl_RA";
            lbl_RA.Size = new Size(32, 18);
            lbl_RA.TabIndex = 6;
            lbl_RA.Text = "RA";
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(996, 622);
            Controls.Add(BarraUser);
            Controls.Add(barraLateral);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_";
            Load += Form_Principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_alternar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            barraLateral.ResumeLayout(false);
            pn_inicio.ResumeLayout(false);
            pn_fornecedores.ResumeLayout(false);
            pn_vendas.ResumeLayout(false);
            pn_producao.ResumeLayout(false);
            pn_usuarios.ResumeLayout(false);
            BarraUser.ResumeLayout(false);
            BarraUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btn_alternar;
        private Label label1;
        private PictureBox btn_User;
        private FlowLayoutPanel barraLateral;
        private Panel pn_inicio;
        public Button btn_inicio;
        private Panel pn_fornecedores;
        public Button btn_fornecedores;
        private Panel pn_producao;
        public Button btn_producao;
        private Panel pn_vendas;
        public Button btn_vendas;
        private Panel pn_usuarios;
        public Button btn_usuarios;
        private Panel panel2;
        private Panel BarraUser;
        private Panel panel3;
        private Label lbl_email;
        private Label lbl_nome;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label lbl_RA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel5;
        private Label lbl_permissao;
        private Button btn_sair;
    }
}
