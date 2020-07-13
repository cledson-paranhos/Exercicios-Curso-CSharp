using System;
using System.Globalization;

namespace Uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double aux = 0;
            if(num1 > 0)
            {
                aux = aux += 1;
            } if(num2 > 0){
                aux = aux += 1;
            } if(num3 > 0)
            {
                aux = aux += 1;
            } if(num4 > 0)
            {
                aux = aux += 1;
            } if(num5 > 0)
            {
                aux = aux += 1;
            }
            if(num6 > 0)
            {
                aux = aux += 1;
            }
            Console.WriteLine(aux + " valores positivos");

            Console.ReadKey();
        }
    }
}
