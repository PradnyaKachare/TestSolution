using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution
{
    class Series
    {
        // C# program to find nth term  of the series
       // 0 3 8 15 24 35 48 63 80
        static void Main(string[] args)       
		{
			// Find given nth term
			int d=0;

            for (int i = 1; i < 10; i++)
            {
                d = i * i - 1;
                Console.WriteLine(d + " ");
            }
			//Console.WriteLine(d+" ");			
		}
	}
}

	



