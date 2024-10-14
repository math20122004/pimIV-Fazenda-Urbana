namespace CityGreen
{
    partial class Form_VerUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerUsuario));
            tbx_nome = new TextBox();
            lbl_nome = new Label();
            lbl_ID = new Label();
            tbx_ID = new TextBox();
            lbl_email = new Label();
            tbx_email = new TextBox();
            lbl_funcao = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pl_editar = new Panel();
            btn_editar = new Button();
            pl_cancelar = new Panel();
            btn_cancelar = new Button();
            barraLateral = new FlowLayoutPanel();
            pl_confirmar = new Panel();
            btn_confirmar = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            btn_voltar = new Button();
            rb_simF = new RadioButton();
            rb_naoF = new RadioButton();
            gb_fornecedores = new GroupBox();
            gb_vendas = new GroupBox();
            rb_simV = new RadioButton();
            rb_naoV = new RadioButton();
            gb_producao = new GroupBox();
            rb_simP = new RadioButton();
            rb_naoP = new RadioButton();
            gb_administrador = new GroupBox();
            rb_simA = new RadioButton();
            rb_naoA = new RadioButton();
            lbl_ativo = new Label();
            gb_status = new GroupBox();
            rb_simS = new RadioButton();
            rb_naoS = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lbl_senha = new Label();
            gb_Senha = new GroupBox();
            rb_simR = new RadioButton();
            rb_naoR = new RadioButton();
            pl_editar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            barraLateral.SuspendLayout();
            pl_confirmar.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            gb_fornecedores.SuspendLayout();
            gb_vendas.SuspendLayout();
            gb_producao.SuspendLayout();
            gb_administrador.SuspendLayout();
            gb_status.SuspendLayout();
            gb_Senha.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_nome
            // 
            tbx_nome.BorderStyle = BorderStyle.FixedSingle;
            tbx_nome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nome.Location = new Point(130, 129);
            tbx_nome.MaxLength = 255;
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(466, 27);
            tbx_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(44, 133);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(80, 23);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.Location = new Point(44, 88);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(44, 23);
            lbl_ID.TabIndex = 2;
            lbl_ID.Text = "ID:";
            // 
            // tbx_ID
            // 
            tbx_ID.BorderStyle = BorderStyle.FixedSingle;
            tbx_ID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ID.Location = new Point(94, 88);
            tbx_ID.MaxLength = 8;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(118, 27);
            tbx_ID.TabIndex = 3;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(44, 178);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(78, 23);
            lbl_email.TabIndex = 4;
            lbl_email.Text = "Email:";
            // 
            // tbx_email
            // 
            tbx_email.BorderStyle = BorderStyle.FixedSingle;
            tbx_email.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_email.Location = new Point(130, 178);
            tbx_email.MaxLength = 255;
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(466, 27);
            tbx_email.TabIndex = 5;
            // 
            // lbl_funcao
            // 
            lbl_funcao.AutoSize = true;
            lbl_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_funcao.Location = new Point(309, 10);
            lbl_funcao.Name = "lbl_funcao";
            lbl_funcao.Size = new Size(119, 29);
            lbl_funcao.TabIndex = 8;
            lbl_funcao.Text = "Função:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 120, 116);
            label2.Location = new Point(210, 272);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 9;
            label2.Text = "Permissões";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 316);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 10;
            label3.Text = "Fornecedores:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 357);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 11;
            label4.Text = "Vendas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 398);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 12;
            label5.Text = "Produção:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 439);
            label6.Name = "label6";
            label6.Size = new Size(171, 23);
            label6.TabIndex = 13;
            label6.Text = "Administrador:";
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(682, 5);
            pl_editar.Margin = new Padding(3, 5, 3, 5);
            pl_editar.Name = "pl_editar";
            pl_editar.Size = new Size(173, 42);
            pl_editar.TabIndex = 17;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(7, 30, 34);
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = SystemColors.ButtonHighlight;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(0, 0);
            btn_editar.Margin = new Padding(3, 3, 3323, 10);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(173, 42);
            btn_editar.TabIndex = 15;
            btn_editar.Text = "Editar";
            btn_editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // pl_cancelar
            // 
            pl_cancelar.Anchor = AnchorStyles.Right;
            pl_cancelar.Controls.Add(btn_cancelar);
            pl_cancelar.Location = new Point(324, 5);
            pl_cancelar.Margin = new Padding(3, 5, 3, 5);
            pl_cancelar.Name = "pl_cancelar";
            pl_cancelar.Size = new Size(173, 42);
            pl_cancelar.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(238, 46, 49);
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelar.Image = (Image)resources.GetObject("btn_cancelar.Image");
            btn_cancelar.Location = new Point(0, 0);
            btn_cancelar.Margin = new Padding(3, 3, 3323, 10);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(173, 42);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(7, 30, 34);
            barraLateral.Controls.Add(pl_editar);
            barraLateral.Controls.Add(pl_confirmar);
            barraLateral.Controls.Add(pl_cancelar);
            barraLateral.Dock = DockStyle.Bottom;
            barraLateral.FlowDirection = FlowDirection.RightToLeft;
            barraLateral.Location = new Point(0, 500);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(858, 53);
            barraLateral.TabIndex = 18;
            // 
            // pl_confirmar
            // 
            pl_confirmar.Anchor = AnchorStyles.Right;
            pl_confirmar.Controls.Add(btn_confirmar);
            pl_confirmar.Location = new Point(503, 5);
            pl_confirmar.Margin = new Padding(3, 5, 3, 5);
            pl_confirmar.Name = "pl_confirmar";
            pl_confirmar.Size = new Size(173, 42);
            pl_confirmar.TabIndex = 32;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.DarkGreen;
            btn_confirmar.FlatStyle = FlatStyle.Flat;
            btn_confirmar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirmar.ForeColor = SystemColors.ButtonHighlight;
            btn_confirmar.Image = (Image)resources.GetObject("btn_confirmar.Image");
            btn_confirmar.Location = new Point(0, 0);
            btn_confirmar.Margin = new Padding(3, 3, 3323, 10);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(173, 42);
            btn_confirmar.TabIndex = 15;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(lbl_funcao);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 59);
            panel1.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(btn_voltar);
            panel4.Location = new Point(25, 5);
            panel4.Margin = new Padding(3, 5, 3, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 42);
            panel4.TabIndex = 20;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.FromArgb(7, 30, 34);
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.ForeColor = SystemColors.ButtonHighlight;
            btn_voltar.Image = (Image)resources.GetObject("btn_voltar.Image");
            btn_voltar.Location = new Point(0, 0);
            btn_voltar.Margin = new Padding(3, 3, 3323, 10);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(134, 42);
            btn_voltar.TabIndex = 15;
            btn_voltar.Text = "Voltar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // rb_simF
            // 
            rb_simF.AutoSize = true;
            rb_simF.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simF.Location = new Point(6, 8);
            rb_simF.Name = "rb_simF";
            rb_simF.Size = new Size(57, 22);
            rb_simF.TabIndex = 20;
            rb_simF.TabStop = true;
            rb_simF.Text = "Sim";
            rb_simF.UseVisualStyleBackColor = true;
            // 
            // rb_naoF
            // 
            rb_naoF.AutoSize = true;
            rb_naoF.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoF.Location = new Point(88, 8);
            rb_naoF.Name = "rb_naoF";
            rb_naoF.Size = new Size(61, 22);
            rb_naoF.TabIndex = 21;
            rb_naoF.TabStop = true;
            rb_naoF.Text = "Não";
            rb_naoF.UseVisualStyleBackColor = true;
            // 
            // gb_fornecedores
            // 
            gb_fornecedores.Controls.Add(rb_simF);
            gb_fornecedores.Controls.Add(rb_naoF);
            gb_fornecedores.Location = new Point(279, 307);
            gb_fornecedores.Name = "gb_fornecedores";
            gb_fornecedores.Size = new Size(162, 32);
            gb_fornecedores.TabIndex = 28;
            gb_fornecedores.TabStop = false;
            // 
            // gb_vendas
            // 
            gb_vendas.Controls.Add(rb_simV);
            gb_vendas.Controls.Add(rb_naoV);
            gb_vendas.Location = new Point(279, 348);
            gb_vendas.Name = "gb_vendas";
            gb_vendas.Size = new Size(162, 32);
            gb_vendas.TabIndex = 29;
            gb_vendas.TabStop = false;
            // 
            // rb_simV
            // 
            rb_simV.AutoSize = true;
            rb_simV.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simV.Location = new Point(6, 8);
            rb_simV.Name = "rb_simV";
            rb_simV.Size = new Size(57, 22);
            rb_simV.TabIndex = 20;
            rb_simV.TabStop = true;
            rb_simV.Text = "Sim";
            rb_simV.UseVisualStyleBackColor = true;
            // 
            // rb_naoV
            // 
            rb_naoV.AutoSize = true;
            rb_naoV.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoV.Location = new Point(88, 8);
            rb_naoV.Name = "rb_naoV";
            rb_naoV.Size = new Size(61, 22);
            rb_naoV.TabIndex = 21;
            rb_naoV.TabStop = true;
            rb_naoV.Text = "Não";
            rb_naoV.UseVisualStyleBackColor = true;
            // 
            // gb_producao
            // 
            gb_producao.Controls.Add(rb_simP);
            gb_producao.Controls.Add(rb_naoP);
            gb_producao.Location = new Point(279, 389);
            gb_producao.Name = "gb_producao";
            gb_producao.Size = new Size(162, 32);
            gb_producao.TabIndex = 30;
            gb_producao.TabStop = false;
            // 
            // rb_simP
            // 
            rb_simP.AutoSize = true;
            rb_simP.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simP.Location = new Point(6, 8);
            rb_simP.Name = "rb_simP";
            rb_simP.Size = new Size(57, 22);
            rb_simP.TabIndex = 20;
            rb_simP.TabStop = true;
            rb_simP.Text = "Sim";
            rb_simP.UseVisualStyleBackColor = true;
            // 
            // rb_naoP
            // 
            rb_naoP.AutoSize = true;
            rb_naoP.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoP.Location = new Point(88, 8);
            rb_naoP.Name = "rb_naoP";
            rb_naoP.Size = new Size(61, 22);
            rb_naoP.TabIndex = 21;
            rb_naoP.TabStop = true;
            rb_naoP.Text = "Não";
            rb_naoP.UseVisualStyleBackColor = true;
            // 
            // gb_administrador
            // 
            gb_administrador.Controls.Add(rb_simA);
            gb_administrador.Controls.Add(rb_naoA);
            gb_administrador.Location = new Point(279, 430);
            gb_administrador.Name = "gb_administrador";
            gb_administrador.Size = new Size(162, 32);
            gb_administrador.TabIndex = 31;
            gb_administrador.TabStop = false;
            // 
            // rb_simA
            // 
            rb_simA.AutoSize = true;
            rb_simA.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simA.Location = new Point(6, 8);
            rb_simA.Name = "rb_simA";
            rb_simA.Size = new Size(57, 22);
            rb_simA.TabIndex = 20;
            rb_simA.TabStop = true;
            rb_simA.Text = "Sim";
            rb_simA.UseVisualStyleBackColor = true;
            // 
            // rb_naoA
            // 
            rb_naoA.AutoSize = true;
            rb_naoA.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoA.Location = new Point(88, 8);
            rb_naoA.Name = "rb_naoA";
            rb_naoA.Size = new Size(61, 22);
            rb_naoA.TabIndex = 21;
            rb_naoA.TabStop = true;
            rb_naoA.Text = "Não";
            rb_naoA.UseVisualStyleBackColor = true;
            // 
            // lbl_ativo
            // 
            lbl_ativo.AutoSize = true;
            lbl_ativo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ativo.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_ativo.Location = new Point(655, 272);
            lbl_ativo.Name = "lbl_ativo";
            lbl_ativo.Size = new Size(66, 23);
            lbl_ativo.TabIndex = 32;
            lbl_ativo.Text = "Ativo";
            // 
            // gb_status
            // 
            gb_status.Controls.Add(rb_simS);
            gb_status.Controls.Add(rb_naoS);
            gb_status.Location = new Point(605, 307);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(162, 32);
            gb_status.TabIndex = 33;
            gb_status.TabStop = false;
            // 
            // rb_simS
            // 
            rb_simS.AutoSize = true;
            rb_simS.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simS.Location = new Point(6, 8);
            rb_simS.Name = "rb_simS";
            rb_simS.Size = new Size(57, 22);
            rb_simS.TabIndex = 20;
            rb_simS.TabStop = true;
            rb_simS.Text = "Sim";
            rb_simS.UseVisualStyleBackColor = true;
            // 
            // rb_naoS
            // 
            rb_naoS.AutoSize = true;
            rb_naoS.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoS.Location = new Point(88, 8);
            rb_naoS.Name = "rb_naoS";
            rb_naoS.Size = new Size(61, 22);
            rb_naoS.TabIndex = 21;
            rb_naoS.TabStop = true;
            rb_naoS.Text = "Não";
            rb_naoS.UseVisualStyleBackColor = true;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(46, 228);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(176, 23);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Resetar Senha:";
            // 
            // gb_Senha
            // 
            gb_Senha.Controls.Add(rb_simR);
            gb_Senha.Controls.Add(rb_naoR);
            gb_Senha.Location = new Point(228, 222);
            gb_Senha.Name = "gb_Senha";
            gb_Senha.Size = new Size(162, 32);
            gb_Senha.TabIndex = 34;
            gb_Senha.TabStop = false;
            // 
            // rb_simR
            // 
            rb_simR.AutoSize = true;
            rb_simR.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_simR.Location = new Point(6, 8);
            rb_simR.Name = "rb_simR";
            rb_simR.Size = new Size(57, 22);
            rb_simR.TabIndex = 20;
            rb_simR.TabStop = true;
            rb_simR.Text = "Sim";
            rb_simR.UseVisualStyleBackColor = true;
            // 
            // rb_naoR
            // 
            rb_naoR.AutoSize = true;
            rb_naoR.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_naoR.Location = new Point(88, 8);
            rb_naoR.Name = "rb_naoR";
            rb_naoR.Size = new Size(61, 22);
            rb_naoR.TabIndex = 21;
            rb_naoR.TabStop = true;
            rb_naoR.Text = "Não";
            rb_naoR.UseVisualStyleBackColor = true;
            // 
            // Form_VerUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            ControlBox = false;
            Controls.Add(gb_Senha);
            Controls.Add(gb_status);
            Controls.Add(lbl_ativo);
            Controls.Add(gb_administrador);
            Controls.Add(gb_producao);
            Controls.Add(gb_vendas);
            Controls.Add(gb_fornecedores);
            Controls.Add(panel1);
            Controls.Add(barraLateral);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_senha);
            Controls.Add(tbx_email);
            Controls.Add(lbl_email);
            Controls.Add(tbx_ID);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_nome);
            Controls.Add(tbx_nome);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form_VerUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form_VerUsuario";
            WindowState = FormWindowState.Maximized;
            Load += Form_VerUsuario_Load;
            pl_editar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            barraLateral.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            gb_fornecedores.ResumeLayout(false);
            gb_fornecedores.PerformLayout();
            gb_vendas.ResumeLayout(false);
            gb_vendas.PerformLayout();
            gb_producao.ResumeLayout(false);
            gb_producao.PerformLayout();
            gb_administrador.ResumeLayout(false);
            gb_administrador.PerformLayout();
            gb_status.ResumeLayout(false);
            gb_status.PerformLayout();
            gb_Senha.ResumeLayout(false);
            gb_Senha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_nome;
        private Label lbl_nome;
        private Label lbl_ID;
        private TextBox tbx_ID;
        private Label lbl_email;
        private TextBox tbx_email;
        private Label lbl_funcao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel pn_cadastrar;
        private Panel pl_editar;
        private Button btn_editar;
        private Panel pl_cancelar;
        private Button btn_cancelar;
        private FlowLayoutPanel barraLateral;
        private Panel panel1;
        private Panel panel4;
        private Button btn_voltar;
        private RadioButton rb_simF;
        private RadioButton rb_naoF;
        private GroupBox gb_fornecedores;
        private GroupBox gb_vendas;
        private RadioButton rb_simV;
        private RadioButton rb_naoV;
        private GroupBox gb_producao;
        private RadioButton rb_simP;
        private RadioButton rb_naoP;
        private GroupBox gb_administrador;
        private RadioButton rb_simA;
        private RadioButton rb_naoA;
        private Button btn_inicio;
        private Panel pl_confirmar;
        private Button btn_confirmar;
        private Label lbl_ativo;
        private GroupBox gb_status;
        private RadioButton rb_simS;
        private RadioButton rb_naoS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbl_senha;
        private GroupBox gb_Senha;
        private RadioButton rb_simR;
        private RadioButton rb_naoR;
    }
}