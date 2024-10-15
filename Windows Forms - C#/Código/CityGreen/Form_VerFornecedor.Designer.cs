namespace CityGreen
{
    partial class Form_VerFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerFornecedor));
            barraLateral = new FlowLayoutPanel();
            pl_editar = new Panel();
            btn_editar = new Button();
            pl_confirmar = new Panel();
            btn_confirmar = new Button();
            pl_cancelar = new Panel();
            btn_cancelar = new Button();
            panel1 = new Panel();
            lbl_funcao = new Label();
            panel4 = new Panel();
            btn_voltar = new Button();
            panel2 = new Panel();
            lab_funcao = new Label();
            panel3 = new Panel();
            bt_voltar = new Button();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(7, 30, 34);
            barraLateral.Controls.Add(pl_editar);
            barraLateral.Controls.Add(pl_confirmar);
            barraLateral.Controls.Add(pl_cancelar);
            barraLateral.Controls.Add(panel1);
            barraLateral.Dock = DockStyle.Bottom;
            barraLateral.FlowDirection = FlowDirection.RightToLeft;
            barraLateral.Location = new Point(0, 461);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(842, 53);
            barraLateral.TabIndex = 19;
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(666, 5);
            pl_editar.Margin = new Padding(3, 5, 3, 5);
            pl_editar.Name = "pl_editar";
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
            pl_confirmar.Location = new Point(487, 5);
            pl_confirmar.Margin = new Padding(3, 5, 3, 5);
            pl_confirmar.Name = "pl_confirmar";
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
            pl_cancelar.Location = new Point(308, 5);
            pl_cancelar.Margin = new Padding(3, 5, 3, 5);
            pl_cancelar.Name = "pl_cancelar";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 30, 34);
            panel1.Controls.Add(lbl_funcao);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(-19, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 59);
            panel1.TabIndex = 33;
            // 
            // lbl_funcao
            // 
            lbl_funcao.AutoSize = true;
            lbl_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lbl_funcao.Location = new Point(309, 10);
            lbl_funcao.Name = "lbl_funcao";
            lbl_funcao.Size = new Size(119, 29);
            lbl_funcao.TabIndex = 8;
            lbl_funcao.Text = "Função:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(btn_voltar);
            panel4.Location = new Point(683, -16);
            panel4.Margin = new Padding(3, 5, 3, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 42);
            panel4.TabIndex = 20;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.FromArgb(7, 30, 34);
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.ForeColor = SystemColors.ButtonHighlight;
            btn_voltar.Image = (Image)resources.GetObject("btn_voltar.Image");
            btn_voltar.Location = new Point(0, 0);
            btn_voltar.Margin = new Padding(3, 3, 3323, 10);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(134, 42);
            btn_voltar.TabIndex = 15;
            btn_voltar.Text = "Voltar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 30, 34);
            panel2.Controls.Add(lab_funcao);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 59);
            panel2.TabIndex = 20;
            // 
            // lab_funcao
            // 
            lab_funcao.AutoSize = true;
            lab_funcao.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_funcao.ForeColor = Color.FromArgb(29, 120, 116);
            lab_funcao.Location = new Point(317, 15);
            lab_funcao.Name = "lab_funcao";
            lab_funcao.Size = new Size(119, 29);
            lab_funcao.TabIndex = 8;
            lab_funcao.Text = "Função:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(bt_voltar);
            panel3.Location = new Point(12, 10);
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
            bt_voltar.Click += bt_Voltar_Click;
            // 
            // Form_VerFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 514);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(barraLateral);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form_VerFornecedor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form_VerFornecedor";
            Load += Form_VerFornecedor_Load;
            barraLateral.ResumeLayout(false);
            pl_editar.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private FlowLayoutPanel barraLateral;
        private Panel pl_editar;
        private Button btn_editar;
        private Panel pl_confirmar;
        private Button btn_confirmar;
        private Panel pl_cancelar;
        private Button btn_cancelar;
        private Panel panel1;
        private Label lbl_funcao;
        private Panel panel4;
        private Button btn_voltar;
        private Panel panel2;
        private Label lab_funcao;
        private Panel panel3;
        private Button bt_voltar;
    }
}