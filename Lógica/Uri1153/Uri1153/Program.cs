using System;

namespace Uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                valor = valor * i;
            }
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
