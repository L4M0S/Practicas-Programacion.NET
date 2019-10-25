namespace MySQL
{
    partial class ListaHabitaciones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHabitacionToolStripMenuItem,
            this.editarHabitacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarHabitacionToolStripMenuItem
            // 
            this.registrarHabitacionToolStripMenuItem.Name = "registrarHabitacionToolStripMenuItem";
            this.registrarHabitacionToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.registrarHabitacionToolStripMenuItem.Text = "Registrar habitacion";
            this.registrarHabitacionToolStripMenuItem.Click += new System.EventHandler(this.registrarHabitacionToolStripMenuItem_Click);
            // 
            // editarHabitacionToolStripMenuItem
            // 
            this.editarHabitacionToolStripMenuItem.Name = "editarHabitacionToolStripMenuItem";
            this.editarHabitacionToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.editarHabitacionToolStripMenuItem.Text = "Editar habitacion";
            this.editarHabitacionToolStripMenuItem.Click += new System.EventHandler(this.editarHabitacionToolStripMenuItem_Click);
            // 
            // ListaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaHabitaciones";
            this.Text = "ListaHabitaciones";
            this.Activated += new System.EventHandler(this.ListaHabitaciones_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarHabitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarHabitacionToolStripMenuItem;
    }
}