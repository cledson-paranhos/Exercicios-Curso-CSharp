using System;
using System.Globalization;

namespace Uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1],CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2],CultureInfo.InvariantCulture);

            double trianguloRetangulo = a * c / 2.0;
            double circulo = pi * c * c;
            double trapezio = (a + b) / 2 * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: "+ trianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ circulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+trapezio.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+quadrado.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
