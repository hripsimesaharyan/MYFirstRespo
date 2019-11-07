using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
           
                PrintMatrix(matrix);
                PrintMatrixtriangular(matrix);


        void PrintMatrix(int[,] Mat)

        {

                Console.WriteLine("Matrix: ");

                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {

                       Console.Write(Mat[i, j]);

                    }
                    Console.WriteLine();
                }

        }
            void PrintMatrixtriangular (int[,] Mat)

            {

                Console.WriteLine("Matrixtriangular: ");

                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (i > j)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write(Mat[i, j]); 
                        }

                           
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}
