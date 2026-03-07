namespace ProcessamentoImagens
{
    partial class frmPrincipal
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEquacaoReta = new System.Windows.Forms.RadioButton();
            this.btnDDA = new System.Windows.Forms.RadioButton();
            this.btnPontoMedioRetas = new System.Windows.Forms.RadioButton();
            this.btnEquacaoCircunferencia = new System.Windows.Forms.RadioButton();
            this.btnTrigonometria = new System.Windows.Forms.RadioButton();
            this.btnPontoMedioCircunferencia = new System.Windows.Forms.RadioButton();
            this.btnPontoMedioElipse = new System.Windows.Forms.RadioButton();
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 606);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 28);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btnEquacaoReta);
            this.flowLayoutPanel1.Controls.Add(this.btnDDA);
            this.flowLayoutPanel1.Controls.Add(this.btnPontoMedioRetas);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.btnEquacaoCircunferencia);
            this.flowLayoutPanel1.Controls.Add(this.btnTrigonometria);
            this.flowLayoutPanel1.Controls.Add(this.btnPontoMedioCircunferencia);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.btnPontoMedioElipse);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 41);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 353);
            this.flowLayoutPanel1.TabIndex = 108;
            // 
            // btnEquacaoReta
            // 
            this.btnEquacaoReta.AutoSize = true;
            this.btnEquacaoReta.Location = new System.Drawing.Point(14, 38);
            this.btnEquacaoReta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquacaoReta.Name = "btnEquacaoReta";
            this.btnEquacaoReta.Size = new System.Drawing.Size(134, 20);
            this.btnEquacaoReta.TabIndex = 1;
            this.btnEquacaoReta.TabStop = true;
            this.btnEquacaoReta.Text = "Equação da Reta";
            this.btnEquacaoReta.UseVisualStyleBackColor = true;
            this.btnEquacaoReta.CheckedChanged += new System.EventHandler(this.btnEquacaoReta_CheckedChanged);
            // 
            // btnDDA
            // 
            this.btnDDA.AutoSize = true;
            this.btnDDA.Location = new System.Drawing.Point(14, 66);
            this.btnDDA.Margin = new System.Windows.Forms.Padding(4);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(57, 20);
            this.btnDDA.TabIndex = 2;
            this.btnDDA.TabStop = true;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.CheckedChanged += new System.EventHandler(this.btnDDA_CheckedChanged);
            // 
            // btnPontoMedioRetas
            // 
            this.btnPontoMedioRetas.AutoSize = true;
            this.btnPontoMedioRetas.Location = new System.Drawing.Point(14, 94);
            this.btnPontoMedioRetas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPontoMedioRetas.Name = "btnPontoMedioRetas";
            this.btnPontoMedioRetas.Size = new System.Drawing.Size(104, 20);
            this.btnPontoMedioRetas.TabIndex = 3;
            this.btnPontoMedioRetas.TabStop = true;
            this.btnPontoMedioRetas.Text = "Ponto Médio";
            this.btnPontoMedioRetas.UseVisualStyleBackColor = true;
            this.btnPontoMedioRetas.CheckedChanged += new System.EventHandler(this.btnPontoMedioRetas_CheckedChanged);
            // 
            // btnEquacaoCircunferencia
            // 
            this.btnEquacaoCircunferencia.AutoSize = true;
            this.btnEquacaoCircunferencia.Location = new System.Drawing.Point(14, 156);
            this.btnEquacaoCircunferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquacaoCircunferencia.Name = "btnEquacaoCircunferencia";
            this.btnEquacaoCircunferencia.Size = new System.Drawing.Size(171, 20);
            this.btnEquacaoCircunferencia.TabIndex = 113;
            this.btnEquacaoCircunferencia.TabStop = true;
            this.btnEquacaoCircunferencia.Text = "Equação Circunferência";
            this.btnEquacaoCircunferencia.UseVisualStyleBackColor = true;
            this.btnEquacaoCircunferencia.CheckedChanged += new System.EventHandler(this.btnEquacaoCircunferencia_CheckedChanged);
            // 
            // btnTrigonometria
            // 
            this.btnTrigonometria.AutoSize = true;
            this.btnTrigonometria.Location = new System.Drawing.Point(14, 184);
            this.btnTrigonometria.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrigonometria.Name = "btnTrigonometria";
            this.btnTrigonometria.Size = new System.Drawing.Size(112, 20);
            this.btnTrigonometria.TabIndex = 114;
            this.btnTrigonometria.TabStop = true;
            this.btnTrigonometria.Text = "Trigonometria";
            this.btnTrigonometria.UseVisualStyleBackColor = true;
            this.btnTrigonometria.CheckedChanged += new System.EventHandler(this.btnTrigonometria_CheckedChanged);
            // 
            // btnPontoMedioCircunferencia
            // 
            this.btnPontoMedioCircunferencia.AutoSize = true;
            this.btnPontoMedioCircunferencia.Location = new System.Drawing.Point(14, 212);
            this.btnPontoMedioCircunferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPontoMedioCircunferencia.Name = "btnPontoMedioCircunferencia";
            this.btnPontoMedioCircunferencia.Size = new System.Drawing.Size(104, 20);
            this.btnPontoMedioCircunferencia.TabIndex = 115;
            this.btnPontoMedioCircunferencia.TabStop = true;
            this.btnPontoMedioCircunferencia.Text = "Ponto Médio";
            this.btnPontoMedioCircunferencia.UseVisualStyleBackColor = true;
            this.btnPontoMedioCircunferencia.CheckedChanged += new System.EventHandler(this.btnPontoMedioCircunferencia_CheckedChanged);
            // 
            // btnPontoMedioElipse
            // 
            this.btnPontoMedioElipse.AutoSize = true;
            this.btnPontoMedioElipse.Location = new System.Drawing.Point(14, 274);
            this.btnPontoMedioElipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnPontoMedioElipse.Name = "btnPontoMedioElipse";
            this.btnPontoMedioElipse.Size = new System.Drawing.Size(104, 20);
            this.btnPontoMedioElipse.TabIndex = 1;
            this.btnPontoMedioElipse.TabStop = true;
            this.btnPontoMedioElipse.Text = "Ponto Médio";
            this.btnPontoMedioElipse.UseVisualStyleBackColor = true;
            this.btnPontoMedioElipse.CheckedChanged += new System.EventHandler(this.btnPontoMedioElipse_CheckedChanged);
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.Location = new System.Drawing.Point(420, 31);
            this.pictBoxImg1.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(995, 628);
            this.pictBoxImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxImg1.TabIndex = 110;
            this.pictBoxImg1.TabStop = false;
            this.pictBoxImg1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseDown);
            this.pictBoxImg1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(62, 34);
            this.label1.TabIndex = 111;
            this.label1.Text = "Retas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 116;
            this.label2.Text = "Circunferência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 117;
            this.label3.Text = "Elipse";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 748);
            this.Controls.Add(this.pictBoxImg1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLimpar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.RadioButton btnEquacaoReta;
        private System.Windows.Forms.RadioButton btnDDA;
        private System.Windows.Forms.RadioButton btnPontoMedioRetas;
        private System.Windows.Forms.RadioButton btnPontoMedioElipse;
        private System.Windows.Forms.RadioButton btnEquacaoCircunferencia;
        private System.Windows.Forms.RadioButton btnTrigonometria;
        private System.Windows.Forms.RadioButton btnPontoMedioCircunferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

