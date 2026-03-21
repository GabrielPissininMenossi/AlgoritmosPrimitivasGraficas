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
            this.groupBoxRetas = new System.Windows.Forms.GroupBox();
            this.btnEquacaoReta = new System.Windows.Forms.RadioButton();
            this.btnPontoMedioRetas = new System.Windows.Forms.RadioButton();
            this.btnDDA = new System.Windows.Forms.RadioButton();
            this.groupBoxCircubferencia = new System.Windows.Forms.GroupBox();
            this.btnTrigonometria = new System.Windows.Forms.RadioButton();
            this.btnPontoMedioCircunferencia = new System.Windows.Forms.RadioButton();
            this.btnEquacaoCircunferencia = new System.Windows.Forms.RadioButton();
            this.groupBoxElipse = new System.Windows.Forms.GroupBox();
            this.btnPontoMedioElipse = new System.Windows.Forms.RadioButton();
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPoligono = new System.Windows.Forms.ListView();
            this.btnAddPoligono = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbIdPoligono = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvPontosY = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvPontosX = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxRetas.SuspendLayout();
            this.groupBoxCircubferencia.SuspendLayout();
            this.groupBoxElipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 606);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.flowLayoutPanel1.Controls.Add(this.groupBoxRetas);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxCircubferencia);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxElipse);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 366);
            this.flowLayoutPanel1.TabIndex = 108;
            // 
            // groupBoxRetas
            // 
            this.groupBoxRetas.Controls.Add(this.btnEquacaoReta);
            this.groupBoxRetas.Controls.Add(this.btnPontoMedioRetas);
            this.groupBoxRetas.Controls.Add(this.btnDDA);
            this.groupBoxRetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRetas.Location = new System.Drawing.Point(14, 2);
            this.groupBoxRetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRetas.Name = "groupBoxRetas";
            this.groupBoxRetas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRetas.Size = new System.Drawing.Size(196, 135);
            this.groupBoxRetas.TabIndex = 118;
            this.groupBoxRetas.TabStop = false;
            this.groupBoxRetas.Text = "Retas";
            // 
            // btnEquacaoReta
            // 
            this.btnEquacaoReta.AutoSize = true;
            this.btnEquacaoReta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquacaoReta.Location = new System.Drawing.Point(16, 28);
            this.btnEquacaoReta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquacaoReta.Name = "btnEquacaoReta";
            this.btnEquacaoReta.Size = new System.Drawing.Size(139, 21);
            this.btnEquacaoReta.TabIndex = 1;
            this.btnEquacaoReta.TabStop = true;
            this.btnEquacaoReta.Text = "Equação da Reta";
            this.btnEquacaoReta.UseVisualStyleBackColor = true;
            // 
            // btnPontoMedioRetas
            // 
            this.btnPontoMedioRetas.AutoSize = true;
            this.btnPontoMedioRetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontoMedioRetas.Location = new System.Drawing.Point(16, 89);
            this.btnPontoMedioRetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPontoMedioRetas.Name = "btnPontoMedioRetas";
            this.btnPontoMedioRetas.Size = new System.Drawing.Size(108, 21);
            this.btnPontoMedioRetas.TabIndex = 3;
            this.btnPontoMedioRetas.TabStop = true;
            this.btnPontoMedioRetas.Text = "Ponto Médio";
            this.btnPontoMedioRetas.UseVisualStyleBackColor = true;
            // 
            // btnDDA
            // 
            this.btnDDA.AutoSize = true;
            this.btnDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.Location = new System.Drawing.Point(16, 60);
            this.btnDDA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(58, 21);
            this.btnDDA.TabIndex = 2;
            this.btnDDA.TabStop = true;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            // 
            // groupBoxCircubferencia
            // 
            this.groupBoxCircubferencia.Controls.Add(this.btnTrigonometria);
            this.groupBoxCircubferencia.Controls.Add(this.btnPontoMedioCircunferencia);
            this.groupBoxCircubferencia.Controls.Add(this.btnEquacaoCircunferencia);
            this.groupBoxCircubferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCircubferencia.Location = new System.Drawing.Point(14, 141);
            this.groupBoxCircubferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCircubferencia.Name = "groupBoxCircubferencia";
            this.groupBoxCircubferencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCircubferencia.Size = new System.Drawing.Size(196, 135);
            this.groupBoxCircubferencia.TabIndex = 119;
            this.groupBoxCircubferencia.TabStop = false;
            this.groupBoxCircubferencia.Text = "Circunferência";
            // 
            // btnTrigonometria
            // 
            this.btnTrigonometria.AutoSize = true;
            this.btnTrigonometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrigonometria.Location = new System.Drawing.Point(16, 62);
            this.btnTrigonometria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrigonometria.Name = "btnTrigonometria";
            this.btnTrigonometria.Size = new System.Drawing.Size(117, 21);
            this.btnTrigonometria.TabIndex = 114;
            this.btnTrigonometria.TabStop = true;
            this.btnTrigonometria.Text = "Trigonometria";
            this.btnTrigonometria.UseVisualStyleBackColor = true;
            // 
            // btnPontoMedioCircunferencia
            // 
            this.btnPontoMedioCircunferencia.AutoSize = true;
            this.btnPontoMedioCircunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontoMedioCircunferencia.Location = new System.Drawing.Point(16, 91);
            this.btnPontoMedioCircunferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPontoMedioCircunferencia.Name = "btnPontoMedioCircunferencia";
            this.btnPontoMedioCircunferencia.Size = new System.Drawing.Size(108, 21);
            this.btnPontoMedioCircunferencia.TabIndex = 115;
            this.btnPontoMedioCircunferencia.TabStop = true;
            this.btnPontoMedioCircunferencia.Text = "Ponto Médio";
            this.btnPontoMedioCircunferencia.UseVisualStyleBackColor = true;
            // 
            // btnEquacaoCircunferencia
            // 
            this.btnEquacaoCircunferencia.AutoSize = true;
            this.btnEquacaoCircunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquacaoCircunferencia.Location = new System.Drawing.Point(16, 33);
            this.btnEquacaoCircunferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquacaoCircunferencia.Name = "btnEquacaoCircunferencia";
            this.btnEquacaoCircunferencia.Size = new System.Drawing.Size(180, 21);
            this.btnEquacaoCircunferencia.TabIndex = 113;
            this.btnEquacaoCircunferencia.TabStop = true;
            this.btnEquacaoCircunferencia.Text = "Equação Circunferência";
            this.btnEquacaoCircunferencia.UseVisualStyleBackColor = true;
            // 
            // groupBoxElipse
            // 
            this.groupBoxElipse.Controls.Add(this.btnPontoMedioElipse);
            this.groupBoxElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxElipse.Location = new System.Drawing.Point(14, 280);
            this.groupBoxElipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxElipse.Name = "groupBoxElipse";
            this.groupBoxElipse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxElipse.Size = new System.Drawing.Size(196, 71);
            this.groupBoxElipse.TabIndex = 120;
            this.groupBoxElipse.TabStop = false;
            this.groupBoxElipse.Text = "Elipse";
            // 
            // btnPontoMedioElipse
            // 
            this.btnPontoMedioElipse.AutoSize = true;
            this.btnPontoMedioElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontoMedioElipse.Location = new System.Drawing.Point(16, 28);
            this.btnPontoMedioElipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPontoMedioElipse.Name = "btnPontoMedioElipse";
            this.btnPontoMedioElipse.Size = new System.Drawing.Size(108, 21);
            this.btnPontoMedioElipse.TabIndex = 1;
            this.btnPontoMedioElipse.TabStop = true;
            this.btnPontoMedioElipse.Text = "Ponto Médio";
            this.btnPontoMedioElipse.UseVisualStyleBackColor = true;
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.Location = new System.Drawing.Point(287, 31);
            this.pictBoxImg1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(978, 603);
            this.pictBoxImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxImg1.TabIndex = 110;
            this.pictBoxImg1.TabStop = false;
            this.pictBoxImg1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseDown);
            this.pictBoxImg1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.listViewPoligono);
            this.flowLayoutPanel2.Controls.Add(this.btnAddPoligono);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel2.Controls.Add(this.lbIdPoligono);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1293, 33);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(227, 487);
            this.flowLayoutPanel2.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.label1.Size = new System.Drawing.Size(107, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polígonos";
            // 
            // listViewPoligono
            // 
            this.listViewPoligono.HideSelection = false;
            this.listViewPoligono.Location = new System.Drawing.Point(15, 47);
            this.listViewPoligono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewPoligono.Name = "listViewPoligono";
            this.listViewPoligono.Size = new System.Drawing.Size(197, 115);
            this.listViewPoligono.TabIndex = 1;
            this.listViewPoligono.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddPoligono
            // 
            this.btnAddPoligono.Location = new System.Drawing.Point(15, 170);
            this.btnAddPoligono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPoligono.Name = "btnAddPoligono";
            this.btnAddPoligono.Size = new System.Drawing.Size(199, 28);
            this.btnAddPoligono.TabIndex = 2;
            this.btnAddPoligono.Text = "Add Polígono";
            this.btnAddPoligono.UseVisualStyleBackColor = true;
            this.btnAddPoligono.Click += new System.EventHandler(this.btnAddPoligono_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(15, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbIdPoligono
            // 
            this.lbIdPoligono.AutoSize = true;
            this.lbIdPoligono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPoligono.Location = new System.Drawing.Point(15, 238);
            this.lbIdPoligono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdPoligono.Name = "lbIdPoligono";
            this.lbIdPoligono.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lbIdPoligono.Size = new System.Drawing.Size(45, 43);
            this.lbIdPoligono.TabIndex = 3;
            this.lbIdPoligono.Text = " NA";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvPontosY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvPontosX, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 285);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(199, 123);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lvPontosY
            // 
            this.lvPontosY.HideSelection = false;
            this.lvPontosY.Location = new System.Drawing.Point(103, 27);
            this.lvPontosY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPontosY.Name = "lvPontosY";
            this.lvPontosY.Size = new System.Drawing.Size(89, 91);
            this.lvPontosY.TabIndex = 3;
            this.lvPontosY.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // lvPontosX
            // 
            this.lvPontosX.HideSelection = false;
            this.lvPontosX.Location = new System.Drawing.Point(4, 27);
            this.lvPontosX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPontosX.Name = "lvPontosX";
            this.lvPontosX.Size = new System.Drawing.Size(89, 91);
            this.lvPontosX.TabIndex = 2;
            this.lvPontosX.UseCompatibleStateImageBehavior = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 672);
            this.Controls.Add(this.pictBoxImg1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxRetas.ResumeLayout(false);
            this.groupBoxRetas.PerformLayout();
            this.groupBoxCircubferencia.ResumeLayout(false);
            this.groupBoxCircubferencia.PerformLayout();
            this.groupBoxElipse.ResumeLayout(false);
            this.groupBoxElipse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxRetas;
        private System.Windows.Forms.GroupBox groupBoxCircubferencia;
        private System.Windows.Forms.GroupBox groupBoxElipse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPoligono;
        private System.Windows.Forms.Button btnAddPoligono;
        private System.Windows.Forms.Label lbIdPoligono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvPontosY;
        private System.Windows.Forms.ListView lvPontosX;
        private System.Windows.Forms.Button btnCancelar;
    }
}

