using System;
using System.Globalization;

namespace RetanguloPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            R.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
