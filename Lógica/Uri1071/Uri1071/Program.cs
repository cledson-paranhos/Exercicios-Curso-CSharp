using System;

namespace Uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, soma = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if(x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            for(int i = min + 1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
