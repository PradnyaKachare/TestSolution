using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
	/*8.WAP to create a 2D array of 4 X  4. Create a List from array 
	 such that it contains only  lower Triangular matrix elements
	  and print list in sorted order*/
	// Lower triangular and
	// Upper triangular
	// matrix of an array

	class LowerTriangleArray
    {
		// method to form lower
		// triangular matrix
		static void lower(int[,] matrix,int row, int col)
		{
			int i, j;
			for (i = 0; i < row; i++)
			{
				for (j = 0; j < col; j++)
				{
					if (i < j)
					{
						Console.Write("0" + " ");
					}
					else
						Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		// Method to form upper
		// triangular matrix
		static void upper(int[,] matrix,int row, int col)
		{
			int i, j;
			for (i = 0; i < row; i++)
			{
				for (j = 0; j < col; j++)
				{
					if (i > j)
					{
						Console.Write("0" + " ");
					}
					else
						Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		// Driver Code
		static public void Main()
		{
			int[,] matrix = {{1, 2, 3},
						{4, 5, 6},
						{7, 8, 9}};
			int row = 3, col = 3;

			Console.WriteLine("Lower triangular matrix: ");
			lower(matrix, row, col);

			Console.WriteLine("Upper triangular matrix: ");
			upper(matrix, row, col);
		}

	}
}
