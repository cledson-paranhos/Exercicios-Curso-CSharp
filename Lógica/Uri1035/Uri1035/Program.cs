using System;

namespace Uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);
           
            int somaCd = c + d;
            int somaAb = a + b;

            
            if(b > c && d > a && somaCd > somaAb && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadKey();
        }
    }
}
