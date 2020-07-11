using System;
using System.Globalization;

namespace Uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double temp;
            
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if(a * a == b * b + c *c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }else if(a * a > b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }else 
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(a == b || b== c || c == a )
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            Console.ReadKey();

        }
    }
}
