using System;

namespace Uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor = 0, soma = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y > x)
                {
                    maior = y;
                    menor = x;
                }
                else
                {
                    maior = x;
                    menor = y;
                }
                for (int t = menor + 1; t < maior; t++)
                {

                    if (t % 2 != 0)
                    {
                        soma = soma + t;

                    }
                    else if (menor == maior)
                    {
                        soma = 0;

                    }

                }
                Console.WriteLine(soma);
                soma = 0;

                
            }

        }
    }
}
