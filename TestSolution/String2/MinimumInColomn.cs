using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
  /*  13.	WAP to print minimum in columns.
  e.g.arr[][]={ { 22, 31, 9}, { 12, 5,16}, { 34, 42, 2} } output is: 12, 5, 2.
*/
    class MinimumInColomn
    {
		// Function to get min element
		public static void Minelement(int no_of_col, int[][] arr)

		{
			int i = 0;

			// Initialize min to 0 at beginning
			// of finding min element of each row
			int min = 0;
			int[] result = new int[no_of_col];
			while (i < no_of_col)
			{
				for (int j = 0;	j < arr[i].Length; j++)
				{
					if (arr[i][j] < min)
					{
						min = arr[i][j];
					}
				}
				result[i] = min;
				min = 0;
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
			Minelement(4, arr);
		}
	}


}

