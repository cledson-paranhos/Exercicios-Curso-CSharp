using System;
using System.Globalization;

namespace Uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(valores1[1], CultureInfo.InvariantCulture);

            string[] valores2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
