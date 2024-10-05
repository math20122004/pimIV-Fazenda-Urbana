namespace CityGreen
{
    partial class Form_Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fornecedores));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbx_pequisa = new TextBox();
            btn_Recarregar = new Button();
            btn_CadastrarUser = new Button();
            dgw_usuarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_usuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbx_pequisa);
            panel1.Location = new Point(377, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 42);
            panel1.TabIndex = 12;
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
            // btn_Recarregar
            // 
            btn_Recarregar.BackColor = Color.FromArgb(7, 30, 34);
            btn_Recarregar.FlatStyle = FlatStyle.Flat;
            btn_Recarregar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Recarregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Recarregar.Image = (Image)resources.GetObject("btn_Recarregar.Image");
            btn_Recarregar.Location = new Point(190, 52);
            btn_Recarregar.Name = "btn_Recarregar";
            btn_Recarregar.Size = new Size(181, 42);
            btn_Recarregar.TabIndex = 11;
            btn_Recarregar.Text = "Recarregar";
            btn_Recarregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Recarregar.UseVisualStyleBackColor = false;
            // 
            // btn_CadastrarUser
            // 
            btn_CadastrarUser.BackColor = Color.FromArgb(7, 30, 34);
            btn_CadastrarUser.FlatStyle = FlatStyle.Flat;
            btn_CadastrarUser.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadastrarUser.ForeColor = SystemColors.ButtonHighlight;
            btn_CadastrarUser.Image = (Image)resources.GetObject("btn_CadastrarUser.Image");
            btn_CadastrarUser.Location = new Point(11, 51);
            btn_CadastrarUser.Name = "btn_CadastrarUser";
            btn_CadastrarUser.Size = new Size(173, 42);
            btn_CadastrarUser.TabIndex = 10;
            btn_CadastrarUser.Text = "Cadastrar ";
            btn_CadastrarUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CadastrarUser.UseVisualStyleBackColor = false;
            // 
            // dgw_usuarios
            // 
            dgw_usuarios.Anchor = AnchorStyles.None;
            dgw_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_usuarios.Location = new Point(8, 99);
            dgw_usuarios.Name = "dgw_usuarios";
            dgw_usuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgw_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgw_usuarios.Size = new Size(843, 447);
            dgw_usuarios.TabIndex = 9;
            // 
            // Form_Fornecedores
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
            Name = "Form_Fornecedores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FM_Fornecedores";
            WindowState = FormWindowState.Maximized;
            Load += Form_Fornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_usuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbx_pequisa;
        private Button btn_Recarregar;
        private Button btn_CadastrarUser;
        private DataGridView dgw_usuarios;
    }
}