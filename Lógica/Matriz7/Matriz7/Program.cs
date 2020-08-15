using System;

namespace Matriz7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            
            for(int i = 0; i<m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }    
            }
            int girarFila = int.Parse(Console.ReadLine()), ultimoFila = 0;
            girarFila = girarFila - 1;
            
            for(int i = 0; i < girarFila; i++)
            { 
                ultimoFila = mat[girarFila, n - 1];   
            }
            for(int j = n - 1; j>0; j--)
            {
                mat[girarFila, j] = mat[girarFila, j - 1];
            }

            mat[girarFila, 0] = ultimoFila;

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}
