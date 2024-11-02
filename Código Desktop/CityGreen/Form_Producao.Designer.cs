namespace CityGreen
{
    partial class Form_Producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Producao));
            panel2 = new Panel();
            lblMensagem = new Label();
            dgw_producao = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisa = new TextBox();
            btn_CadastrarFornecedor = new Button();
            btn_Recarregar = new Button();
            col_ID = new DataGridViewTextBoxColumn();
            col_Produto = new DataGridViewTextBoxColumn();
            col_inicio = new DataGridViewTextBoxColumn();
            Col_Fim = new DataGridViewTextBoxColumn();
            col_Status = new DataGridViewTextBoxColumn();
            col_VerProducao = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_producao).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMensagem);
            panel2.Controls.Add(dgw_producao);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_CadastrarFornecedor);
            panel2.Controls.Add(btn_Recarregar);
            panel2.Location = new Point(19, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 511);
            panel2.TabIndex = 11;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(270, 117);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(276, 25);
            lblMensagem.TabIndex = 10;
            lblMensagem.Text = "Venda não encontrado";
            // 
            // dgw_producao
            // 
            dgw_producao.AllowUserToAddRows = false;
            dgw_producao.AllowUserToDeleteRows = false;
            dgw_producao.AllowUserToResizeColumns = false;
            dgw_producao.AllowUserToResizeRows = false;
            dgw_producao.Anchor = AnchorStyles.None;
            dgw_producao.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_producao.BorderStyle = BorderStyle.None;
            dgw_producao.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_producao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_producao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_producao.ColumnHeadersHeight = 50;
            dgw_producao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_producao.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Produto, col_inicio, Col_Fim, col_Status, col_VerProducao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_producao.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_producao.EnableHeadersVisualStyles = false;
            dgw_producao.GridColor = Color.FromArgb(7, 30, 34);
            dgw_producao.Location = new Point(3, 61);
            dgw_producao.MultiSelect = false;
            dgw_producao.Name = "dgw_producao";
            dgw_producao.ReadOnly = true;
            dgw_producao.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_producao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_producao.RowHeadersVisible = false;
            dgw_producao.RowHeadersWidth = 50;
            dgw_producao.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_producao.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_producao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_producao.Size = new Size(814, 447);
            dgw_producao.TabIndex = 3;
            dgw_producao.CellContentClick += btn_VerProducao_Click;

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
            // btn_CadastrarFornecedor
            // 
            btn_CadastrarFornecedor.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarFornecedor.FlatStyle = FlatStyle.Flat;
            btn_CadastrarFornecedor.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarFornecedor.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarFornecedor.Image = (Image)resources.GetObject("btn_CadastrarFornecedor.Image");
            btn_CadastrarFornecedor.Location = new Point(1, 15);
            btn_CadastrarFornecedor.Name = "btn_CadastrarFornecedor";
            btn_CadastrarFornecedor.Size = new Size(173, 42);
            btn_CadastrarFornecedor.TabIndex = 4;
            btn_CadastrarFornecedor.Text = "Cadastrar ";
            btn_CadastrarFornecedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarFornecedor.UseVisualStyleBackColor = false;
            btn_CadastrarFornecedor.Click += btn_CadastrarFornecedor_Click;
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
            // col_ID
            // 
            col_ID.FillWeight = 50F;
            col_ID.HeaderText = "N°";
            col_ID.Name = "col_ID";
            col_ID.ReadOnly = true;
            // 
            // col_Produto
            // 
            col_Produto.FillWeight = 250F;
            col_Produto.HeaderText = "Produto:";
            col_Produto.Name = "col_Produto";
            col_Produto.ReadOnly = true;
            col_Produto.Resizable = DataGridViewTriState.True;
            col_Produto.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_Produto.Width = 210;
            // 
            // col_inicio
            // 
            col_inicio.FillWeight = 150F;
            col_inicio.HeaderText = "Inicio:";
            col_inicio.Name = "col_inicio";
            col_inicio.ReadOnly = true;
            col_inicio.Resizable = DataGridViewTriState.True;
            col_inicio.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_inicio.Width = 150;
            // 
            // Col_Fim
            // 
            Col_Fim.FillWeight = 150F;
            Col_Fim.HeaderText = "Fim:";
            Col_Fim.Name = "Col_Fim";
            Col_Fim.ReadOnly = true;
            Col_Fim.Width = 150;
            // 
            // col_Status
            // 
            col_Status.HeaderText = "Status:";
            col_Status.Name = "col_Status";
            col_Status.ReadOnly = true;
            // 
            // col_VerProducao
            // 
            col_VerProducao.HeaderText = "Ver";
            col_VerProducao.Name = "col_VerProducao";
            col_VerProducao.ReadOnly = true;
            col_VerProducao.Resizable = DataGridViewTriState.True;
            col_VerProducao.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Producao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Producao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FM_Produção";
            WindowState = FormWindowState.Maximized;
            Load += Form_Producao_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_producao).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblMensagem;
        private DataGridView dgw_producao;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisa;
        private Button btn_CadastrarFornecedor;
        private Button btn_Recarregar;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Produto;
        private DataGridViewTextBoxColumn col_inicio;
        private DataGridViewTextBoxColumn Col_Fim;
        private DataGridViewTextBoxColumn col_Status;
        private DataGridViewButtonColumn col_VerProducao;
    }
}