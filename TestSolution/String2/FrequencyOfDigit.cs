using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
	// 3.	WAP to find out frequency of each digit in given mobile number
	// using only single loop. [1M]
	// C# program to find the frequency// of a digit in a number


	class FrequencyOfDigit
	{
		// function to find frequency 		// of digit in a number
		static int frequencyDigits(long n, int d)
		{
			// Counter variable to			// store the frequency
			int c = 0;

			// iterate till number // reduces to zero
			while (n > 0)
			{
				// check for equality
				if (n % 10 == d)
					c++;
               
				// reduce the number
				n = n / 10;
				
			}
			return c;
		}

		// Driver Code
		static public void Main(String[] args)
		{

			// input number N
			long N = 7387360141;

			// input digit D
			int D = 7;

			Console.WriteLine(frequencyDigits(N, D));


		}
	}
}
