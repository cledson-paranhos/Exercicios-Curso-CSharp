using System;
using System.Globalization;

namespace Uri1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int calculo = 1;
            double media = 0.0;

            while (calculo == 1)
            {
                double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (num1 < 0.0 || num1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }
                double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (num2 < 0.0 || num2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }

                media = (num1 + num2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                calculo = int.Parse(Console.ReadLine());

                while (calculo != 1 && calculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    calculo = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadKey();
        }

    }
}

