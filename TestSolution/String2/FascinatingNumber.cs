using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
	/*4.	Some examples of fascinating Numbers are : 192, 219, 273, 327 etc.
     * Write a Program in Java to input a 3 digit number and check whether 
     * it is a Fascinating Number or not..
        Fascinating Numbers: Some numbers of 3 digits or more exhibit a 
    very interesting property.The property is such that, when the number
    is multiplied by 2 and 3, and both these products are concatenated 
    with the original number, all digits from 1 to 9 are present exactly once, 
    regardless of the number  of zeroes.
          Let’s understand the concept of Fascinating Number 
    through the following example:Consider the number 192,
              192 x 1 = 192
             192 x 2 = 384
            192 x 3 = 576
        Concatenating the results : 192384576
        It could be observed that ‘192384576’ consists of all digits 
    from 1 to 9 exactly once. Hence, it could be concluded 
    that 192 is a Fascinating Number.
*/
	class FascinatingNumber
	{
		// function to check if number
		// is fascinating or not
		/*public static bool isFascinating(int num)
		{
			// frequency count array
			// using 1 indexing
			int[] freq = new int[10];

			// obtaining the resultant number
			// using string concatenation
			String val = "" + num.ToString() + (num * 2).ToString() +
							(num * 3).ToString();

			// Traversing the string
			// character by character
			for (int i = 0; i < val.Length; i++)
			{

				// gives integer value of
				// a character digit
				int digit = val[i] - '0';

				// To check if any digit has
				// appeared multiple times
				if (freq[digit] && digit != 0 > 0)
					return false;
				else
					freq[digit]++;
			}

			// Traversing through freq array to
			// check if any digit was missing
			for (int i = 1; i < freq.Length; i++)
			{
				if (freq[i] == 0)
					return false;
			}
			return true;
		}

		// Driver code
		static void Main()
		{
			// Input number
			int num = 192;

			// Not a valid number
			if (num < 100)
				Console.WriteLine("No");

			else
			{
				// Calling the function to check
				// if input number is fascinating or not
				bool ans = isFascinating(num);
				if (ans)
					Console.WriteLine("Yes");
				else
					Console.WriteLine("No");
			}*/

		
	}
}
