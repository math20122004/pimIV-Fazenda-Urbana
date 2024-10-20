namespace CityGreen
{
    partial class Form_VerFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerFornecedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            tbx_email = new TextBox();
            lbl_email = new Label();
            lbl_nome = new Label();
            tbx_nome = new TextBox();
            tbx_CNPJ = new TextBox();
            lb_CNPJ = new Label();
            txb_RazaoSocial = new TextBox();
            lb_RazaoSocial = new Label();
            label1 = new Label();
            txb_Endereco = new TextBox();
            label2 = new Label();
            txb_Numero = new TextBox();
            txb_Bairro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txb_Cidade = new TextBox();
            txb_Estado = new TextBox();
            label5 = new Label();
            txb_CEP = new TextBox();
            label6 = new Label();
            pn_Insumo = new Panel();
            lbl_Mensagem = new Label();
            dgw_Insumo = new DataGridView();
            col_IDInsumo = new DataGridViewTextBoxColumn();
            col_NomeInsumo = new DataGridViewTextBoxColumn();
            col_Validade = new DataGridViewTextBoxColumn();
            col_data = new DataGridViewTextBoxColumn();
            col_VerInsumo = new DataGridViewButtonColumn();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisarInsumo = new TextBox();
            btn_CadastrarInsumo = new Button();
            btn_RecarregarInsumo = new Button();
            txb_InfoAdicional = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            gb_status = new GroupBox();
            rb_simS = new RadioButton();
            rb_naoS = new RadioButton();
            tbx_fone2 = new TextBox();
            tbx_fone1 = new TextBox();
            label9 = new Label();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pn_Insumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
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
            barraLateral.Location = new Point(0, 723);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(850, 62);
            barraLateral.TabIndex = 19;
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
            panel2.Size = new Size(850, 100);
            panel2.TabIndex = 20;
            // 
            // lbl_funcao
            // 
            lbl_funcao.AutoSize = true;
            lbl_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_funcao.Location = new Point(257, 51);
            lbl_funcao.Name = "lbl_funcao";
            lbl_funcao.Size = new Size(119, 29);
            lbl_funcao.TabIndex = 8;
            lbl_funcao.Text = "Função:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(bt_voltar);
            panel3.Location = new Point(15, 46);
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
            bt_voltar.Click += bt_Voltar_Click;
            // 
            // tbx_email
            // 
            tbx_email.BorderStyle = BorderStyle.FixedSingle;
            tbx_email.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_email.Location = new Point(128, 106);
            tbx_email.MaxLength = 255;
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(669, 27);
            tbx_email.TabIndex = 26;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(42, 106);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(78, 23);
            lbl_email.TabIndex = 25;
            lbl_email.Text = "Email:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(40, 64);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(80, 23);
            lbl_nome.TabIndex = 22;
            lbl_nome.Text = "Nome:";
            // 
            // tbx_nome
            // 
            tbx_nome.BorderStyle = BorderStyle.FixedSingle;
            tbx_nome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nome.Location = new Point(126, 60);
            tbx_nome.MaxLength = 255;
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(669, 27);
            tbx_nome.TabIndex = 21;
            // 
            // tbx_CNPJ
            // 
            tbx_CNPJ.BorderStyle = BorderStyle.FixedSingle;
            tbx_CNPJ.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_CNPJ.Location = new Point(126, 18);
            tbx_CNPJ.MaxLength = 255;
            tbx_CNPJ.Name = "tbx_CNPJ";
            tbx_CNPJ.Size = new Size(163, 27);
            tbx_CNPJ.TabIndex = 28;
            // 
            // lb_CNPJ
            // 
            lb_CNPJ.AutoSize = true;
            lb_CNPJ.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_CNPJ.Location = new Point(40, 18);
            lb_CNPJ.Name = "lb_CNPJ";
            lb_CNPJ.Size = new Size(73, 23);
            lb_CNPJ.TabIndex = 27;
            lb_CNPJ.Text = "CNPJ:";
            // 
            // txb_RazaoSocial
            // 
            txb_RazaoSocial.BorderStyle = BorderStyle.FixedSingle;
            txb_RazaoSocial.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_RazaoSocial.Location = new Point(201, 147);
            txb_RazaoSocial.MaxLength = 255;
            txb_RazaoSocial.Name = "txb_RazaoSocial";
            txb_RazaoSocial.Size = new Size(594, 27);
            txb_RazaoSocial.TabIndex = 30;
            // 
            // lb_RazaoSocial
            // 
            lb_RazaoSocial.AutoSize = true;
            lb_RazaoSocial.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_RazaoSocial.Location = new Point(40, 147);
            lb_RazaoSocial.Name = "lb_RazaoSocial";
            lb_RazaoSocial.Size = new Size(155, 23);
            lb_RazaoSocial.TabIndex = 29;
            lb_RazaoSocial.Text = "Razão Social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 187);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 31;
            label1.Text = "Endereço:";
            // 
            // txb_Endereco
            // 
            txb_Endereco.BorderStyle = BorderStyle.FixedSingle;
            txb_Endereco.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Endereco.Location = new Point(163, 187);
            txb_Endereco.MaxLength = 255;
            txb_Endereco.Name = "txb_Endereco";
            txb_Endereco.Size = new Size(498, 27);
            txb_Endereco.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(667, 191);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 33;
            label2.Text = "N°:";
            // 
            // txb_Numero
            // 
            txb_Numero.BorderStyle = BorderStyle.FixedSingle;
            txb_Numero.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Numero.Location = new Point(718, 189);
            txb_Numero.MaxLength = 255;
            txb_Numero.Name = "txb_Numero";
            txb_Numero.Size = new Size(77, 27);
            txb_Numero.TabIndex = 34;
            // 
            // txb_Bairro
            // 
            txb_Bairro.BorderStyle = BorderStyle.FixedSingle;
            txb_Bairro.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Bairro.Location = new Point(129, 223);
            txb_Bairro.MaxLength = 255;
            txb_Bairro.Name = "txb_Bairro";
            txb_Bairro.Size = new Size(288, 27);
            txb_Bairro.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 225);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 35;
            label3.Text = "Bairro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 229);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 37;
            label4.Text = "Cidade:";
            // 
            // txb_Cidade
            // 
            txb_Cidade.BorderStyle = BorderStyle.FixedSingle;
            txb_Cidade.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Cidade.Location = new Point(522, 223);
            txb_Cidade.MaxLength = 255;
            txb_Cidade.Name = "txb_Cidade";
            txb_Cidade.Size = new Size(273, 27);
            txb_Cidade.TabIndex = 38;
            // 
            // txb_Estado
            // 
            txb_Estado.BorderStyle = BorderStyle.FixedSingle;
            txb_Estado.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Estado.Location = new Point(136, 262);
            txb_Estado.MaxLength = 255;
            txb_Estado.Name = "txb_Estado";
            txb_Estado.Size = new Size(281, 27);
            txb_Estado.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 262);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 39;
            label5.Text = "Estado:";
            // 
            // txb_CEP
            // 
            txb_CEP.BorderStyle = BorderStyle.FixedSingle;
            txb_CEP.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_CEP.Location = new Point(519, 262);
            txb_CEP.MaxLength = 255;
            txb_CEP.Name = "txb_CEP";
            txb_CEP.Size = new Size(276, 27);
            txb_CEP.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 266);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 41;
            label6.Text = "CEP:";
            // 
            // pn_Insumo
            // 
            pn_Insumo.Controls.Add(lbl_Mensagem);
            pn_Insumo.Controls.Add(dgw_Insumo);
            pn_Insumo.Controls.Add(panel6);
            pn_Insumo.Controls.Add(btn_CadastrarInsumo);
            pn_Insumo.Controls.Add(btn_RecarregarInsumo);
            pn_Insumo.Location = new Point(0, 482);
            pn_Insumo.Name = "pn_Insumo";
            pn_Insumo.Size = new Size(850, 240);
            pn_Insumo.TabIndex = 43;
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.AutoSize = true;
            lbl_Mensagem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Mensagem.ForeColor = Color.Red;
            lbl_Mensagem.Location = new Point(227, 117);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(347, 25);
            lbl_Mensagem.TabIndex = 10;
            lbl_Mensagem.Text = "Nenhum Insumo Encontrado";
            // 
            // dgw_Insumo
            // 
            dgw_Insumo.AllowUserToAddRows = false;
            dgw_Insumo.AllowUserToDeleteRows = false;
            dgw_Insumo.AllowUserToResizeColumns = false;
            dgw_Insumo.AllowUserToResizeRows = false;
            dgw_Insumo.Anchor = AnchorStyles.None;
            dgw_Insumo.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_Insumo.BorderStyle = BorderStyle.None;
            dgw_Insumo.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_Insumo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_Insumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_Insumo.ColumnHeadersHeight = 50;
            dgw_Insumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_Insumo.Columns.AddRange(new DataGridViewColumn[] { col_IDInsumo, col_NomeInsumo, col_Validade, col_data, col_VerInsumo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_Insumo.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_Insumo.EnableHeadersVisualStyles = false;
            dgw_Insumo.GridColor = Color.FromArgb(7, 30, 34);
            dgw_Insumo.Location = new Point(90, 60);
            dgw_Insumo.MultiSelect = false;
            dgw_Insumo.Name = "dgw_Insumo";
            dgw_Insumo.ReadOnly = true;
            dgw_Insumo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_Insumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_Insumo.RowHeadersVisible = false;
            dgw_Insumo.RowHeadersWidth = 50;
            dgw_Insumo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_Insumo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_Insumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Insumo.Size = new Size(663, 175);
            dgw_Insumo.TabIndex = 3;
            dgw_Insumo.CellContentClick += dgw_Insumo_CellContentClick;
            // 
            // col_IDInsumo
            // 
            col_IDInsumo.HeaderText = "ID";
            col_IDInsumo.Name = "col_IDInsumo";
            col_IDInsumo.ReadOnly = true;
            col_IDInsumo.Width = 102;
            // 
            // col_NomeInsumo
            // 
            col_NomeInsumo.HeaderText = "Nome:";
            col_NomeInsumo.Name = "col_NomeInsumo";
            col_NomeInsumo.ReadOnly = true;
            col_NomeInsumo.Resizable = DataGridViewTriState.True;
            col_NomeInsumo.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_NomeInsumo.Width = 260;
            // 
            // col_Validade
            // 
            col_Validade.HeaderText = "Validade:";
            col_Validade.Name = "col_Validade";
            col_Validade.ReadOnly = true;
            // 
            // col_data
            // 
            col_data.HeaderText = "Data Validade:";
            col_data.Name = "col_data";
            col_data.ReadOnly = true;
            col_data.Resizable = DataGridViewTriState.True;
            col_data.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col_VerInsumo
            // 
            col_VerInsumo.HeaderText = "Ver";
            col_VerInsumo.Name = "col_VerInsumo";
            col_VerInsumo.ReadOnly = true;
            col_VerInsumo.Resizable = DataGridViewTriState.True;
            col_VerInsumo.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 30, 34);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(tbx_pequisarInsumo);
            panel6.Location = new Point(458, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 42);
            panel6.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbx_pequisarInsumo
            // 
            tbx_pequisarInsumo.BackColor = Color.FromArgb(7, 30, 34);
            tbx_pequisarInsumo.BorderStyle = BorderStyle.None;
            tbx_pequisarInsumo.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            tbx_pequisarInsumo.ForeColor = SystemColors.Window;
            tbx_pequisarInsumo.Location = new Point(3, 9);
            tbx_pequisarInsumo.Name = "tbx_pequisarInsumo";
            tbx_pequisarInsumo.PlaceholderText = "Pesquisar";
            tbx_pequisarInsumo.Size = new Size(238, 24);
            tbx_pequisarInsumo.TabIndex = 6;
            tbx_pequisarInsumo.TextChanged += tbx_pequisarInsumo_TextChanged;
            // 
            // btn_CadastrarInsumo
            // 
            btn_CadastrarInsumo.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarInsumo.FlatStyle = FlatStyle.Flat;
            btn_CadastrarInsumo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarInsumo.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarInsumo.Image = (Image)resources.GetObject("btn_CadastrarInsumo.Image");
            btn_CadastrarInsumo.Location = new Point(88, 11);
            btn_CadastrarInsumo.Name = "btn_CadastrarInsumo";
            btn_CadastrarInsumo.Size = new Size(173, 42);
            btn_CadastrarInsumo.TabIndex = 4;
            btn_CadastrarInsumo.Text = "Cadastrar ";
            btn_CadastrarInsumo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarInsumo.UseVisualStyleBackColor = false;
            btn_CadastrarInsumo.Click += btn_CadastrarInsumo_Click;
            // 
            // btn_RecarregarInsumo
            // 
            btn_RecarregarInsumo.BackColor = Color.FromArgb(7, 30, 34);
            btn_RecarregarInsumo.FlatStyle = FlatStyle.Flat;
            btn_RecarregarInsumo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RecarregarInsumo.ForeColor = SystemColors.ButtonHighlight;
            btn_RecarregarInsumo.Image = (Image)resources.GetObject("btn_RecarregarInsumo.Image");
            btn_RecarregarInsumo.Location = new Point(271, 11);
            btn_RecarregarInsumo.Name = "btn_RecarregarInsumo";
            btn_RecarregarInsumo.Size = new Size(181, 42);
            btn_RecarregarInsumo.TabIndex = 5;
            btn_RecarregarInsumo.Text = "Recarregar";
            btn_RecarregarInsumo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RecarregarInsumo.UseVisualStyleBackColor = false;
            btn_RecarregarInsumo.Click += btn_RecarregarInsumo_Click;
            // 
            // txb_InfoAdicional
            // 
            txb_InfoAdicional.BorderStyle = BorderStyle.FixedSingle;
            txb_InfoAdicional.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_InfoAdicional.Location = new Point(295, 303);
            txb_InfoAdicional.MaxLength = 255;
            txb_InfoAdicional.Name = "txb_InfoAdicional";
            txb_InfoAdicional.Size = new Size(500, 27);
            txb_InfoAdicional.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 303);
            label7.Name = "label7";
            label7.Size = new Size(249, 23);
            label7.TabIndex = 44;
            label7.Text = "Informação Adicional:";
            // 
            // panel5
            // 
            panel5.Controls.Add(tbx_fone2);
            panel5.Controls.Add(tbx_fone1);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(gb_status);
            panel5.Controls.Add(txb_InfoAdicional);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(lbl_nome);
            panel5.Controls.Add(tbx_nome);
            panel5.Controls.Add(txb_CEP);
            panel5.Controls.Add(lbl_email);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(tbx_email);
            panel5.Controls.Add(txb_Estado);
            panel5.Controls.Add(lb_CNPJ);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tbx_CNPJ);
            panel5.Controls.Add(txb_Cidade);
            panel5.Controls.Add(lb_RazaoSocial);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txb_RazaoSocial);
            panel5.Controls.Add(txb_Bairro);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txb_Endereco);
            panel5.Controls.Add(txb_Numero);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(850, 382);
            panel5.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 343);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 48;
            label8.Text = "Status:";
            // 
            // gb_status
            // 
            gb_status.Controls.Add(rb_simS);
            gb_status.Controls.Add(rb_naoS);
            gb_status.Location = new Point(136, 336);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(162, 32);
            gb_status.TabIndex = 47;
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
            // tbx_fone2
            // 
            tbx_fone2.BorderStyle = BorderStyle.FixedSingle;
            tbx_fone2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_fone2.Location = new Point(559, 342);
            tbx_fone2.MaxLength = 255;
            tbx_fone2.Name = "tbx_fone2";
            tbx_fone2.Size = new Size(139, 27);
            tbx_fone2.TabIndex = 105;
            // 
            // tbx_fone1
            // 
            tbx_fone1.BorderStyle = BorderStyle.FixedSingle;
            tbx_fone1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_fone1.Location = new Point(411, 342);
            tbx_fone1.MaxLength = 255;
            tbx_fone1.Name = "tbx_fone1";
            tbx_fone1.Size = new Size(139, 27);
            tbx_fone1.TabIndex = 104;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(295, 342);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 103;
            label9.Text = "Telefone:";
            // 
            // Form_VerFornecedor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(850, 785);
            ControlBox = false;
            Controls.Add(barraLateral);
            Controls.Add(pn_Insumo);
            Controls.Add(panel2);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form_VerFornecedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form_VerFornecedor";
            Load += Form_VerFornecedor_Load;
            barraLateral.ResumeLayout(false);
            pl_editar.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            pn_Insumo.ResumeLayout(false);
            pn_Insumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            gb_status.ResumeLayout(false);
            gb_status.PerformLayout();
            ResumeLayout(false);
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
        private TextBox tbx_email;
        private Label lbl_email;
        private Label lbl_nome;
        private TextBox tbx_nome;
        private TextBox tbx_CNPJ;
        private Label lb_CNPJ;
        private TextBox txb_RazaoSocial;
        private Label lb_RazaoSocial;
        private Label label1;
        private TextBox txb_Endereco;
        private Label label2;
        private TextBox txb_Numero;
        private TextBox txb_Bairro;
        private Label label3;
        private Label label4;
        private TextBox txb_Cidade;
        private TextBox txb_Estado;
        private Label label5;
        private TextBox txb_CEP;
        private Label label6;
        private Panel pn_Insumo;
        private Label lbl_Mensagem;
        private DataGridView dgw_Insumo;
        private Panel panel6;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisarInsumo;
        private Button btn_CadastrarInsumo;
        private Button btn_RecarregarInsumo;
        private TextBox txb_InfoAdicional;
        private Label label7;
        private Panel panel5;
        private DataGridViewTextBoxColumn col_IDInsumo;
        private DataGridViewTextBoxColumn col_NomeInsumo;
        private DataGridViewTextBoxColumn col_Validade;
        private DataGridViewTextBoxColumn col_data;
        private DataGridViewButtonColumn col_VerInsumo;
        private Label label8;
        private GroupBox gb_status;
        private RadioButton rb_simS;
        private RadioButton rb_naoS;
        private TextBox tbx_fone2;
        private TextBox tbx_fone1;
        private Label label9;
    }
}