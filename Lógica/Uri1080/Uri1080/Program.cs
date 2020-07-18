using System;

namespace Uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.Parse(Console.ReadLine());
            int cont = 0;

            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    cont = i;
                }

            }
            Console.WriteLine(maior);
            Console.WriteLine(cont);

            Console.ReadKey();
        }
    }
}
