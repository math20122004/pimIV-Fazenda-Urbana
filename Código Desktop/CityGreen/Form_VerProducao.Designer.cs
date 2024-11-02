namespace CityGreen
{
    partial class Form_VerProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerProducao));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel2 = new Panel();
            lbl_funcao = new Label();
            panel3 = new Panel();
            bt_voltar = new Button();
            barraLateral = new FlowLayoutPanel();
            pl_editar = new Panel();
            btn_editar = new Button();
            pl_confirmar = new Panel();
            btn_confirmar = new Button();
            pl_cancelar = new Panel();
            btn_cancelar = new Button();
            panel5 = new Panel();
            date_Fim = new DateTimePicker();
            label1 = new Label();
            date_inicio = new DateTimePicker();
            lbl_datavalidade = new Label();
            label8 = new Label();
            gb_status = new GroupBox();
            rb_ativa = new RadioButton();
            rb_Completa = new RadioButton();
            rb_Cancelado = new RadioButton();
            Produto = new Label();
            tbx_produto = new TextBox();
            tbx_ID = new TextBox();
            panel1 = new Panel();
            lblMensagem1 = new Label();
            label11 = new Label();
            label10 = new Label();
            nud_Quantidade = new NumericUpDown();
            cbx_Insumo = new ComboBox();
            btn_Adicionar = new Button();
            dgw_Insumo2 = new DataGridView();
            col_IDInsumo = new DataGridViewTextBoxColumn();
            col_NomeInsumo = new DataGridViewTextBoxColumn();
            col_Quantidade = new DataGridViewTextBoxColumn();
            col_Retirar = new DataGridViewButtonColumn();
            pn_Insumo = new Panel();
            label3 = new Label();
            lbl_Mensagem2 = new Label();
            dgw_Lote = new DataGridView();
            col_IDLote = new DataGridViewTextBoxColumn();
            col_Produto = new DataGridViewTextBoxColumn();
            col_QuantidadeLote = new DataGridViewTextBoxColumn();
            col_data = new DataGridViewTextBoxColumn();
            col_VerLote = new DataGridViewButtonColumn();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisarLotes = new TextBox();
            btn_CadastrarLote = new Button();
            btn_RecarregarLotes = new Button();
            lb_ID = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel5.SuspendLayout();
            gb_status.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo2).BeginInit();
            pn_Insumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Lote).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 30, 34);
            panel2.Controls.Add(lbl_funcao);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 69);
            panel2.TabIndex = 22;
            // 
            // lbl_funcao
            // 
            lbl_funcao.AutoSize = true;
            lbl_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_funcao.Location = new Point(303, 16);
            lbl_funcao.Name = "lbl_funcao";
            lbl_funcao.Size = new Size(119, 29);
            lbl_funcao.TabIndex = 8;
            lbl_funcao.Text = "Função:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(bt_voltar);
            panel3.Location = new Point(22, 11);
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
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(7, 30, 34);
            barraLateral.Controls.Add(pl_editar);
            barraLateral.Controls.Add(pl_confirmar);
            barraLateral.Controls.Add(pl_cancelar);
            barraLateral.Dock = DockStyle.Bottom;
            barraLateral.FlowDirection = FlowDirection.RightToLeft;
            barraLateral.Location = new Point(0, 703);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(837, 62);
            barraLateral.TabIndex = 23;
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(661, 5);
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
            pl_confirmar.Location = new Point(482, 5);
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
            pl_cancelar.Location = new Point(303, 5);
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
            // panel5
            // 
            panel5.Controls.Add(date_Fim);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(date_inicio);
            panel5.Controls.Add(lbl_datavalidade);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(gb_status);
            panel5.Controls.Add(Produto);
            panel5.Controls.Add(tbx_produto);
            panel5.Controls.Add(lb_ID);
            panel5.Controls.Add(tbx_ID);
            panel5.Location = new Point(0, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(837, 215);
            panel5.TabIndex = 47;
            // 
            // date_Fim
            // 
            date_Fim.CalendarFont = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_Fim.CustomFormat = "dd/MM/yyyy";
            date_Fim.Format = DateTimePickerFormat.Custom;
            date_Fim.Location = new Point(224, 140);
            date_Fim.Name = "date_Fim";
            date_Fim.RightToLeft = RightToLeft.No;
            date_Fim.Size = new Size(96, 23);
            date_Fim.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 140);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 106;
            label1.Text = "Data de Fim:";
            // 
            // date_inicio
            // 
            date_inicio.CalendarFont = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_inicio.CustomFormat = "dd/MM/yyyy";
            date_inicio.Format = DateTimePickerFormat.Custom;
            date_inicio.Location = new Point(224, 97);
            date_inicio.Name = "date_inicio";
            date_inicio.RightToLeft = RightToLeft.No;
            date_inicio.Size = new Size(96, 23);
            date_inicio.TabIndex = 59;
            // 
            // lbl_datavalidade
            // 
            lbl_datavalidade.AutoSize = true;
            lbl_datavalidade.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_datavalidade.Location = new Point(40, 97);
            lbl_datavalidade.Name = "lbl_datavalidade";
            lbl_datavalidade.Size = new Size(171, 23);
            lbl_datavalidade.TabIndex = 58;
            lbl_datavalidade.Text = "Data de Inicio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 183);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 48;
            label8.Text = "Status:";
            // 
            // gb_status
            // 
            gb_status.Controls.Add(rb_ativa);
            gb_status.Controls.Add(rb_Completa);
            gb_status.Controls.Add(rb_Cancelado);
            gb_status.Location = new Point(137, 176);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(336, 32);
            gb_status.TabIndex = 47;
            gb_status.TabStop = false;
            // 
            // rb_ativa
            // 
            rb_ativa.AutoSize = true;
            rb_ativa.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_ativa.Location = new Point(6, 8);
            rb_ativa.Name = "rb_ativa";
            rb_ativa.Size = new Size(70, 22);
            rb_ativa.TabIndex = 109;
            rb_ativa.TabStop = true;
            rb_ativa.Text = "Ativa";
            rb_ativa.UseVisualStyleBackColor = true;
            // 
            // rb_Completa
            // 
            rb_Completa.AutoSize = true;
            rb_Completa.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Completa.Location = new Point(211, 8);
            rb_Completa.Name = "rb_Completa";
            rb_Completa.Size = new Size(109, 22);
            rb_Completa.TabIndex = 108;
            rb_Completa.TabStop = true;
            rb_Completa.Text = "Completa";
            rb_Completa.UseVisualStyleBackColor = true;
            // 
            // rb_Cancelado
            // 
            rb_Cancelado.AutoSize = true;
            rb_Cancelado.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Cancelado.Location = new Point(88, 8);
            rb_Cancelado.Name = "rb_Cancelado";
            rb_Cancelado.Size = new Size(117, 22);
            rb_Cancelado.TabIndex = 21;
            rb_Cancelado.TabStop = true;
            rb_Cancelado.Text = "Cancelada";
            rb_Cancelado.UseVisualStyleBackColor = true;
            // 
            // Produto
            // 
            Produto.AutoSize = true;
            Produto.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produto.Location = new Point(40, 57);
            Produto.Name = "Produto";
            Produto.Size = new Size(103, 23);
            Produto.TabIndex = 22;
            Produto.Text = "Produto:";
            // 
            // tbx_produto
            // 
            tbx_produto.BorderStyle = BorderStyle.FixedSingle;
            tbx_produto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_produto.Location = new Point(149, 53);
            tbx_produto.MaxLength = 255;
            tbx_produto.Name = "tbx_produto";
            tbx_produto.Size = new Size(258, 27);
            tbx_produto.TabIndex = 21;
            // 
            // tbx_ID
            // 
            tbx_ID.BorderStyle = BorderStyle.FixedSingle;
            tbx_ID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ID.Location = new Point(126, 11);
            tbx_ID.MaxLength = 255;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(163, 27);
            tbx_ID.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMensagem1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(nud_Quantidade);
            panel1.Controls.Add(cbx_Insumo);
            panel1.Controls.Add(btn_Adicionar);
            panel1.Controls.Add(dgw_Insumo2);
            panel1.Location = new Point(0, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 191);
            panel1.TabIndex = 48;
            // 
            // lblMensagem1
            // 
            lblMensagem1.AutoSize = true;
            lblMensagem1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem1.ForeColor = Color.Red;
            lblMensagem1.Location = new Point(277, 147);
            lblMensagem1.Name = "lblMensagem1";
            lblMensagem1.Size = new Size(303, 25);
            lblMensagem1.TabIndex = 96;
            lblMensagem1.Text = "Insumo não encontrados";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(128, 47);
            label11.Name = "label11";
            label11.Size = new Size(143, 23);
            label11.TabIndex = 92;
            label11.Text = "Quantidade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(126, 3);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 91;
            label10.Text = "Insumo:";
            // 
            // nud_Quantidade
            // 
            nud_Quantidade.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Quantidade.Location = new Point(277, 46);
            nud_Quantidade.Name = "nud_Quantidade";
            nud_Quantidade.Size = new Size(76, 27);
            nud_Quantidade.TabIndex = 90;
            // 
            // cbx_Insumo
            // 
            cbx_Insumo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_Insumo.FormattingEnabled = true;
            cbx_Insumo.Location = new Point(232, 3);
            cbx_Insumo.Name = "cbx_Insumo";
            cbx_Insumo.Size = new Size(477, 26);
            cbx_Insumo.TabIndex = 89;
            cbx_Insumo.SelectedIndexChanged += cbx_Insumo_SelectedIndexChanged;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Adicionar.FlatStyle = FlatStyle.Flat;
            btn_Adicionar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Adicionar.ForeColor = SystemColors.ButtonHighlight;
            btn_Adicionar.Image = (Image)resources.GetObject("btn_Adicionar.Image");
            btn_Adicionar.Location = new Point(536, 37);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(173, 42);
            btn_Adicionar.TabIndex = 88;
            btn_Adicionar.Text = "Adicionar:";
            btn_Adicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Adicionar.UseVisualStyleBackColor = false;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // dgw_Insumo2
            // 
            dgw_Insumo2.AllowUserToAddRows = false;
            dgw_Insumo2.AllowUserToDeleteRows = false;
            dgw_Insumo2.AllowUserToResizeColumns = false;
            dgw_Insumo2.AllowUserToResizeRows = false;
            dgw_Insumo2.Anchor = AnchorStyles.None;
            dgw_Insumo2.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_Insumo2.BorderStyle = BorderStyle.None;
            dgw_Insumo2.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_Insumo2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_Insumo2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_Insumo2.ColumnHeadersHeight = 50;
            dgw_Insumo2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_Insumo2.Columns.AddRange(new DataGridViewColumn[] { col_IDInsumo, col_NomeInsumo, col_Quantidade, col_Retirar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_Insumo2.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_Insumo2.EnableHeadersVisualStyles = false;
            dgw_Insumo2.GridColor = Color.FromArgb(7, 30, 34);
            dgw_Insumo2.Location = new Point(126, 84);
            dgw_Insumo2.MultiSelect = false;
            dgw_Insumo2.Name = "dgw_Insumo2";
            dgw_Insumo2.ReadOnly = true;
            dgw_Insumo2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_Insumo2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_Insumo2.RowHeadersVisible = false;
            dgw_Insumo2.RowHeadersWidth = 50;
            dgw_Insumo2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_Insumo2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_Insumo2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Insumo2.Size = new Size(582, 104);
            dgw_Insumo2.TabIndex = 87;
            dgw_Insumo2.CellContentClick += dgw_Insumo2_CellContentClick;
            // 
            // col_IDInsumo
            // 
            col_IDInsumo.HeaderText = "Registro";
            col_IDInsumo.Name = "col_IDInsumo";
            col_IDInsumo.ReadOnly = true;
            col_IDInsumo.Width = 102;
            // 
            // col_NomeInsumo
            // 
            col_NomeInsumo.HeaderText = "Nome";
            col_NomeInsumo.Name = "col_NomeInsumo";
            col_NomeInsumo.ReadOnly = true;
            col_NomeInsumo.Resizable = DataGridViewTriState.True;
            col_NomeInsumo.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_NomeInsumo.Width = 260;
            // 
            // col_Quantidade
            // 
            col_Quantidade.FillWeight = 60F;
            col_Quantidade.HeaderText = "Quantidade";
            col_Quantidade.Name = "col_Quantidade";
            col_Quantidade.ReadOnly = true;
            col_Quantidade.Width = 120;
            // 
            // col_Retirar
            // 
            col_Retirar.HeaderText = "Retirar";
            col_Retirar.Name = "col_Retirar";
            col_Retirar.ReadOnly = true;
            col_Retirar.Resizable = DataGridViewTriState.True;
            col_Retirar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // pn_Insumo
            // 
            pn_Insumo.Controls.Add(label3);
            pn_Insumo.Controls.Add(lbl_Mensagem2);
            pn_Insumo.Controls.Add(dgw_Lote);
            pn_Insumo.Controls.Add(panel6);
            pn_Insumo.Controls.Add(btn_CadastrarLote);
            pn_Insumo.Controls.Add(btn_RecarregarLotes);
            pn_Insumo.Location = new Point(0, 477);
            pn_Insumo.Name = "pn_Insumo";
            pn_Insumo.Size = new Size(837, 228);
            pn_Insumo.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 96;
            label3.Text = "Lotes:";
            // 
            // lbl_Mensagem2
            // 
            lbl_Mensagem2.AutoSize = true;
            lbl_Mensagem2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Mensagem2.ForeColor = Color.Red;
            lbl_Mensagem2.Location = new Point(277, 144);
            lbl_Mensagem2.Name = "lbl_Mensagem2";
            lbl_Mensagem2.Size = new Size(309, 25);
            lbl_Mensagem2.TabIndex = 10;
            lbl_Mensagem2.Text = "Nenhum Lote Encontrado";
            // 
            // dgw_Lote
            // 
            dgw_Lote.AllowUserToAddRows = false;
            dgw_Lote.AllowUserToDeleteRows = false;
            dgw_Lote.AllowUserToResizeColumns = false;
            dgw_Lote.AllowUserToResizeRows = false;
            dgw_Lote.Anchor = AnchorStyles.None;
            dgw_Lote.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_Lote.BorderStyle = BorderStyle.None;
            dgw_Lote.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_Lote.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgw_Lote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgw_Lote.ColumnHeadersHeight = 50;
            dgw_Lote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_Lote.Columns.AddRange(new DataGridViewColumn[] { col_IDLote, col_Produto, col_QuantidadeLote, col_data, col_VerLote });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgw_Lote.DefaultCellStyle = dataGridViewCellStyle6;
            dgw_Lote.EnableHeadersVisualStyles = false;
            dgw_Lote.GridColor = Color.FromArgb(7, 30, 34);
            dgw_Lote.Location = new Point(88, 88);
            dgw_Lote.MultiSelect = false;
            dgw_Lote.Name = "dgw_Lote";
            dgw_Lote.ReadOnly = true;
            dgw_Lote.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgw_Lote.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgw_Lote.RowHeadersVisible = false;
            dgw_Lote.RowHeadersWidth = 50;
            dgw_Lote.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgw_Lote.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgw_Lote.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Lote.Size = new Size(700, 130);
            dgw_Lote.TabIndex = 3;
            dgw_Lote.CellContentClick += dgw_Lote_CellContentClick;
            // 
            // col_IDLote
            // 
            col_IDLote.HeaderText = "N°";
            col_IDLote.Name = "col_IDLote";
            col_IDLote.ReadOnly = true;
            col_IDLote.Width = 102;
            // 
            // col_Produto
            // 
            col_Produto.HeaderText = "Produto";
            col_Produto.Name = "col_Produto";
            col_Produto.ReadOnly = true;
            col_Produto.Resizable = DataGridViewTriState.True;
            col_Produto.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_Produto.Width = 260;
            // 
            // col_QuantidadeLote
            // 
            col_QuantidadeLote.FillWeight = 120F;
            col_QuantidadeLote.HeaderText = "Quantidade";
            col_QuantidadeLote.Name = "col_QuantidadeLote";
            col_QuantidadeLote.ReadOnly = true;
            col_QuantidadeLote.Width = 120;
            // 
            // col_data
            // 
            col_data.HeaderText = "Data de Validade";
            col_data.Name = "col_data";
            col_data.ReadOnly = true;
            col_data.Resizable = DataGridViewTriState.True;
            col_data.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col_VerLote
            // 
            col_VerLote.HeaderText = "Ver";
            col_VerLote.Name = "col_VerLote";
            col_VerLote.ReadOnly = true;
            col_VerLote.Resizable = DataGridViewTriState.True;
            col_VerLote.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 30, 34);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(tbx_pequisarLotes);
            panel6.Location = new Point(458, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(315, 42);
            panel6.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbx_pequisarLotes
            // 
            tbx_pequisarLotes.BackColor = Color.FromArgb(7, 30, 34);
            tbx_pequisarLotes.BorderStyle = BorderStyle.None;
            tbx_pequisarLotes.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            tbx_pequisarLotes.ForeColor = SystemColors.Window;
            tbx_pequisarLotes.Location = new Point(3, 9);
            tbx_pequisarLotes.Name = "tbx_pequisarLotes";
            tbx_pequisarLotes.PlaceholderText = "Pesquisar";
            tbx_pequisarLotes.Size = new Size(258, 24);
            tbx_pequisarLotes.TabIndex = 6;
            tbx_pequisarLotes.TextChanged += tbx_pequisarLotes_TextChanged;
            // 
            // btn_CadastrarLote
            // 
            btn_CadastrarLote.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarLote.FlatStyle = FlatStyle.Flat;
            btn_CadastrarLote.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarLote.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarLote.Image = (Image)resources.GetObject("btn_CadastrarLote.Image");
            btn_CadastrarLote.Location = new Point(88, 40);
            btn_CadastrarLote.Name = "btn_CadastrarLote";
            btn_CadastrarLote.Size = new Size(173, 42);
            btn_CadastrarLote.TabIndex = 4;
            btn_CadastrarLote.Text = "Cadastrar ";
            btn_CadastrarLote.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarLote.UseVisualStyleBackColor = false;
            btn_CadastrarLote.Click += btn_CadastrarLote_Click;
            // 
            // btn_RecarregarLotes
            // 
            btn_RecarregarLotes.BackColor = Color.FromArgb(7, 30, 34);
            btn_RecarregarLotes.FlatStyle = FlatStyle.Flat;
            btn_RecarregarLotes.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RecarregarLotes.ForeColor = SystemColors.ButtonHighlight;
            btn_RecarregarLotes.Image = (Image)resources.GetObject("btn_RecarregarLotes.Image");
            btn_RecarregarLotes.Location = new Point(271, 40);
            btn_RecarregarLotes.Name = "btn_RecarregarLotes";
            btn_RecarregarLotes.Size = new Size(181, 42);
            btn_RecarregarLotes.TabIndex = 5;
            btn_RecarregarLotes.Text = "Recarregar";
            btn_RecarregarLotes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RecarregarLotes.UseVisualStyleBackColor = false;
            btn_RecarregarLotes.Click += btn_RecarregarLotes_Click;
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ID.Location = new Point(40, 11);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(44, 23);
            lb_ID.TabIndex = 27;
            lb_ID.Text = "ID:";
            // 
            // Form_VerProducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(837, 765);
            ControlBox = false;
            Controls.Add(pn_Insumo);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(barraLateral);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_VerProducao";
            Text = "Form_VerProducao";
            Load += Form_VerProducao_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            barraLateral.ResumeLayout(false);
            pl_editar.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            gb_status.ResumeLayout(false);
            gb_status.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo2).EndInit();
            pn_Insumo.ResumeLayout(false);
            pn_Insumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Lote).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lbl_funcao;
        private Panel panel3;
        private Button bt_voltar;
        private FlowLayoutPanel barraLateral;
        private Panel pl_editar;
        private Button btn_editar;
        private Panel pl_confirmar;
        private Button btn_confirmar;
        private Panel pl_cancelar;
        private Button btn_cancelar;
        private Panel panel5;
        private TextBox tbx_fone2;
        private TextBox tbx_fone1;
        private Label label9;
        private Label label8;
        private GroupBox gb_status;
        private RadioButton rb_simS;
        private RadioButton rb_Cancelado;
        private TextBox txb_InfoAdicional;
        private Label label7;
        private Label Produto;
        private TextBox tbx_produto;
        private TextBox txb_CEP;
        private Label lbl_email;
        private Label label6;
        private TextBox tbx_email;
        private TextBox txb_Estado;
        private Label label5;
        private TextBox tbx_ID;
        private DateTimePicker date_Fim;
        private Label label1;
        private DateTimePicker date_inicio;
        private Label lbl_datavalidade;
        private RadioButton rb_Completa;
        private Panel panel1;
        private Label lblMensagem1;
        private Label label11;
        private Label label10;
        private NumericUpDown nud_Quantidade;
        private ComboBox cbx_Insumo;
        private Button btn_Adicionar;
        private DataGridView dgw_Insumo2;
        private DataGridViewTextBoxColumn col_IDInsumo;
        private DataGridViewTextBoxColumn col_NomeInsumo;
        private DataGridViewTextBoxColumn col_Quantidade;
        private DataGridViewButtonColumn col_Retirar;
        private Panel pn_Insumo;
        private Label label3;
        private Label lbl_Mensagem2;
        private DataGridView dgw_Lote;
        private Panel panel6;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisarLotes;
        private Button btn_CadastrarLote;
        private Button btn_RecarregarLotes;
        private TextBox txb_Cidade;
        private Label lb_RazaoSocial;
        private Label label4;
        private TextBox txb_RazaoSocial;
        private TextBox txb_Bairro;
        private TextBox txb_Endereco;
        private TextBox txb_Numero;
        private RadioButton rb_ativa;
        private DataGridViewTextBoxColumn col_IDLote;
        private DataGridViewTextBoxColumn col_Produto;
        private DataGridViewTextBoxColumn col_QuantidadeLote;
        private DataGridViewTextBoxColumn col_data;
        private DataGridViewButtonColumn col_VerLote;
        private Label lb_ID;
    }
}