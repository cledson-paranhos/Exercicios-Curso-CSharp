using System;
using System.Globalization;

namespace Uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;
            Console.WriteLine("MEDIA = "+media.ToString("F1",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
