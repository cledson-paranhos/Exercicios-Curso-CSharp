using System;
using System.Globalization;

namespace Uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double num1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                media = (num1 * 2.0 + num2 * 3.0 + num3 * 5) / 10.0;
                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
