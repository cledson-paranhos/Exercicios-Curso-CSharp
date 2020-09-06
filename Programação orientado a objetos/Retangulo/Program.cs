using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            R.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("AREA: "+ R.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("PERIMETRO: " + R.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("DIAGONAL: "+R.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
