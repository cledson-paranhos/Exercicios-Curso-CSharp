using System;

namespace Uri1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0, maior = 0, soma;
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                menor = m;
                maior = n;
                
                if (n < m)
                {
                    menor = n;
                    maior = m;
                }
                soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                    
                }
                Console.WriteLine("Sum="+ soma);
                

                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }
            
        }
    }
}
