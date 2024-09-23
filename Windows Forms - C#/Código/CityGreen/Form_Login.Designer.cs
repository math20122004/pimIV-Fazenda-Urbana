namespace CityGreen
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            lbl_login = new Label();
            txtB_login = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtB_senha = new TextBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.BackColor = Color.Transparent;
            lbl_login.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.Linen;
            lbl_login.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_login.Location = new Point(274, 213);
            lbl_login.Margin = new Padding(0);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(129, 59);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "City";
            lbl_login.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtB_login
            // 
            txtB_login.BackColor = Color.FromArgb(223, 223, 223);
            txtB_login.BorderStyle = BorderStyle.None;
            txtB_login.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_login.Location = new Point(599, 275);
            txtB_login.Name = "txtB_login";
            txtB_login.PlaceholderText = "Email ou RA";
            txtB_login.Size = new Size(326, 20);
            txtB_login.TabIndex = 2;
            txtB_login.Tag = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(lbl_login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 626);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(102, 213);
            label1.Name = "label1";
            label1.Size = new Size(187, 59);
            label1.TabIndex = 2;
            label1.Text = "Green";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Linen;
            label2.Location = new Point(115, 272);
            label2.Name = "label2";
            label2.Size = new Size(284, 38);
            label2.TabIndex = 3;
            label2.Text = "Authentication";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(557, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(557, 347);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(557, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 3);
            panel3.TabIndex = 9;
            // 
            // txtB_senha
            // 
            txtB_senha.BackColor = Color.FromArgb(223, 223, 223);
            txtB_senha.BorderStyle = BorderStyle.None;
            txtB_senha.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_senha.Location = new Point(599, 364);
            txtB_senha.Name = "txtB_senha";
            txtB_senha.PlaceholderText = "Senha";
            txtB_senha.Size = new Size(326, 20);
            txtB_senha.TabIndex = 8;
            txtB_senha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(223, 223, 223);
            button1.Location = new Point(656, 457);
            button1.Name = "button1";
            button1.Size = new Size(207, 57);
            button1.TabIndex = 11;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(682, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(171, 162);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(718, 193);
            label3.Name = "label3";
            label3.Size = new Size(107, 45);
            label3.TabIndex = 13;
            label3.Text = "Login";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(939, -2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(557, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 3);
            panel2.TabIndex = 4;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 223, 223);
            ClientSize = new Size(996, 622);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(txtB_senha);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtB_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_login;
        private TextBox txtB_login;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private TextBox txtB_senha;
        private Button button1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Panel panel2;
    }
}