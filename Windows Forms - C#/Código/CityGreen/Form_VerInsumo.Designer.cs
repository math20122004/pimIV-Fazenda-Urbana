namespace CityGreen
{
    partial class Form_VerInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerInsumo));
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
            lbl_datavalidade = new Label();
            lbl_quantidade = new Label();
            tbx_ID = new TextBox();
            lbl_ID = new Label();
            lbl_nome = new Label();
            tbx_nome = new TextBox();
            nud_Quantidade = new NumericUpDown();
            lbl_valida = new Label();
            date_validade = new DateTimePicker();
            lbl_validade2 = new Label();
            barraLateral.SuspendLayout();
            pl_editar.SuspendLayout();
            pl_confirmar.SuspendLayout();
            pl_cancelar.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
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
            barraLateral.Location = new Point(0, 500);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(858, 53);
            barraLateral.TabIndex = 19;
            // 
            // pl_editar
            // 
            pl_editar.Anchor = AnchorStyles.Right;
            pl_editar.Controls.Add(btn_editar);
            pl_editar.Location = new Point(682, 5);
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
            pl_confirmar.Location = new Point(503, 5);
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
            pl_cancelar.Location = new Point(324, 5);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 59);
            panel1.TabIndex = 20;
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
            panel4.Location = new Point(12, 10);
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
            btn_voltar.Click += btn_voltar_Click;
            // 
            // lbl_datavalidade
            // 
            lbl_datavalidade.AutoSize = true;
            lbl_datavalidade.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_datavalidade.Location = new Point(40, 220);
            lbl_datavalidade.Name = "lbl_datavalidade";
            lbl_datavalidade.Size = new Size(203, 23);
            lbl_datavalidade.TabIndex = 41;
            lbl_datavalidade.Text = "Data de Validade:";
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_quantidade.Location = new Point(38, 170);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(143, 23);
            lbl_quantidade.TabIndex = 39;
            lbl_quantidade.Text = "Quantidade:";
            // 
            // tbx_ID
            // 
            tbx_ID.BorderStyle = BorderStyle.FixedSingle;
            tbx_ID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ID.Location = new Point(88, 80);
            tbx_ID.MaxLength = 8;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(118, 27);
            tbx_ID.TabIndex = 38;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.Location = new Point(38, 80);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(44, 23);
            lbl_ID.TabIndex = 37;
            lbl_ID.Text = "ID:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(38, 125);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(80, 23);
            lbl_nome.TabIndex = 36;
            lbl_nome.Text = "Nome:";
            // 
            // tbx_nome
            // 
            tbx_nome.BorderStyle = BorderStyle.FixedSingle;
            tbx_nome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nome.Location = new Point(124, 121);
            tbx_nome.MaxLength = 255;
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(466, 27);
            tbx_nome.TabIndex = 35;
            // 
            // nud_Quantidade
            // 
            nud_Quantidade.Font = new Font("Verdana", 12F);
            nud_Quantidade.Location = new Point(187, 170);
            nud_Quantidade.Name = "nud_Quantidade";
            nud_Quantidade.Size = new Size(120, 27);
            nud_Quantidade.TabIndex = 55;
            // 
            // lbl_valida
            // 
            lbl_valida.AutoSize = true;
            lbl_valida.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valida.Location = new Point(40, 269);
            lbl_valida.Name = "lbl_valida";
            lbl_valida.Size = new Size(112, 23);
            lbl_valida.TabIndex = 56;
            lbl_valida.Text = "Validade:";
            // 
            // date_validade
            // 
            date_validade.CalendarFont = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_validade.CustomFormat = "dd/MM/yyyy";
            date_validade.Format = DateTimePickerFormat.Custom;
            date_validade.Location = new Point(259, 220);
            date_validade.Name = "date_validade";
            date_validade.RightToLeft = RightToLeft.No;
            date_validade.Size = new Size(96, 23);
            date_validade.TabIndex = 57;
            // 
            // lbl_validade2
            // 
            lbl_validade2.AutoSize = true;
            lbl_validade2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_validade2.Location = new Point(171, 269);
            lbl_validade2.Name = "lbl_validade2";
            lbl_validade2.Size = new Size(112, 23);
            lbl_validade2.TabIndex = 61;
            lbl_validade2.Text = "Validade:";
            // 
            // Form_VerInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 553);
            ControlBox = false;
            Controls.Add(lbl_validade2);
            Controls.Add(date_validade);
            Controls.Add(lbl_valida);
            Controls.Add(nud_Quantidade);
            Controls.Add(lbl_datavalidade);
            Controls.Add(lbl_quantidade);
            Controls.Add(tbx_ID);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_nome);
            Controls.Add(tbx_nome);
            Controls.Add(panel1);
            Controls.Add(barraLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_VerInsumo";
            Text = "Form_VerInsumo";
            Load += Form_VerInsumo_Load;
            barraLateral.ResumeLayout(false);
            pl_editar.ResumeLayout(false);
            pl_confirmar.ResumeLayout(false);
            pl_cancelar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Panel panel1;
        private Button btn_voltar;
        private Label lbl_funcao;
        private Panel panel4;
        private RadioButton rb_simR;
        private Label lbl_senha;
        private TextBox tbx_email;
        private Label lbl_quantidade;
        private TextBox tbx_ID;
        private Label lbl_ID;
        private Label lbl_nome;
        private TextBox tbx_nome;
        private NumericUpDown nud_Quantidade;
        private Label lbl_valida;
        private DateTimePicker date_validade;
        private Label lbl_datavalidade;
        private ComboBox _fornecedor;
        private Label lbl_validade2;
    }
}