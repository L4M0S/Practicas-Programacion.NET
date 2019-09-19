namespace TablasDeMultiplicar
{
    partial class TablasDeMultiplicar
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.cbHasta = new System.Windows.Forms.ComboBox();
            this.rtbCalculo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(77, 288);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            this.btCalcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtCalcular_KeyDown);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(159, 288);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 1;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(119, 33);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(100, 20);
            this.tbTabla.TabIndex = 4;
            this.tbTabla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbTabla_KeyDown);
            this.tbTabla.Leave += new System.EventHandler(this.TbTabla_Leave);
            // 
            // cbHasta
            // 
            this.cbHasta.FormattingEnabled = true;
            this.cbHasta.Location = new System.Drawing.Point(279, 32);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(121, 21);
            this.cbHasta.TabIndex = 5;
            this.cbHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbHasta_KeyDown);
            this.cbHasta.Leave += new System.EventHandler(this.CbHasta_Leave);
            // 
            // rtbCalculo
            // 
            this.rtbCalculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbCalculo.Location = new System.Drawing.Point(77, 78);
            this.rtbCalculo.Name = "rtbCalculo";
            this.rtbCalculo.Size = new System.Drawing.Size(195, 204);
            this.rtbCalculo.TabIndex = 6;
            this.rtbCalculo.Text = "";
            this.rtbCalculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbCalculo_KeyDown);
            // 
            // TablasDeMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCalculo);
            this.Controls.Add(this.cbHasta);
            this.Controls.Add(this.tbTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Name = "TablasDeMultiplicar";
            this.Text = "TablasDeMultiplicar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TablasDeMultiplicar_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTabla;
        private System.Windows.Forms.ComboBox cbHasta;
        private System.Windows.Forms.RichTextBox rtbCalculo;
    }
}