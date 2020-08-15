using System;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores;
            int n = int.Parse(Console.ReadLine());
            valores = new int[n];

            string[] vet = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                valores[i] = int.Parse(vet[i]);

            }
            int quant = 0;
            for(int i = 0; i<n; i++)
            {
                if(valores[i] % 2 == 0)
                {
                    Console.Write(valores[i] + " ");
                    quant = quant + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(quant);
        }
    }
}
