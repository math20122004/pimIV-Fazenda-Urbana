namespace CityGreen
{
    partial class Form_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
            panel2 = new Panel();
            lblMensagem = new Label();
            dgw_clientes = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisa = new TextBox();
            btn_CadastrarCliente = new Button();
            btn_Recarregar = new Button();
            btn_VerVendas = new Button();
            col_ID = new DataGridViewTextBoxColumn();
            col_Nome = new DataGridViewTextBoxColumn();
            col_Status = new DataGridViewTextBoxColumn();
            col_email = new DataGridViewTextBoxColumn();
            col_VerClientes = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_clientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMensagem);
            panel2.Controls.Add(dgw_clientes);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_CadastrarCliente);
            panel2.Controls.Add(btn_Recarregar);
            panel2.Location = new Point(12, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 461);
            panel2.TabIndex = 11;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(255, 121);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(284, 25);
            lblMensagem.TabIndex = 10;
            lblMensagem.Text = "Cliente não encontrado";
            // 
            // dgw_clientes
            // 
            dgw_clientes.AllowUserToAddRows = false;
            dgw_clientes.AllowUserToDeleteRows = false;
            dgw_clientes.AllowUserToResizeColumns = false;
            dgw_clientes.AllowUserToResizeRows = false;
            dgw_clientes.Anchor = AnchorStyles.None;
            dgw_clientes.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_clientes.BorderStyle = BorderStyle.None;
            dgw_clientes.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_clientes.ColumnHeadersHeight = 50;
            dgw_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_clientes.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Nome, col_Status, col_email, col_VerClientes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_clientes.EnableHeadersVisualStyles = false;
            dgw_clientes.GridColor = Color.FromArgb(7, 30, 34);
            dgw_clientes.Location = new Point(4, 63);
            dgw_clientes.MultiSelect = false;
            dgw_clientes.Name = "dgw_clientes";
            dgw_clientes.ReadOnly = true;
            dgw_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_clientes.RowHeadersVisible = false;
            dgw_clientes.RowHeadersWidth = 50;
            dgw_clientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_clientes.Size = new Size(814, 395);
            dgw_clientes.TabIndex = 3;
            dgw_clientes.CellContentClick += btn_VerClientes_Click;
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
            // btn_CadastrarCliente
            // 
            btn_CadastrarCliente.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarCliente.FlatStyle = FlatStyle.Flat;
            btn_CadastrarCliente.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarCliente.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarCliente.Image = (Image)resources.GetObject("btn_CadastrarCliente.Image");
            btn_CadastrarCliente.Location = new Point(1, 15);
            btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            btn_CadastrarCliente.Size = new Size(173, 42);
            btn_CadastrarCliente.TabIndex = 4;
            btn_CadastrarCliente.Text = "Cadastrar ";
            btn_CadastrarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarCliente.UseVisualStyleBackColor = false;
            btn_CadastrarCliente.Click += btn_CadastrarCliente_Click_1;
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
            // btn_VerVendas
            // 
            btn_VerVendas.BackColor = Color.FromArgb(7, 30, 34);
            btn_VerVendas.FlatStyle = FlatStyle.Flat;
            btn_VerVendas.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerVendas.ForeColor = SystemColors.ButtonHighlight;
            btn_VerVendas.Image = (Image)resources.GetObject("btn_VerVendas.Image");
            btn_VerVendas.Location = new Point(23, 495);
            btn_VerVendas.Name = "btn_VerVendas";
            btn_VerVendas.Size = new Size(190, 42);
            btn_VerVendas.TabIndex = 13;
            btn_VerVendas.Text = "Ver Vendas";
            btn_VerVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_VerVendas.UseVisualStyleBackColor = false;
            btn_VerVendas.Click += btn_VerVendas_Click;
            // 
            // col_ID
            // 
            col_ID.HeaderText = "Registro";
            col_ID.Name = "col_ID";
            col_ID.ReadOnly = true;
            // 
            // col_Nome
            // 
            col_Nome.FillWeight = 230F;
            col_Nome.HeaderText = "Nome:";
            col_Nome.Name = "col_Nome";
            col_Nome.ReadOnly = true;
            col_Nome.Resizable = DataGridViewTriState.True;
            col_Nome.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_Nome.Width = 240;
            // 
            // col_Status
            // 
            col_Status.HeaderText = "Status:";
            col_Status.Name = "col_Status";
            col_Status.ReadOnly = true;
            // 
            // col_email
            // 
            col_email.HeaderText = "Email:";
            col_email.Name = "col_email";
            col_email.ReadOnly = true;
            col_email.Resizable = DataGridViewTriState.True;
            col_email.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_email.Width = 252;
            // 
            // col_VerClientes
            // 
            col_VerClientes.HeaderText = "Ver";
            col_VerClientes.Name = "col_VerClientes";
            col_VerClientes.ReadOnly = true;
            col_VerClientes.Resizable = DataGridViewTriState.True;
            col_VerClientes.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(btn_VerVendas);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Clientes";
            Text = "Form_Clientes";
            Load += Form_Clientes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_clientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblMensagem;
        private DataGridView dgw_clientes;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisa;
        private Button btn_CadastrarCliente;
        private Button btn_Recarregar;
        private Button btn_VerVendas;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Nome;
        private DataGridViewTextBoxColumn col_Status;
        private DataGridViewTextBoxColumn col_email;
        private DataGridViewButtonColumn col_VerClientes;
    }
}