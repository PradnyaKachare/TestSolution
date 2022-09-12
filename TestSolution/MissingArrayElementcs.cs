using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolution
{
    class MissingArrayElementcs
    {
        public static void findMissing(int []arr, int N)
        {
            int i;
            int [] temp = new int[N + 1];
            for (i = 0; i <= N; i++)
            {
                temp[i] = 0;
            }

            for (i = 0; i < N; i++)
            {
                temp[arr[i] - 1] = 1;
            }

            int ans = 0;
            for (i = 0; i <= N; i++)
            {
                if (temp[i] == 0)
                    ans = i + 1;
            }
            Console.WriteLine(ans); 
        }
       
        public static void Main(String[] args)
        {
            int [] arr = { 1, 2, 4, 6, 3, 7, 8};
             int n = arr.Length;            
            findMissing(arr, n);
        }
    }
}
