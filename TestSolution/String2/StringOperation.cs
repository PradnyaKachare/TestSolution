using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution.String2
{
   /* 5.	WAP to accept a string and make following changes[1M]
•	Shift each letter right by two step eg A ->C ,Y->A,Z->B
•	Each digit by next higher digit.
•	Space by underscore
*/
    class StringOperation
    {
		// Encrypts text using a shift od s
		public static StringBuilder encrypt(String text, int s)
		{
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < text.Length; i++)
			{
				if (char.IsUpper(text[i]))
				{
					char ch = (char)(((int)text[i] +
									s - 65) % 26 + 65);
					result.Append(ch);
				}
				else
				{
					char ch = (char)(((int)text[i] +
									s - 97) % 26 + 97);
					result.Append(ch);
				}
			}
			return result;
		}

		// Driver code
		public static void Main(String[] args)
		{
			String text = "ATTACKATONCE";
			int s = 4;
			Console.WriteLine("Text : " + text);
			Console.WriteLine("Shift : " + s);
			Console.WriteLine("Cipher: " + encrypt(text, s));
		}

	}
}
