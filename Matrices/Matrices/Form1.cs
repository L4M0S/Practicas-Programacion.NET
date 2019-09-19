using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            int c1 = Int32.Parse(tbC1.Text);
            int r1 = Int32.Parse(tbR1.Text);

            int c2 = Int32.Parse(tbC2.Text);
            int r2 = Int32.Parse(tbR2.Text);

            Form2 segunda = new Form2(c1,r1,c2,r2);
            segunda.ShowDialog();
        }
    }
}
