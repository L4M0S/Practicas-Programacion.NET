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
    public partial class Form3 : Form
    {
        static int[,] matriz1;
        static int[,] matriz2;
        static int[,] matriz3;
        static int opc;

        public Form3(int[,] _matriz1, int[,] _matriz2, int _opc)
        {
            InitializeComponent();
            
            matriz1 = _matriz1;
            matriz2 = _matriz2;
            opc = _opc;

            switch(opc)
            {
                case 1: sumar();
                    break;
                case 2: restar();
                    break;
                case 3: multiplicar();
                    break;
            }
        }

        public void sumar()
        {
            matriz3 = new int[matriz1.GetLength(0),matriz1.GetLength(1)];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[j, i] = matriz1[j, i] + matriz2[j, i];
                }
            }

            int rowLength1 = matriz3.GetLength(0);
            int colLength1 = matriz3.GetLength(1);

            for (int i = 0; i < rowLength1; i++)
            {
                for (int j = 0; j < colLength1; j++)
                {
                    rtbResultado.AppendText(matriz3[i, j] + " , ");
                }
                rtbResultado.AppendText("\n");
            }
        }

        public void restar()
        {
            matriz3 = new int[matriz1.GetLength(0), matriz1.GetLength(1)];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[j, i] = matriz1[j, i] - matriz2[j, i];
                }
            }

            int rowLength1 = matriz3.GetLength(0);
            int colLength1 = matriz3.GetLength(1);

            for (int i = 0; i < rowLength1; i++)
            {
                for (int j = 0; j < colLength1; j++)
                {
                    rtbResultado.AppendText(matriz3[i, j] + " , ");
                }
                rtbResultado.AppendText("\n");
            }
        }

        public void multiplicar()
        {
            matriz3 = new int[matriz1.GetLength(0), matriz2.GetLength(1)];

            int suma = 0;

            for (int i = 0; i < matriz3.GetLength(0); i++)
            {

                for (int j = 0; j < matriz3.GetLength(1); j++)
                {
                    //matriz[j, i] = (matriz1[0,j]*matriz2[j,0]) + (matriz1[1,j] * matriz2[j,1]) + (matriz1[2,j] * matriz2[j, 2]);
                    for (int k = 0; k < matriz1.GetLength(1); k++)
                    {
                        suma += (matriz1[i, k] * matriz2[k, j]);
                    }
                    //matriz[j, i] = (matriz1[j,i] * matriz2[i,j]) + (matriz1[1, j] * matriz2[j, 1]) + (matriz1[2, j] * matriz2[j, 2]);
                    matriz3[i, j] = suma;
                    suma = 0;
                }
            }

            int rowLength1 = matriz3.GetLength(0);
            int colLength1 = matriz3.GetLength(1);

            for (int i = 0; i < rowLength1; i++)
            {
                for (int j = 0; j < colLength1; j++)
                {
                    rtbResultado.AppendText(matriz3[i, j] + " , ");
                }
                rtbResultado.AppendText("\n");
            }
        }

        
    }
}
