namespace CityGreen
{
    partial class Form_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios));
            dgw_usuarios = new DataGridView();
            col_RA = new DataGridViewTextBoxColumn();
            col_Nome = new DataGridViewLinkColumn();
            col_Status = new DataGridViewTextBoxColumn();
            col_email = new DataGridViewLinkColumn();
            col_VerUsuario = new DataGridViewTextBoxColumn();
            btn_CadastrarUser = new Button();
            btn_Recarregar = new Button();
            tbx_pequisa = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgw_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgw_usuarios
            // 
            dgw_usuarios.AllowUserToAddRows = false;
            dgw_usuarios.AllowUserToDeleteRows = false;
            dgw_usuarios.AllowUserToResizeColumns = false;
            dgw_usuarios.AllowUserToResizeRows = false;
            dgw_usuarios.Anchor = AnchorStyles.None;
            dgw_usuarios.BackgroundColor = Color.FromArgb(223, 223, 223);
            dgw_usuarios.BorderStyle = BorderStyle.None;
            dgw_usuarios.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgw_usuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_usuarios.ColumnHeadersHeight = 50;
            dgw_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_usuarios.Columns.AddRange(new DataGridViewColumn[] { col_RA, col_Nome, col_Status, col_email, col_VerUsuario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgw_usuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgw_usuarios.EnableHeadersVisualStyles = false;
            dgw_usuarios.GridColor = Color.FromArgb(7, 30, 34);
            dgw_usuarios.Location = new Point(3, 61);
            dgw_usuarios.MultiSelect = false;
            dgw_usuarios.Name = "dgw_usuarios";
            dgw_usuarios.ReadOnly = true;
            dgw_usuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgw_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgw_usuarios.RowHeadersVisible = false;
            dgw_usuarios.RowHeadersWidth = 50;
            dgw_usuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(7, 30, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(29, 120, 116);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgw_usuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgw_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_usuarios.Size = new Size(814, 447);
            dgw_usuarios.TabIndex = 3;
            // 
            // col_RA
            // 
            col_RA.HeaderText = "RA";
            col_RA.Name = "col_RA";
            col_RA.ReadOnly = true;
            col_RA.Width = 102;
            // 
            // col_Nome
            // 
            col_Nome.HeaderText = "Nome:";
            col_Nome.Name = "col_Nome";
            col_Nome.ReadOnly = true;
            col_Nome.Width = 260;
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
            col_email.Width = 252;
            // 
            // col_VerUsuario
            // 
            col_VerUsuario.HeaderText = "Ver";
            col_VerUsuario.Name = "col_VerUsuario";
            col_VerUsuario.ReadOnly = true;
            // 
            // btn_CadastrarUser
            // 
            btn_CadastrarUser.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarUser.FlatStyle = FlatStyle.Flat;
            btn_CadastrarUser.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarUser.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarUser.Image = (Image)resources.GetObject("btn_CadastrarUser.Image");
            btn_CadastrarUser.Location = new Point(1, 14);
            btn_CadastrarUser.Name = "btn_CadastrarUser";
            btn_CadastrarUser.Size = new Size(173, 42);
            btn_CadastrarUser.TabIndex = 4;
            btn_CadastrarUser.Text = "Cadastrar ";
            btn_CadastrarUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarUser.UseVisualStyleBackColor = false;
            btn_CadastrarUser.Click += btn_CadastrarUser_Click;
            // 
            // btn_Recarregar
            // 
            btn_Recarregar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Recarregar.FlatStyle = FlatStyle.Flat;
            btn_Recarregar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Recarregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Recarregar.Image = (Image)resources.GetObject("btn_Recarregar.Image");
            btn_Recarregar.Location = new Point(182, 14);
            btn_Recarregar.Name = "btn_Recarregar";
            btn_Recarregar.Size = new Size(181, 42);
            btn_Recarregar.TabIndex = 5;
            btn_Recarregar.Text = "Recarregar";
            btn_Recarregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Recarregar.UseVisualStyleBackColor = false;
            btn_Recarregar.Click += btn_Recarregar_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbx_pequisa);
            panel1.Location = new Point(369, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 42);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgw_usuarios);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_CadastrarUser);
            panel2.Controls.Add(btn_Recarregar);
            panel2.Location = new Point(26, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 511);
            panel2.TabIndex = 9;
            // 
            // Form_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Usuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FM_Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += Form_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgw_usuarios;
        private Button btn_CadastrarUser;
        private Button btn_Recarregar;
        private TextBox tbx_pequisa;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn col_RA;
        private DataGridViewLinkColumn col_Nome;
        private DataGridViewTextBoxColumn col_Status;
        private DataGridViewLinkColumn col_email;
        private DataGridViewTextBoxColumn col_VerUsuario;
    }
}