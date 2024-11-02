namespace CityGreen
{
    partial class Form_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            lbl_produto = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lbl_produto
            // 
            lbl_produto.AutoSize = true;
            lbl_produto.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_produto.Location = new Point(36, 26);
            lbl_produto.Name = "lbl_produto";
            lbl_produto.Size = new Size(454, 23);
            lbl_produto.TabIndex = 64;
            lbl_produto.Text = "Sistema de Gerenciamento da City Green";
            lbl_produto.Click += lbl_produto_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(741, 69);
            label1.TabIndex = 65;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 180);
            label2.Name = "label2";
            label2.Size = new Size(678, 69);
            label2.TabIndex = 66;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 143);
            label3.Name = "label3";
            label3.Size = new Size(393, 23);
            label3.TabIndex = 67;
            label3.Text = "1.  Gerenciamento de Fornecedores\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 252);
            label4.Name = "label4";
            label4.Size = new Size(238, 23);
            label4.TabIndex = 69;
            label4.Text = "2.  Gestão de Vendas\n";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 289);
            label5.Name = "label5";
            label5.Size = new Size(678, 69);
            label5.TabIndex = 68;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 363);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 71;
            label6.Text = "3.  Produção\n";
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 400);
            label7.Name = "label7";
            label7.Size = new Size(678, 69);
            label7.TabIndex = 70;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 475);
            label8.Name = "label8";
            label8.Size = new Size(741, 43);
            label8.TabIndex = 72;
            label8.Text = "Caso tenha dúvidas ou precise de assistência, entre em contato com os administradores através do telefone: (12) 98808-9087.";
            // 
            // Form_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_produto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Inicio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FM_Inicio";
            WindowState = FormWindowState.Maximized;
            Load += Form_Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_produto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}