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
			int j=0 , i=1;

			// Initialize min to 0 at beginning	// of finding min element of each row
			int min = 0;
			int[] result = new int[no_of_col];
			while (j < no_of_col)
			{
				for ( j = 0;	j < arr.Length; j++)
				{
					if (arr[j][i] < min)
					{
						min = arr[j][i];
					}
				}
				result[j] = min;
				min = 0;
				j++;

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
				new int[]{ 22, 31, 9},
				new int[] { 12, 5,16},
				new int[] { 34, 42, 2} 
			};
				/*new int[] {3, 4, 1, 8},
				new int[] {1, 4, 9, 11},
				new int[] {76, 34, 21, 1},
		        new int[] {2, 1, 4, 5}
			};*/

			// Calling the function
			Minelement(3, arr);
		}
	}


}

