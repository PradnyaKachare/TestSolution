using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution
{
    class arraymissingNo
    {
        public void MissingNo()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i]<a[j])
                    {
                        int k = a[i];
                        a[i] = a[j];
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                int m = a[i];
                m++;
                for (int j = m; j < a[i + 1]; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
        static void Main(string[] args)
        {
            arraymissingNo y = new arraymissingNo();
                y.MissingNo();
        }

    }
}

