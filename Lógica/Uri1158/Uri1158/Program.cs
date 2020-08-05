using System;
using System.Globalization;

namespace Uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int n = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split();
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if(x % 2 == 0)
                {
                    x = x + 1;
                }
                for(int j = 0; j < y; j++)
                {
                    soma = soma + x;
                    x += 2;
                }
                Console.WriteLine(soma);
                soma = 0; 
            }
        }
    }
}
