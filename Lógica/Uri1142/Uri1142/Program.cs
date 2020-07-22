using System;

namespace Uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                
                Console.WriteLine(numero + " "+ (numero += 1) +" " + (numero += 1) + " PUM");
                numero += 2;
            }
            Console.ReadKey();
        }
    }
}
