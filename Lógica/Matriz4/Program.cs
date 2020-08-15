using System;
using System.Runtime.Serialization;

namespace Matriz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            int soma = 0;

            for(int i = 0; i<n; i++)
            {
                for(int j = i + 1; j<n; j++)
                {
                    soma = soma + mat[i,j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
