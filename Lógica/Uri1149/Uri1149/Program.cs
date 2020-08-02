using System;

namespace Uri1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, a, n, i = 0;
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            i = 1;

            n = int.Parse(valores[i]);

            while(n <= 0)
            {
                i = i + 1;
                n = int.Parse(valores[i]);
            }
            for(i = 0; i < n; i++)
            {
                soma = soma + a + i;
            }
            Console.WriteLine(soma);

        }
    }
}
