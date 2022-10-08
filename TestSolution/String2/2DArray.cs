using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
   // 10.	WAP to accept data in 2D array of 3X4 and accept data.
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 4];

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
          
            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 4; j++)
                Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }

    }
}
