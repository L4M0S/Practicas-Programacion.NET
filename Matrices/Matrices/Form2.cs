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
    public partial class Form2 : Form
    {
        static int[,] matriz1;
        static int[,] matriz2;

        static Random random = new Random();
        
        public Form2(int _c1, int _r1, int _c2, int _r2)
        {
            InitializeComponent();

            matriz1 = new int[_r1, _c1];
            matriz2 = new int[_r2, _c2];
            llenar();
            imprimir();
        }

        public void llenar()
        {
            int rowLength1 = matriz1.GetLength(0);
            int colLength1 = matriz1.GetLength(1);

            for (int i = 0; i < rowLength1; i++)
            {
                for (int j = 0; j < colLength1; j++)
                {
                    matriz1[i, j]= random.Next(0, 10); 
                }
            }

            int rowLength2 = matriz2.GetLength(0);
            int colLength2 = matriz2.GetLength(1);

            for (int i = 0; i < rowLength2; i++)
            {
                for (int j = 0; j < colLength2; j++)
                {
                    matriz2[i, j] = random.Next(0, 10);
                }
            }
        }

        public void imprimir()
        {
            int rowLength1 = matriz1.GetLength(0);
            int colLength1 = matriz1.GetLength(1);

            for (int i = 0; i < rowLength1; i++)
            {
                for (int j = 0; j < colLength1; j++)
                {
                    rtbM1.AppendText(matriz1[i, j]+ " , ");
                }
                rtbM1.AppendText("\n");
            }

            int rowLength2 = matriz2.GetLength(0);
            int colLength2 = matriz2.GetLength(1);

            for (int i = 0; i < rowLength2; i++)
            {
                for (int j = 0; j < colLength2; j++)
                {
                    rtbM2.AppendText(matriz2[i, j] + " , ");
                }
                rtbM2.AppendText("\n");
            }
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Form3 tercero = new Form3(matriz1, matriz2, 1);
            tercero.ShowDialog();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Form3 tercero = new Form3(matriz1, matriz2, 2);
            tercero.ShowDialog();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Form3 tercero = new Form3(matriz1, matriz2, 3);
            tercero.ShowDialog();
        }
    }
}
