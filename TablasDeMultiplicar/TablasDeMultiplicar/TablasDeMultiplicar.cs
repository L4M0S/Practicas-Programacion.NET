using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablasDeMultiplicar
{
    public partial class TablasDeMultiplicar : Form
    {
        public void calcular()
        {
            rtbCalculo.Clear();
            int num1 = Int32.Parse(tbTabla.Text);
            int num2 = Int32.Parse(cbHasta.Text);
            int calculo = 0;
            for (int i = 0; i <= num2; i++)
            {
                calculo = num1 * i;
                rtbCalculo.AppendText(i + " x " + num1 + " : " + calculo.ToString() + "\n");

            }
        }

        public TablasDeMultiplicar()
        {
            InitializeComponent();
            cbHasta.Items.AddRange(new object[] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            cbHasta.SelectedItem = 0;
            tbTabla.Text = "0";
            btCalcular.Focus();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            calcular();
            btCalcular.Focus();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            cbHasta.SelectedItem = 0;
            tbTabla.Text = "0";
            rtbCalculo.Clear();
            btCalcular.Focus();
        }

        private void BtCalcular_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                calcular();
            }
            
        }

        private void TbTabla_Leave(object sender, EventArgs e)
        {
            btCalcular.Focus();
        }

        private void CbHasta_Leave(object sender, EventArgs e)
        {
            btCalcular.Focus();
        }

        private void TablasDeMultiplicar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void RtbCalculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void TbTabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void CbHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }
    }
}
