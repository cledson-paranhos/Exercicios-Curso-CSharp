using System;
using System.Globalization;

namespace Matriz5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
           
            for(int i = 0; i<m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(s[j]);
                }
            }
            int[,] c = new int[m, n];
            for(int i = 0; i<m; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
