using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conecta4
{
    public partial class Form1 : Form
    {
        const int filas=6;
        const int columnas=7;

        int[,] tablero;

        PictureBox[,] imagenes;

        Random random = new Random();
        int turno;  //1=azul,2=rojo
        
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine(turno);
            turno = random.Next(1,3);
            lblTurno.Text = turno.ToString();

            /*for(int i=1; i<=6;i++)
            {
                for(int j=1;j<=7;j++)
                {
                    tablero[i, j] = 0;
                    imagenes[i, j] = ;
                }
            }*/
             tablero = new int[filas, columnas] { { 0,0,0,0,0,0,0 }, //int[filas,columnas]
                                                  { 0,0,0,0,0,0,0 },
                                                  { 0,0,0,0,0,0,0 },
                                                  { 0,0,0,0,0,0,0 },
                                                  { 0,0,0,0,0,0,0 },
                                                  { 0,0,0,0,0,0,0 } };

            imagenes = new PictureBox[filas,columnas] { { c11,c12,c13,c14,c15,c16,c17 }, //int[filas,columnas]
                                                        { c21,c22,c23,c24,c25,c26,c27 },
                                                        { c31,c32,c33,c34,c35,c36,c37 },
                                                        { c41,c42,c43,c44,c45,c46,c47 },
                                                        { c51,c52,c53,c54,c55,c56,c57 },
                                                        { c61,c62,c63,c64,c65,c66,c67 } };

        }


        void CambiarTurno()
        {
            if (turno == 1) turno = 0;
            else turno = 1;

            lblTurno.Text = turno.ToString();
        }

        void ColocarFicha(int columna)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////
        private void columna1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 1");
            ColocarFicha(1);
        }

        private void columna2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 2");
            ColocarFicha(2);
        }

        private void columna3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 3");
            ColocarFicha(3);
        }

        private void columna4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 4");
            ColocarFicha(4);
        }

        private void columna5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 5");
            ColocarFicha(5);
        }

        private void columna6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 6");
            ColocarFicha(6);
        }

        private void columna7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 7");
            ColocarFicha(7);
        }
    }
}
