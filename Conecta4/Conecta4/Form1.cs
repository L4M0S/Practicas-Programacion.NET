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

        bool ganador=false;

        int[,] tablero;

        PictureBox[,] imagenes;

        Random random = new Random();
        int turno;  //1=azul,2=rojo
        
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("Turno: "+turno);
            turno = random.Next(1,3);
            if (turno == 1) lblTurno.Text = "Azul";
            else lblTurno.Text = "Rojo";

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


            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(" " + tablero[i, j]);
                }
                Console.WriteLine("");
            }

            //Console.WriteLine(tablero[5, 6]);
        }


        void CambiarTurno()
        {
            if (turno == 1) turno = 2;
            else turno = 1;

            if(turno==1) lblTurno.Text = "Azul";
            else lblTurno.Text = "Rojo";

            Console.WriteLine("Turno: " + turno);
        }

        bool ColocarFicha(int columna)
        {
            Console.WriteLine("Columna: "+columna);

            

            if (tablero[0, columna-1] == 0)
            {
                int i = columna - 1, j = 0;
                for (j=0;j<filas && tablero[j,i]==0;j++)
                {
                    
                }
                /*int i = 0, j = 0;
                for (i=0 ; i < columna; i++)
                {
                    Console.WriteLine("i: " + i.ToString());

                    while (j < filas && tablero[j,i]==0 )
                    {
                        Console.WriteLine("j: " + j.ToString());
                        j++;
                    }*/
                /*for (j = 0; j < filas; j++)
                {
                    Console.WriteLine("j: " + j.ToString());
                }
            }*/

                Console.WriteLine("j: " + j.ToString() + "  i: " + i.ToString());

                tablero[j-1, i] = turno;
                
                for (int f = 0; f < filas; f++)
                {

                    for (int c = 0; c < columnas; c++)
                    {
                        Console.Write(" " + tablero[f, c]);
                    }
                    Console.WriteLine("");
                }

                ganar();


                PintarTablero();

                return true;

                
            }
            else
            {
                Console.WriteLine("Columna llena");
                MessageBox.Show("Columna llena. Elige otra columna");
                return false;
            }
        }

        void ganar()
        {   
            //vertical -
            for (int f = 0; f < filas-3; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if((tablero[f,c]==1 && tablero[f+1, c] == 1 && tablero[f+2, c] == 1 && tablero[f+3, c] == 1) || (tablero[f, c] == 2 && tablero[f + 1, c] == 2 && tablero[f + 2, c] == 2 && tablero[f + 3, c] == 2))
                    {
                        ganador = true;
                        return;
                    }
                } 
            }

            //horizontal |
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas-3; c++)
                {
                    if ((tablero[f, c] == 1 && tablero[f , c + 1] == 1 && tablero[f , c + 2] == 1 && tablero[f, c + 3] == 1) || (tablero[f, c] == 2 && tablero[f, c + 1] == 2 && tablero[f, c + 2] == 2 && tablero[f, c + 3] == 2))
                    {
                        ganador = true;
                        return;
                    }
                }
            }

            //diagonal \
            for (int f = 0; f < filas-3; f++)
            {
                for (int c = 0; c < columnas - 3; c++)
                {
                    if ((tablero[f, c] == 1 && tablero[f+1, c + 1] == 1 && tablero[f+2, c + 2] == 1 && tablero[f+3, c + 3] == 1) || (tablero[f, c] == 2 && tablero[f+1, c + 1] == 2 && tablero[f+2, c + 2] == 2 && tablero[f+3, c + 3] == 2))
                    {
                        ganador = true;
                        return;
                    }
                }
            }

            //diagonal /
            for (int f = 0; f < filas - 3; f++)
            {
                for (int c = 3; c < columnas; c++)
                {
                    if ((tablero[f, c] == 1 && tablero[f + 1, c - 1] == 1 && tablero[f + 2, c - 2] == 1 && tablero[f + 3, c - 3] == 1) || (tablero[f, c] == 2 && tablero[f + 1, c - 1] == 2 && tablero[f + 2, c - 2] == 2 && tablero[f + 3, c - 3] == 2))
                    {
                        ganador = true;
                        return;
                    }
                }
            }
        }

        void PintarTablero()
        {
            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {
                    if(tablero[i,j]==1)
                    {
                        imagenes[i, j].BackColor = Color.Blue;
                    }
                    else if (tablero[i, j] == 2)
                    {
                        imagenes[i, j].BackColor = Color.Red;
                    }
                    else
                    {
                        imagenes[i, j].BackColor = Color.White;
                    }
                }
                
            }
        }

        void reiniciar()
        {
            turno = random.Next(1, 3);
            if (turno == 1) lblTurno.Text = "Azul";
            else lblTurno.Text = "Rojo";

            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {
                    tablero[i, j] = 0;
                }
            }

            ganador = false;

            PintarTablero();

        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        private void columna1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 1");
            if (ColocarFicha(1))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");

                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
            
        }

        private void columna2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 2");
            if (ColocarFicha(2))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void columna3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 3");
            if (ColocarFicha(3))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void columna4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 4");
            if (ColocarFicha(4))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void columna5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 5");
            if (ColocarFicha(5))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void columna6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 6");
            if (ColocarFicha(6))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void columna7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Columna 7");
            if (ColocarFicha(7))
            {
                if (ganador)
                {
                    Console.WriteLine("Columna llena");
                    MessageBox.Show("El jugado " + lblTurno.Text + " ah ganado");
                    reiniciar();
                }
                else
                {
                    CambiarTurno();
                }
            }
        }
    }
}
