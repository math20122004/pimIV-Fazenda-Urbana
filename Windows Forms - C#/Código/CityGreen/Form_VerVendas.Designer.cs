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
            label8 = new Label();
            gb_status = new GroupBox();
            rb_Cancelado = new RadioButton();
            rb_Andamento = new RadioButton();
            rb_Entregue = new RadioButton();
            txb_InfoAdicional = new TextBox();
            label7 = new Label();
            lbl_numero = new Label();
            tbx_numero = new TextBox();
            lbl_cliente = new Label();
            lb_CNPJ = new Label();
            tbx_ID = new TextBox();
            dgw_Insumo = new DataGridView();
            col_CNPJFornecedor = new DataGridViewTextBoxColumn();
            col_NomeProduto = new DataGridViewTextBoxColumn();
            col_Quantidade = new DataGridViewTextBoxColumn();
            col_lote = new DataGridViewTextBoxColumn();
            col_Valor = new DataGridViewTextBoxColumn();
            col_Retirar = new DataGridViewButtonColumn();
            btn_Adicionar = new Button();
            cbx_ItensCompra = new ComboBox();
            nud_Quantidade = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txb_valor = new TextBox();
            cbx_Cliente = new ComboBox();
            label1 = new Label();
            lblMensagem = new Label();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gb_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade).BeginInit();
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
            barraLateral.Size = new Size(858, 62);
            barraLateral.TabIndex = 20;
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(682, 5);
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
            pl_confirmar.Location = new Point(503, 5);
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
            pl_cancelar.Location = new Point(324, 5);
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
            label8.Location = new Point(292, 87);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 72;
            label8.Text = "Status:";
            // 
            // gb_status
            // 
            gb_status.Controls.Add(rb_Cancelado);
            gb_status.Controls.Add(rb_Andamento);
            gb_status.Controls.Add(rb_Entregue);
            gb_status.Location = new Point(384, 83);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(454, 32);
            gb_status.TabIndex = 71;
            gb_status.TabStop = false;
            gb_status.Enter += gb_status_Enter;
            // 
            // rb_Cancelado
            // 
            rb_Cancelado.AutoSize = true;
            rb_Cancelado.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Cancelado.Location = new Point(298, 7);
            rb_Cancelado.Name = "rb_Cancelado";
            rb_Cancelado.Size = new Size(117, 22);
            rb_Cancelado.TabIndex = 22;
            rb_Cancelado.TabStop = true;
            rb_Cancelado.Text = "Cancelado";
            rb_Cancelado.UseVisualStyleBackColor = true;
            // 
            // rb_Andamento
            // 
            rb_Andamento.AutoSize = true;
            rb_Andamento.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Andamento.Location = new Point(6, 8);
            rb_Andamento.Name = "rb_Andamento";
            rb_Andamento.Size = new Size(158, 22);
            rb_Andamento.TabIndex = 20;
            rb_Andamento.TabStop = true;
            rb_Andamento.Text = "Em andamento";
            rb_Andamento.UseVisualStyleBackColor = true;
            // 
            // rb_Entregue
            // 
            rb_Entregue.AutoSize = true;
            rb_Entregue.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Entregue.Location = new Point(176, 7);
            rb_Entregue.Name = "rb_Entregue";
            rb_Entregue.Size = new Size(107, 22);
            rb_Entregue.TabIndex = 21;
            rb_Entregue.TabStop = true;
            rb_Entregue.Text = "Entregue";
            rb_Entregue.UseVisualStyleBackColor = true;
            // 
            // txb_InfoAdicional
            // 
            txb_InfoAdicional.BorderStyle = BorderStyle.FixedSingle;
            txb_InfoAdicional.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_InfoAdicional.Location = new Point(302, 212);
            txb_InfoAdicional.MaxLength = 255;
            txb_InfoAdicional.Name = "txb_InfoAdicional";
            txb_InfoAdicional.Size = new Size(500, 27);
            txb_InfoAdicional.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(47, 212);
            label7.Name = "label7";
            label7.Size = new Size(249, 23);
            label7.TabIndex = 69;
            label7.Text = "Informação Adicional:";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_numero.Location = new Point(47, 129);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(103, 23);
            lbl_numero.TabIndex = 50;
            lbl_numero.Text = "Numero:";
            // 
            // tbx_numero
            // 
            tbx_numero.BorderStyle = BorderStyle.FixedSingle;
            tbx_numero.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_numero.Location = new Point(156, 125);
            tbx_numero.MaxLength = 255;
            tbx_numero.Name = "tbx_numero";
            tbx_numero.Size = new Size(364, 27);
            tbx_numero.TabIndex = 49;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cliente.Location = new Point(49, 171);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(87, 23);
            lbl_cliente.TabIndex = 51;
            lbl_cliente.Text = "Cliente";
            // 
            // lb_CNPJ
            // 
            lb_CNPJ.AutoSize = true;
            lb_CNPJ.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_CNPJ.Location = new Point(47, 83);
            lb_CNPJ.Name = "lb_CNPJ";
            lb_CNPJ.Size = new Size(44, 23);
            lb_CNPJ.TabIndex = 53;
            lb_CNPJ.Text = "ID:";
            // 
            // tbx_ID
            // 
            tbx_ID.BorderStyle = BorderStyle.FixedSingle;
            tbx_ID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ID.Location = new Point(97, 83);
            tbx_ID.MaxLength = 255;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(163, 27);
            tbx_ID.TabIndex = 54;
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
            dgw_Insumo.Columns.AddRange(new DataGridViewColumn[] { col_CNPJFornecedor, col_NomeProduto, col_Quantidade, col_lote, col_Valor, col_Retirar });
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
            dgw_Insumo.Location = new Point(47, 360);
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
            dgw_Insumo.Size = new Size(682, 123);
            dgw_Insumo.TabIndex = 76;
            // 
            // col_CNPJFornecedor
            // 
            col_CNPJFornecedor.HeaderText = "CNPJ";
            col_CNPJFornecedor.Name = "col_CNPJFornecedor";
            col_CNPJFornecedor.ReadOnly = true;
            col_CNPJFornecedor.Width = 102;
            // 
            // col_NomeProduto
            // 
            col_NomeProduto.HeaderText = "Nome";
            col_NomeProduto.Name = "col_NomeProduto";
            col_NomeProduto.ReadOnly = true;
            col_NomeProduto.Resizable = DataGridViewTriState.True;
            col_NomeProduto.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_NomeProduto.Width = 260;
            // 
            // col_Quantidade
            // 
            col_Quantidade.FillWeight = 60F;
            col_Quantidade.HeaderText = "Quantidade";
            col_Quantidade.Name = "col_Quantidade";
            col_Quantidade.ReadOnly = true;
            col_Quantidade.Width = 60;
            // 
            // col_lote
            // 
            col_lote.FillWeight = 60F;
            col_lote.HeaderText = "Lote";
            col_lote.Name = "col_lote";
            col_lote.ReadOnly = true;
            col_lote.Resizable = DataGridViewTriState.True;
            col_lote.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_lote.Width = 60;
            // 
            // col_Valor
            // 
            col_Valor.HeaderText = "Valor";
            col_Valor.Name = "col_Valor";
            col_Valor.ReadOnly = true;
            // 
            // col_Retirar
            // 
            col_Retirar.HeaderText = "Retirar";
            col_Retirar.Name = "col_Retirar";
            col_Retirar.ReadOnly = true;
            col_Retirar.Resizable = DataGridViewTriState.True;
            col_Retirar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Adicionar.FlatStyle = FlatStyle.Flat;
            btn_Adicionar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Adicionar.ForeColor = SystemColors.ButtonHighlight;
            btn_Adicionar.Image = (Image)resources.GetObject("btn_Adicionar.Image");
            btn_Adicionar.Location = new Point(558, 312);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(173, 42);
            btn_Adicionar.TabIndex = 77;
            btn_Adicionar.Text = "Adicionar:";
            btn_Adicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Adicionar.UseVisualStyleBackColor = false;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // cbx_ItensCompra
            // 
            cbx_ItensCompra.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_ItensCompra.FormattingEnabled = true;
            cbx_ItensCompra.Location = new Point(154, 286);
            cbx_ItensCompra.Name = "cbx_ItensCompra";
            cbx_ItensCompra.Size = new Size(377, 26);
            cbx_ItensCompra.TabIndex = 78;
            // 
            // nud_Quantidade
            // 
            nud_Quantidade.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Quantidade.Location = new Point(196, 321);
            nud_Quantidade.Name = "nud_Quantidade";
            nud_Quantidade.Size = new Size(76, 27);
            nud_Quantidade.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(45, 286);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 80;
            label10.Text = "Produto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(47, 322);
            label11.Name = "label11";
            label11.Size = new Size(143, 23);
            label11.TabIndex = 81;
            label11.Text = "Quantidade:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(283, 322);
            label12.Name = "label12";
            label12.Size = new Size(75, 23);
            label12.TabIndex = 82;
            label12.Text = "Valor:";
            // 
            // txb_valor
            // 
            txb_valor.BorderStyle = BorderStyle.FixedSingle;
            txb_valor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_valor.Location = new Point(364, 321);
            txb_valor.MaxLength = 255;
            txb_valor.Name = "txb_valor";
            txb_valor.PlaceholderText = "0.00";
            txb_valor.Size = new Size(62, 27);
            txb_valor.TabIndex = 83;
            // 
            // cbx_Cliente
            // 
            cbx_Cliente.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_Cliente.FormattingEnabled = true;
            cbx_Cliente.Location = new Point(143, 172);
            cbx_Cliente.Name = "cbx_Cliente";
            cbx_Cliente.Size = new Size(377, 26);
            cbx_Cliente.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 256);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 85;
            label1.Text = "Itens Venda:";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(196, 420);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(393, 25);
            lblMensagem.TabIndex = 86;
            lblMensagem.Text = "Itens da Venda não encontrados";
            // 
            // Form_VerVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(lblMensagem);
            Controls.Add(label1);
            Controls.Add(cbx_Cliente);
            Controls.Add(txb_valor);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(nud_Quantidade);
            Controls.Add(cbx_ItensCompra);
            Controls.Add(btn_Adicionar);
            Controls.Add(dgw_Insumo);
            Controls.Add(label8);
            Controls.Add(gb_status);
            Controls.Add(txb_InfoAdicional);
            Controls.Add(label7);
            Controls.Add(lbl_numero);
            Controls.Add(tbx_numero);
            Controls.Add(lbl_cliente);
            Controls.Add(lb_CNPJ);
            Controls.Add(tbx_ID);
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
            ((System.ComponentModel.ISupportInitialize)dgw_Insumo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade).EndInit();
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
        private RadioButton rb_Andamento;
        private RadioButton rb_Entregue;
        private TextBox txb_InfoAdicional;
        private Label label7;
        private Label lbl_numero;
        private TextBox tbx_numero;
        private Label lbl_cliente;
        private Label lb_CNPJ;
        private TextBox tbx_ID;
        private DataGridView dgw_Insumo;
        private Button btn_Adicionar;
        private ComboBox cbx_ItensCompra;
        private NumericUpDown nud_Quantidade;
        private Label label10;
        private Label label11;
        private DataGridViewTextBoxColumn col_CNPJFornecedor;
        private DataGridViewTextBoxColumn col_NomeProduto;
        private DataGridViewTextBoxColumn col_Quantidade;
        private DataGridViewTextBoxColumn col_lote;
        private DataGridViewTextBoxColumn col_Valor;
        private DataGridViewButtonColumn col_Retirar;
        private Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txb_valor;
        private ComboBox cbx_Cliente;
        private RadioButton rb_Cancelado;
        private Label label1;
        private Label lblMensagem;
    }
}