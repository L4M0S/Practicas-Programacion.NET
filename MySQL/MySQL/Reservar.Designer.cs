namespace MySQL
{
    partial class Reservar
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
            this.btnReservar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EntradaDia = new System.Windows.Forms.ComboBox();
            this.EntradaMes = new System.Windows.Forms.ComboBox();
            this.EntradaAno = new System.Windows.Forms.TextBox();
            this.SalidaAno = new System.Windows.Forms.TextBox();
            this.SalidaMes = new System.Windows.Forms.ComboBox();
            this.SalidaDia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(25, 247);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salida:";
            // 
            // EntradaDia
            // 
            this.EntradaDia.FormattingEnabled = true;
            this.EntradaDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.EntradaDia.Location = new System.Drawing.Point(75, 162);
            this.EntradaDia.Name = "EntradaDia";
            this.EntradaDia.Size = new System.Drawing.Size(56, 21);
            this.EntradaDia.TabIndex = 18;
            // 
            // EntradaMes
            // 
            this.EntradaMes.FormattingEnabled = true;
            this.EntradaMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.EntradaMes.Location = new System.Drawing.Point(137, 162);
            this.EntradaMes.Name = "EntradaMes";
            this.EntradaMes.Size = new System.Drawing.Size(62, 21);
            this.EntradaMes.TabIndex = 19;
            // 
            // EntradaAno
            // 
            this.EntradaAno.Location = new System.Drawing.Point(206, 162);
            this.EntradaAno.Name = "EntradaAno";
            this.EntradaAno.Size = new System.Drawing.Size(63, 20);
            this.EntradaAno.TabIndex = 20;
            // 
            // SalidaAno
            // 
            this.SalidaAno.Location = new System.Drawing.Point(206, 202);
            this.SalidaAno.Name = "SalidaAno";
            this.SalidaAno.Size = new System.Drawing.Size(63, 20);
            this.SalidaAno.TabIndex = 23;
            // 
            // SalidaMes
            // 
            this.SalidaMes.FormattingEnabled = true;
            this.SalidaMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.SalidaMes.Location = new System.Drawing.Point(137, 202);
            this.SalidaMes.Name = "SalidaMes";
            this.SalidaMes.Size = new System.Drawing.Size(62, 21);
            this.SalidaMes.TabIndex = 22;
            // 
            // SalidaDia
            // 
            this.SalidaDia.FormattingEnabled = true;
            this.SalidaDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SalidaDia.Location = new System.Drawing.Point(75, 202);
            this.SalidaDia.Name = "SalidaDia";
            this.SalidaDia.Size = new System.Drawing.Size(56, 21);
            this.SalidaDia.TabIndex = 21;
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.SalidaAno);
            this.Controls.Add(this.SalidaMes);
            this.Controls.Add(this.SalidaDia);
            this.Controls.Add(this.EntradaAno);
            this.Controls.Add(this.EntradaMes);
            this.Controls.Add(this.EntradaDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label5);
            this.Name = "Reservar";
            this.Text = "Reservar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EntradaDia;
        private System.Windows.Forms.ComboBox EntradaMes;
        private System.Windows.Forms.TextBox EntradaAno;
        private System.Windows.Forms.TextBox SalidaAno;
        private System.Windows.Forms.ComboBox SalidaMes;
        private System.Windows.Forms.ComboBox SalidaDia;
    }
}