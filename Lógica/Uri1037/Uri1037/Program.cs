using System;
using System.Globalization;

namespace Uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valores = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(valores < 0 || valores > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }else if(valores <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }else if (valores <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }else if (valores <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            Console.ReadKey();
        }
    }
}
