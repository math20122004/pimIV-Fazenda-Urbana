namespace CityGreen
{
    partial class Form_VerVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerVendas));
            barraLateral = new FlowLayoutPanel();
            pl_editar = new Panel();
            btn_editar = new Button();
            pl_confirmar = new Panel();
            btn_confirmar = new Button();
            pl_cancelar = new Panel();
            btn_cancelar = new Button();
            panel2 = new Panel();
            lbl_funcao = new Label();
            panel3 = new Panel();
            bt_voltar = new Button();
            label8 = new Label();
            gb_status = new GroupBox();
            rb_simS = new RadioButton();
            rb_naoS = new RadioButton();
            txb_InfoAdicional = new TextBox();
            label7 = new Label();
            lbl_nome = new Label();
            tbx_nome = new TextBox();
            txb_CEP = new TextBox();
            lbl_email = new Label();
            label6 = new Label();
            tbx_email = new TextBox();
            txb_Estado = new TextBox();
            lb_CNPJ = new Label();
            label5 = new Label();
            tbx_CNPJ = new TextBox();
            txb_Cidade = new TextBox();
            lb_RazaoSocial = new Label();
            label4 = new Label();
            txb_RazaoSocial = new TextBox();
            txb_Bairro = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txb_Endereco = new TextBox();
            txb_Numero = new TextBox();
            label2 = new Label();
            label9 = new Label();
            tbx_fone1 = new TextBox();
            tbx_fone2 = new TextBox();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gb_status.SuspendLayout();
            SuspendLayout();
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(7, 30, 34);
            barraLateral.Controls.Add(pl_editar);
            barraLateral.Controls.Add(pl_confirmar);
            barraLateral.Controls.Add(pl_cancelar);
            barraLateral.Dock = DockStyle.Bottom;
            barraLateral.FlowDirection = FlowDirection.RightToLeft;
            barraLateral.Location = new Point(0, 491);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(850, 62);
            barraLateral.TabIndex = 20;
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(674, 5);
            pl_editar.Margin = new Padding(3, 5, 3, 5);
            pl_editar.Name = "pl_editar";
            pl_editar.Padding = new Padding(0, 0, 0, 10);
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
            // pl_confirmar
            // 
            pl_confirmar.Anchor = AnchorStyles.Right;
            pl_confirmar.Controls.Add(btn_confirmar);
            pl_confirmar.Location = new Point(495, 5);
            pl_confirmar.Margin = new Padding(3, 5, 3, 5);
            pl_confirmar.Name = "pl_confirmar";
            pl_confirmar.Padding = new Padding(0, 0, 0, 10);
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
            // pl_cancelar
            // 
            pl_cancelar.Anchor = AnchorStyles.Right;
            pl_cancelar.Controls.Add(btn_cancelar);
            pl_cancelar.Location = new Point(316, 5);
            pl_cancelar.Margin = new Padding(3, 5, 3, 5);
            pl_cancelar.Name = "pl_cancelar";
            pl_cancelar.Padding = new Padding(0, 0, 0, 10);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 30, 34);
            panel2.Controls.Add(lbl_funcao);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 69);
            panel2.TabIndex = 21;
            // 
            // lbl_funcao
            // 
            lbl_funcao.AutoSize = true;
            lbl_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_funcao.Location = new Point(374, 20);
            lbl_funcao.Name = "lbl_funcao";
            lbl_funcao.Size = new Size(119, 29);
            lbl_funcao.TabIndex = 8;
            lbl_funcao.Text = "Função:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(bt_voltar);
            panel3.Location = new Point(23, 15);
            panel3.Margin = new Padding(3, 5, 3, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(134, 42);
            panel3.TabIndex = 20;
            // 
            // bt_voltar
            // 
            bt_voltar.BackColor = Color.FromArgb(7, 30, 34);
            bt_voltar.FlatStyle = FlatStyle.Flat;
            bt_voltar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_voltar.ForeColor = SystemColors.ButtonHighlight;
            bt_voltar.Image = (Image)resources.GetObject("bt_voltar.Image");
            bt_voltar.Location = new Point(0, 0);
            bt_voltar.Margin = new Padding(3, 3, 3323, 10);
            bt_voltar.Name = "bt_voltar";
            bt_voltar.Size = new Size(134, 42);
            bt_voltar.TabIndex = 15;
            bt_voltar.Text = "Voltar";
            bt_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_voltar.UseVisualStyleBackColor = false;
            bt_voltar.Click += bt_voltar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 433);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 72;
            label8.Text = "Status:";
            // 
            // gb_status
            // 
            gb_status.Controls.Add(rb_simS);
            gb_status.Controls.Add(rb_naoS);
            gb_status.Location = new Point(143, 426);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(162, 32);
            gb_status.TabIndex = 71;
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
            // txb_InfoAdicional
            // 
            txb_InfoAdicional.BorderStyle = BorderStyle.FixedSingle;
            txb_InfoAdicional.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_InfoAdicional.Location = new Point(302, 393);
            txb_InfoAdicional.MaxLength = 255;
            txb_InfoAdicional.Name = "txb_InfoAdicional";
            txb_InfoAdicional.Size = new Size(500, 27);
            txb_InfoAdicional.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(47, 393);
            label7.Name = "label7";
            label7.Size = new Size(249, 23);
            label7.TabIndex = 69;
            label7.Text = "Informação Adicional:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(47, 154);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(80, 23);
            lbl_nome.TabIndex = 50;
            lbl_nome.Text = "Nome:";
            // 
            // tbx_nome
            // 
            tbx_nome.BorderStyle = BorderStyle.FixedSingle;
            tbx_nome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nome.Location = new Point(133, 150);
            tbx_nome.MaxLength = 255;
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(669, 27);
            tbx_nome.TabIndex = 49;
            // 
            // txb_CEP
            // 
            txb_CEP.BorderStyle = BorderStyle.FixedSingle;
            txb_CEP.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_CEP.Location = new Point(526, 352);
            txb_CEP.MaxLength = 255;
            txb_CEP.Name = "txb_CEP";
            txb_CEP.Size = new Size(276, 27);
            txb_CEP.TabIndex = 68;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(49, 196);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(78, 23);
            lbl_email.TabIndex = 51;
            lbl_email.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(461, 356);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 67;
            label6.Text = "CEP:";
            // 
            // tbx_email
            // 
            tbx_email.BorderStyle = BorderStyle.FixedSingle;
            tbx_email.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_email.Location = new Point(135, 196);
            tbx_email.MaxLength = 255;
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(669, 27);
            tbx_email.TabIndex = 52;
            // 
            // txb_Estado
            // 
            txb_Estado.BorderStyle = BorderStyle.FixedSingle;
            txb_Estado.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Estado.Location = new Point(143, 352);
            txb_Estado.MaxLength = 255;
            txb_Estado.Name = "txb_Estado";
            txb_Estado.Size = new Size(281, 27);
            txb_Estado.TabIndex = 66;
            // 
            // lb_CNPJ
            // 
            lb_CNPJ.AutoSize = true;
            lb_CNPJ.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_CNPJ.Location = new Point(47, 108);
            lb_CNPJ.Name = "lb_CNPJ";
            lb_CNPJ.Size = new Size(73, 23);
            lb_CNPJ.TabIndex = 53;
            lb_CNPJ.Text = "CNPJ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 352);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 65;
            label5.Text = "Estado:";
            // 
            // tbx_CNPJ
            // 
            tbx_CNPJ.BorderStyle = BorderStyle.FixedSingle;
            tbx_CNPJ.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_CNPJ.Location = new Point(133, 108);
            tbx_CNPJ.MaxLength = 255;
            tbx_CNPJ.Name = "tbx_CNPJ";
            tbx_CNPJ.Size = new Size(163, 27);
            tbx_CNPJ.TabIndex = 54;
            // 
            // txb_Cidade
            // 
            txb_Cidade.BorderStyle = BorderStyle.FixedSingle;
            txb_Cidade.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Cidade.Location = new Point(529, 313);
            txb_Cidade.MaxLength = 255;
            txb_Cidade.Name = "txb_Cidade";
            txb_Cidade.Size = new Size(273, 27);
            txb_Cidade.TabIndex = 64;
            // 
            // lb_RazaoSocial
            // 
            lb_RazaoSocial.AutoSize = true;
            lb_RazaoSocial.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_RazaoSocial.Location = new Point(47, 237);
            lb_RazaoSocial.Name = "lb_RazaoSocial";
            lb_RazaoSocial.Size = new Size(155, 23);
            lb_RazaoSocial.TabIndex = 55;
            lb_RazaoSocial.Text = "Razão Social:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 319);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 63;
            label4.Text = "Cidade:";
            // 
            // txb_RazaoSocial
            // 
            txb_RazaoSocial.BorderStyle = BorderStyle.FixedSingle;
            txb_RazaoSocial.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_RazaoSocial.Location = new Point(208, 237);
            txb_RazaoSocial.MaxLength = 255;
            txb_RazaoSocial.Name = "txb_RazaoSocial";
            txb_RazaoSocial.Size = new Size(594, 27);
            txb_RazaoSocial.TabIndex = 56;
            // 
            // txb_Bairro
            // 
            txb_Bairro.BorderStyle = BorderStyle.FixedSingle;
            txb_Bairro.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Bairro.Location = new Point(136, 313);
            txb_Bairro.MaxLength = 255;
            txb_Bairro.Name = "txb_Bairro";
            txb_Bairro.Size = new Size(288, 27);
            txb_Bairro.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 277);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 57;
            label1.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 315);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 61;
            label3.Text = "Bairro:";
            // 
            // txb_Endereco
            // 
            txb_Endereco.BorderStyle = BorderStyle.FixedSingle;
            txb_Endereco.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Endereco.Location = new Point(170, 277);
            txb_Endereco.MaxLength = 255;
            txb_Endereco.Name = "txb_Endereco";
            txb_Endereco.Size = new Size(498, 27);
            txb_Endereco.TabIndex = 58;
            // 
            // txb_Numero
            // 
            txb_Numero.BorderStyle = BorderStyle.FixedSingle;
            txb_Numero.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Numero.Location = new Point(725, 279);
            txb_Numero.MaxLength = 255;
            txb_Numero.Name = "txb_Numero";
            txb_Numero.Size = new Size(77, 27);
            txb_Numero.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(674, 281);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 59;
            label2.Text = "N°:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(316, 433);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 73;
            label9.Text = "Telefone:";
            // 
            // tbx_fone1
            // 
            tbx_fone1.BorderStyle = BorderStyle.FixedSingle;
            tbx_fone1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_fone1.Location = new Point(432, 433);
            tbx_fone1.MaxLength = 255;
            tbx_fone1.Name = "tbx_fone1";
            tbx_fone1.Size = new Size(139, 27);
            tbx_fone1.TabIndex = 74;
            // 
            // tbx_fone2
            // 
            tbx_fone2.BorderStyle = BorderStyle.FixedSingle;
            tbx_fone2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_fone2.Location = new Point(580, 433);
            tbx_fone2.MaxLength = 255;
            tbx_fone2.Name = "tbx_fone2";
            tbx_fone2.Size = new Size(139, 27);
            tbx_fone2.TabIndex = 75;
            // 
            // Form_VerVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(850, 553);
            Controls.Add(tbx_fone2);
            Controls.Add(tbx_fone1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(gb_status);
            Controls.Add(txb_InfoAdicional);
            Controls.Add(label7);
            Controls.Add(lbl_nome);
            Controls.Add(tbx_nome);
            Controls.Add(txb_CEP);
            Controls.Add(lbl_email);
            Controls.Add(label6);
            Controls.Add(tbx_email);
            Controls.Add(txb_Estado);
            Controls.Add(lb_CNPJ);
            Controls.Add(label5);
            Controls.Add(tbx_CNPJ);
            Controls.Add(txb_Cidade);
            Controls.Add(lb_RazaoSocial);
            Controls.Add(label4);
            Controls.Add(txb_RazaoSocial);
            Controls.Add(txb_Bairro);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txb_Endereco);
            Controls.Add(txb_Numero);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(barraLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_VerVendas";
            Text = "Form_VerVendas";
            Load += Form_VerVendas_Load;
            barraLateral.ResumeLayout(false);
            pl_editar.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            gb_status.ResumeLayout(false);
            gb_status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel barraLateral;
        private Panel pl_editar;
        private Button btn_editar;
        private Panel pl_confirmar;
        private Button btn_confirmar;
        private Panel pl_cancelar;
        private Button btn_cancelar;
        private Panel panel2;
        private Label lbl_funcao;
        private Panel panel3;
        private Button bt_voltar;
        private Label label8;
        private GroupBox gb_status;
        private RadioButton rb_simS;
        private RadioButton rb_naoS;
        private TextBox txb_InfoAdicional;
        private Label label7;
        private Label lbl_nome;
        private TextBox tbx_nome;
        private TextBox txb_CEP;
        private Label lbl_email;
        private Label label6;
        private TextBox tbx_email;
        private TextBox txb_Estado;
        private Label lb_CNPJ;
        private Label label5;
        private TextBox tbx_CNPJ;
        private TextBox txb_Cidade;
        private Label lb_RazaoSocial;
        private Label label4;
        private TextBox txb_RazaoSocial;
        private TextBox txb_Bairro;
        private Label label1;
        private Label label3;
        private TextBox txb_Endereco;
        private TextBox txb_Numero;
        private Label label2;
        private Label label9;
        private TextBox tbx_fone1;
        private TextBox tbx_fone2;
    }
}