// OneD vs TwoD Arrays

using System;

namespace oneD.twoD
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1D,  2D array
            int num = 0;
            int[] oneD = new int[60];
            int[,] twoD = new int[12, 5];

            Random values = new Random();


            for (int a =0; a <12; a++)      //2D aRRAY ROWS
            {
                for (int b = 0; b <5; b++) // COLUNAS
                {
                    twoD[a, b] = values.Next(0,25);  // SET UP THE RANGES ( NUMBERS - TO BE SELECTED)
                }
            }

          //1D
            for (int c = 0; c <12; c++ )
            {
                for (int d = 0; d < 5; d++)
                {
                    oneD[num] = twoD[c, d]; // 1D primeiro pq e  que vai ser preenchido pelo 2D
                    num++;  //contar quantas vezes run
                }
            } 
          
            Console.WriteLine(" The 2D erray is: ");
            
          
            // print 2D array
            for (int e = 0; e <12; e++)
            {
                for (int f = 0; f <5; f++)
                {
                    Console.Write(twoD[e,f] + " \t"); // numeros serao aqui
                }
                Console.WriteLine(" ");  // vai fazer com que o 2D array seja printed 
            }
            
            
            Console.WriteLine("\n");
            
            // print 1D Array
            Console.WriteLine(" The 1D erray is: ");
            for (int g = 0; g <60; g++)
            {
                Console.Write(oneD[g] + " \t");
            }
        }
    }
}
