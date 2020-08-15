using System;
using System.Globalization;


namespace Matriz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());
            double somaPositivos = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        somaPositivos = somaPositivos + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));
            double linhaEscolhida = 0.0;
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j <= coluna; j++)
            {
                linhaEscolhida = mat[linha, j];
                Console.Write(linhaEscolhida.ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double colunaEscolhida = 0.0;
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i <= linha + 1; i++)
            { 
                colunaEscolhida = mat[i, coluna];
                Console.Write(colunaEscolhida.ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            double diagonalPrincipal = 0.0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(i == j)
                    {
                        diagonalPrincipal = mat[i, j];
                        Console.Write(diagonalPrincipal.ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }  
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA:");
            for(int i =0; i<n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write((mat[i, j] * mat[i, j]).ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }  
                }
                Console.WriteLine();
            }
        }
    }
}
