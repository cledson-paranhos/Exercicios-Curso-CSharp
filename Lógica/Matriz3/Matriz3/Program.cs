using System;

namespace Matriz3
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
            int numMaior = 0;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    if(mat[i,j] > numMaior)
                    {
                        numMaior = mat[i, j];
                    }   
                }
                Console.WriteLine(numMaior);
                numMaior = 0;
            }       
        }
    }
}
