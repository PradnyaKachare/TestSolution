using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
   // 14.	WAP to print outer elements of 2D array of 4X4.
    class OuterEleArraycs
    {
		class GFG
		{
			public static void printBoundary(int[,] a,int m,int n)
			{
				for (int i = 0; i < m; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (i == 0)
							Console.Write(a[i, j] + " ");
						else if (i == m - 1)
							Console.Write(a[i, j] + " ");
						else if (j == 0)
							Console.Write(a[i, j] + " ");
						else if (j == n - 1)
							Console.Write(a[i, j] + " ");
						else
							Console.Write(" ");
					}
					Console.WriteLine(" ");
				}
			}

			// Driver Code
			static void Main(string[] args)
			{
				int[,] a = { { 1, 2, 3, 4 },
					{ 5, 6, 7, 8 },
					{ 1, 2, 3, 4 },
					{ 5, 6, 7, 8 } };

				printBoundary(a, 4, 4);
			}
		}

	}
}
