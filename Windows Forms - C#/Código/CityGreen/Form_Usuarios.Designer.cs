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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios));
            dgw_usuarios = new DataGridView();
            btn_CadastrarUser = new Button();
            btn_Recarregar = new Button();
            tbx_pequisa = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgw_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgw_usuarios
            // 
            dgw_usuarios.Anchor = AnchorStyles.None;
            dgw_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_usuarios.Location = new Point(8, 98);
            dgw_usuarios.Name = "dgw_usuarios";
            dgw_usuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgw_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgw_usuarios.Size = new Size(843, 447);
            dgw_usuarios.TabIndex = 3;
            // 
            // btn_CadastrarUser
            // 
            btn_CadastrarUser.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarUser.FlatStyle = FlatStyle.Flat;
            btn_CadastrarUser.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarUser.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarUser.Image = (Image)resources.GetObject("btn_CadastrarUser.Image");
            btn_CadastrarUser.Location = new Point(12, 50);
            btn_CadastrarUser.Name = "btn_CadastrarUser";
            btn_CadastrarUser.Size = new Size(173, 42);
            btn_CadastrarUser.TabIndex = 4;
            btn_CadastrarUser.Text = "Cadastrar ";
            btn_CadastrarUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarUser.UseVisualStyleBackColor = false;
            btn_CadastrarUser.Click += button1_Click;
            // 
            // btn_Recarregar
            // 
            btn_Recarregar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Recarregar.FlatStyle = FlatStyle.Flat;
            btn_Recarregar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Recarregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Recarregar.Image = (Image)resources.GetObject("btn_Recarregar.Image");
            btn_Recarregar.Location = new Point(191, 51);
            btn_Recarregar.Name = "btn_Recarregar";
            btn_Recarregar.Size = new Size(181, 42);
            btn_Recarregar.TabIndex = 5;
            btn_Recarregar.Text = "Recarregar";
            btn_Recarregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Recarregar.UseVisualStyleBackColor = false;
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
            tbx_pequisa.Size = new Size(412, 24);
            tbx_pequisa.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbx_pequisa);
            panel1.Location = new Point(378, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 42);
            panel1.TabIndex = 8;
            // 
            // Form_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(858, 553);
            Controls.Add(panel1);
            Controls.Add(btn_Recarregar);
            Controls.Add(btn_CadastrarUser);
            Controls.Add(dgw_usuarios);
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
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgw_usuarios;
        private Button btn_CadastrarUser;
        private Button btn_Recarregar;
        private TextBox tbx_pequisa;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}