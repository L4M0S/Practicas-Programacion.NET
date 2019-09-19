//ORELLAN SILVA LUIS ADOLFO MATEO   16011190	.NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Numero Perfecto");
            //Console.WriteLine("2)Leer vector");
            //Console.WriteLine("3)Leer Matriz");
            Console.WriteLine("2)Sumar vector");
            Console.WriteLine("3)Sumar matriz");
            Console.WriteLine("4)Multiplicar matriz");

            int opc = int.Parse(Console.ReadLine()); ;

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Numero Perfecto");
                    perfecto();
                    break;
                /*case 2:
                    Console.WriteLine("Leer vector");
                    break;
                case 3:
                    Console.WriteLine("Leer Matriz");
                    break;*/
                case 2:
                    Console.WriteLine("Sumar vector");
                    sumar(leerVector(),leerVector());
                    break;
                case 3:
                    Console.WriteLine("Sumar matriz");
                    sumar(leerMatriz(), leerMatriz());
                    break;
                case 4:
                    Console.WriteLine("Multiplicar matriz");
                    multiplicar(leerMatriz(), leerMatriz());
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
            Console.ReadKey();
        }

        public static void perfecto()
        {
            int suma = 0;
            Console.Write("Digita un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero; i++)
                if (numero % i == 0)
                    suma += i;

            if (suma == numero)
                Console.WriteLine("El numero es perfecto");
            else
                Console.WriteLine("El numero no es perfecto");
        }

        public static int[] leerVector()
        {
            int[] arreglo;

            arreglo=new int[5];

            //int tam=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 5 valores enteros: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese valor "+ (i+1) +": ");
                int val;
                val=int.Parse(Console.ReadLine());
                arreglo[i]=val;
            }

            imprimir(arreglo);

            return arreglo;
        }

        public static void imprimir(int[] arreglo)
        {
            Console.Write("El vector es: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" " + arreglo[i]);
            }

            Console.WriteLine();
        }

        public static void sumar(int[] arreglo1, int[] arreglo2)
        {
            int[] arreglo;

            arreglo = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arreglo[i] = arreglo1[i] + arreglo2[i];
            }
            Console.Write("La suma de los vectores es: ");
            imprimir(arreglo);
        }

        public static int[,] leerMatriz()
        {
            int[,] matriz;

            matriz = new int[3,3];

            //int tam=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 9 valores enteros: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese valor [" + (j + 1) + "],["+ (i + 1)+"]: ");
                    int val;
                    val = int.Parse(Console.ReadLine());
                    matriz[j, i] = val;
                }
            }

            imprimir(matriz);

            return matriz;
        }

        public static void imprimir(int[,] matriz)
        {
            Console.WriteLine("La Matriz es: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + matriz[j, i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void sumar(int[,] matriz1, int[,] matriz2)
        {
            int[,] matriz;

            matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[j,i] = matriz1[j, i] + matriz2[j, i];
                }
            }

            imprimir(matriz);
        }

        public static void multiplicar(int[,] matriz1, int[,] matriz2)
        {
            int[,] matriz;

            matriz = new int[3, 3];

            int suma=0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    //matriz[j, i] = (matriz1[0,j]*matriz2[j,0]) + (matriz1[1,j] * matriz2[j,1]) + (matriz1[2,j] * matriz2[j, 2]);
                    for (int k = 0; k < 3; k++)
                    {
                       suma += (matriz1[j,k] * matriz2[k,i]);
                    }
                    //matriz[j, i] = (matriz1[j,i] * matriz2[i,j]) + (matriz1[1, j] * matriz2[j, 1]) + (matriz1[2, j] * matriz2[j, 2]);
                    matriz[j,i] = suma;
                    suma = 0;
                }
            }

            imprimir(matriz);
        }
    }
}
