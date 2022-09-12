using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
  /*  12.	WAP to print maximum in rowwise in 2D array.
    e.g.arr[][] = { { 22, 31, 9}, { 12, 25, 16} } output is: 31 and 25.
*/
    class MaxRowwise
    {
		// Function to get max element
		public static void maxelement(int no_of_rows,int[][] arr)
		{
			int i = 0;

			// Initialize max to 0 at beginning
			// of finding max element of each row
			int max = 0;

			int[] result = new int[no_of_rows];

			while (i < no_of_rows)
			{
				for (int j = 0;
						j < arr[i].Length; j++)
				{
					if (arr[i][j] > max)
					{
						max = arr[i][j];
					}
				}
				result[i] = max;
				max = 0;
				i++;

			}
			printArray(result);

		}

		// Print array element
		private static void printArray(int[] result)
		{
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(result[i]);
			}

		}

		// Driver code
		 static void Main(string[] args)
		 {
			int[][] arr = new int[][]
			{
		   new int[] {3, 4, 1, 8},
		   new int[] {1, 4, 9, 11},
		   new int[] {76, 34, 21, 1},
		   new int[] {2, 1, 4, 5}
			};

			// Calling the function
			maxelement(4, arr);
		 }

	}
}
