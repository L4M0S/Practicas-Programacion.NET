namespace MySQL
{
    partial class Pagar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txbEntrada = new System.Windows.Forms.TextBox();
            this.txbSalida = new System.Windows.Forms.TextBox();
            this.txbHabitacion = new System.Windows.Forms.TextBox();
            this.txbCosto = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.dataGridH = new System.Windows.Forms.DataGridView();
            this.dataGridR = new System.Windows.Forms.DataGridView();
            this.txbNoches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habitacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Costo:";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(42, 247);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbEntrada
            // 
            this.txbEntrada.Location = new System.Drawing.Point(110, 55);
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.Size = new System.Drawing.Size(100, 20);
            this.txbEntrada.TabIndex = 8;
            // 
            // txbSalida
            // 
            this.txbSalida.Location = new System.Drawing.Point(110, 76);
            this.txbSalida.Name = "txbSalida";
            this.txbSalida.Size = new System.Drawing.Size(100, 20);
            this.txbSalida.TabIndex = 9;
            // 
            // txbHabitacion
            // 
            this.txbHabitacion.Location = new System.Drawing.Point(110, 103);
            this.txbHabitacion.Name = "txbHabitacion";
            this.txbHabitacion.Size = new System.Drawing.Size(100, 20);
            this.txbHabitacion.TabIndex = 10;
            // 
            // txbCosto
            // 
            this.txbCosto.Location = new System.Drawing.Point(110, 124);
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Size = new System.Drawing.Size(100, 20);
            this.txbCosto.TabIndex = 11;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(110, 188);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 12;
            // 
            // dataGridH
            // 
            this.dataGridH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridH.Location = new System.Drawing.Point(475, 428);
            this.dataGridH.Name = "dataGridH";
            this.dataGridH.Size = new System.Drawing.Size(10, 10);
            this.dataGridH.TabIndex = 13;
            // 
            // dataGridR
            // 
            this.dataGridR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridR.Location = new System.Drawing.Point(459, 428);
            this.dataGridR.Name = "dataGridR";
            this.dataGridR.Size = new System.Drawing.Size(10, 10);
            this.dataGridR.TabIndex = 14;
            // 
            // txbNoches
            // 
            this.txbNoches.Location = new System.Drawing.Point(110, 150);
            this.txbNoches.Name = "txbNoches";
            this.txbNoches.Size = new System.Drawing.Size(100, 20);
            this.txbNoches.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Noches:";
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNoches);
            this.Controls.Add(this.dataGridR);
            this.Controls.Add(this.dataGridH);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbCosto);
            this.Controls.Add(this.txbHabitacion);
            this.Controls.Add(this.txbSalida);
            this.Controls.Add(this.txbEntrada);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pagar";
            this.Text = "Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txbEntrada;
        private System.Windows.Forms.TextBox txbSalida;
        private System.Windows.Forms.TextBox txbHabitacion;
        private System.Windows.Forms.TextBox txbCosto;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.DataGridView dataGridH;
        private System.Windows.Forms.DataGridView dataGridR;
        private System.Windows.Forms.TextBox txbNoches;
        private System.Windows.Forms.Label label4;
    }
}