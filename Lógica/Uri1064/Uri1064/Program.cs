using System;
using System.Globalization;

namespace Uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double aux = 0, numPositivo = 0;
            if(num1 > 0)
            {
                aux = aux += 1;
                numPositivo += num1;

            }if(num2 > 0)
            {
                aux = aux += 1;
                numPositivo += num2;
            }if(num3 > 0)
            {
                aux = aux += 1;
                numPositivo += num3;
            }if(num4 > 0)
            {
                aux = aux += 1;
                numPositivo += num4;
            }if(num5 > 0)
            {
                aux = aux += 1;
                numPositivo += num5;
            }if(num6 > 0)
            {
                aux = aux += 1;
                numPositivo += num6;
            }
            
            Console.WriteLine(aux + " valores positivos");
            double media = numPositivo / aux;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
