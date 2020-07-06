using System;
using System.Globalization;

namespace Uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pi = 3.14159;
            int r = int.Parse(Console.ReadLine());
            double calculo = 4.0 / 3.0 * pi * r * r * r;
            Console.WriteLine("VOLUME = "+calculo.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
