using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
	/* 2.	To Find unique Pair Of Integers in Array whose Sum is Given Number 
	 Given array : [2, 4, 3, 5, 6, -2, 4, 7, 8, 9]
	 Given sum : 7 Integer numbers,
	 whose sum is equal to value : 7
		   (2, 5) (4, 3) (-2, 9) */
	// C# program to check if there exists a pair
	// in array whose sum results in x.

	class UniqPairOfInteger
	{
		// Function to find and print pair
		static bool chkPair(int[] A, int size, int x)
		{
			for (int i = 0; i < (size - 1); i++)
			{
				for (int j = (i + 1); j < size; j++)
				{
					if (A[i] + A[j] == x)
					{
		Console.WriteLine("Pair with a given sum " + x + " is (" + A[i] + ", " + A[j]  );
						return true;
					}
				}
			}
			return false;
		}
		public static void Main()
		{
			int[] A = { 0, -1, 2, -3, 1 };
			int x = -2;
			int size = A.Length;
			if (chkPair(A, size, x))
			{
				Console.WriteLine("Valid pair exists");
			}
			else
			{
				Console.WriteLine("No valid pair exists for " + x);
			}

		}
	}
}
