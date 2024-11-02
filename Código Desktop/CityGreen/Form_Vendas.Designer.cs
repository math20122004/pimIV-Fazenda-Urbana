namespace CityGreen
{
    partial class Form_Vendas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendas));
            panel2 = new Panel();
            lblMensagem = new Label();
            dgw_Vendas = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisa = new TextBox();
            btn_CadastrarVendas = new Button();
            btn_Recarregar = new Button();
            btn_VerCliente = new Button();
            col_ID = new DataGridViewTextBoxColumn();
            col_Numero = new DataGridViewTextBoxColumn();
            col_Cliente = new DataGridViewTextBoxColumn();
            col_Status = new DataGridViewTextBoxColumn();
            col_VerVenda = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Vendas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMensagem);
            panel2.Controls.Add(dgw_Vendas);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_CadastrarVendas);
            panel2.Controls.Add(btn_Recarregar);
            panel2.Location = new Point(19, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 463);
            panel2.TabIndex = 11;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(267, 124);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(276, 25);
            lblMensagem.TabIndex = 10;
            lblMensagem.Text = "Venda não encontrado";
            // 
            // dgw_Vendas
            // 
            dgw_Vendas.AllowUserToAddRows = false;
            dgw_Vendas.AllowUserToDeleteRows = false;
            dgw_Vendas.AllowUserToResizeColumns = false;
            dgw_Vendas.AllowUserToResizeRows = false;
            dgw_Vendas.Anchor = AnchorStyles.None;
            dgw_Vendas.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_Vendas.BorderStyle = BorderStyle.None;
            dgw_Vendas.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_Vendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_Vendas.ColumnHeadersHeight = 50;
            dgw_Vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_Vendas.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Numero, col_Cliente, col_Status, col_VerVenda });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_Vendas.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_Vendas.EnableHeadersVisualStyles = false;
            dgw_Vendas.GridColor = Color.FromArgb(7, 30, 34);
            dgw_Vendas.Location = new Point(3, 61);
            dgw_Vendas.MultiSelect = false;
            dgw_Vendas.Name = "dgw_Vendas";
            dgw_Vendas.ReadOnly = true;
            dgw_Vendas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_Vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_Vendas.RowHeadersVisible = false;
            dgw_Vendas.RowHeadersWidth = 50;
            dgw_Vendas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_Vendas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_Vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Vendas.Size = new Size(814, 399);
            dgw_Vendas.TabIndex = 3;
            dgw_Vendas.CellContentClick += btn_verInsumo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbx_pequisa);
            panel1.Location = new Point(369, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 42);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbx_pequisa
            // 
            tbx_pequisa.BackColor = Color.FromArgb(7, 30, 34);
            tbx_pequisa.BorderStyle = BorderStyle.None;
            tbx_pequisa.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            tbx_pequisa.ForeColor = SystemColors.Window;
            tbx_pequisa.Location = new Point(3, 9);
            tbx_pequisa.Name = "tbx_pequisa";
            tbx_pequisa.PlaceholderText = "Pesquisar";
            tbx_pequisa.Size = new Size(391, 24);
            tbx_pequisa.TabIndex = 6;
            tbx_pequisa.TextChanged += tbx_pequisa_TextChanged;
            // 
            // btn_CadastrarVendas
            // 
            btn_CadastrarVendas.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarVendas.FlatStyle = FlatStyle.Flat;
            btn_CadastrarVendas.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarVendas.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarVendas.Image = (Image)resources.GetObject("btn_CadastrarVendas.Image");
            btn_CadastrarVendas.Location = new Point(1, 15);
            btn_CadastrarVendas.Name = "btn_CadastrarVendas";
            btn_CadastrarVendas.Size = new Size(173, 42);
            btn_CadastrarVendas.TabIndex = 4;
            btn_CadastrarVendas.Text = "Cadastrar ";
            btn_CadastrarVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarVendas.UseVisualStyleBackColor = false;
            btn_CadastrarVendas.Click += btn_CadastrarVendas_Click;
            // 
            // btn_Recarregar
            // 
            btn_Recarregar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Recarregar.FlatStyle = FlatStyle.Flat;
            btn_Recarregar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Recarregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Recarregar.Image = (Image)resources.GetObject("btn_Recarregar.Image");
            btn_Recarregar.Location = new Point(182, 15);
            btn_Recarregar.Name = "btn_Recarregar";
            btn_Recarregar.Size = new Size(181, 42);
            btn_Recarregar.TabIndex = 5;
            btn_Recarregar.Text = "Recarregar";
            btn_Recarregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Recarregar.UseVisualStyleBackColor = false;
            btn_Recarregar.Click += btn_Recarregar_Click;
            // 
            // btn_VerCliente
            // 
            btn_VerCliente.BackColor = Color.FromArgb(7, 30, 34);
            btn_VerCliente.FlatStyle = FlatStyle.Flat;
            btn_VerCliente.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerCliente.ForeColor = SystemColors.ButtonHighlight;
            btn_VerCliente.Image = (Image)resources.GetObject("btn_VerCliente.Image");
            btn_VerCliente.Location = new Point(646, 499);
            btn_VerCliente.Name = "btn_VerCliente";
            btn_VerCliente.Size = new Size(190, 42);
            btn_VerCliente.TabIndex = 12;
            btn_VerCliente.Text = "Ver Clientes";
            btn_VerCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_VerCliente.UseVisualStyleBackColor = false;
            btn_VerCliente.Click += btn_VerCliente_Click;
            // 
            // col_ID
            // 
            col_ID.HeaderText = "Registro:";
            col_ID.Name = "col_ID";
            col_ID.ReadOnly = true;
            col_ID.Width = 120;
            // 
            // col_Numero
            // 
            col_Numero.HeaderText = "Numero:";
            col_Numero.Name = "col_Numero";
            col_Numero.ReadOnly = true;
            col_Numero.Resizable = DataGridViewTriState.True;
            col_Numero.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_Numero.Width = 170;
            // 
            // col_Cliente
            // 
            col_Cliente.HeaderText = "Cliente";
            col_Cliente.Name = "col_Cliente";
            col_Cliente.ReadOnly = true;
            col_Cliente.Resizable = DataGridViewTriState.True;
            col_Cliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_Cliente.Width = 282;
            // 
            // col_Status
            // 
            col_Status.HeaderText = "Status:";
            col_Status.Name = "col_Status";
            col_Status.ReadOnly = true;
            col_Status.Width = 140;
            // 
            // col_VerVenda
            // 
            col_VerVenda.HeaderText = "Ver";
            col_VerVenda.Name = "col_VerVenda";
            col_VerVenda.ReadOnly = true;
            col_VerVenda.Resizable = DataGridViewTriState.True;
            col_VerVenda.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(btn_VerCliente);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Vendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FM_Vendas";
            WindowState = FormWindowState.Maximized;
            Load += Form_Vendas_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Vendas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblMensagem;
        private DataGridView dgw_Vendas;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisa;
        private Button btn_CadastrarVendas;
        private Button btn_Recarregar;
        private Button btn_VerCliente;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Numero;
        private DataGridViewTextBoxColumn col_Cliente;
        private DataGridViewTextBoxColumn col_Status;
        private DataGridViewButtonColumn col_VerVenda;
    }
}