using System;
using System.Globalization;

namespace Uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double imposto = 0;

            if(valor <= 2000.0)
            {
                Console.WriteLine("Isento");
            }else if(valor <= 3000.0)
            {
                imposto = (valor - 2000.0) * 0.08;
            }else if(valor <= 4500.0)
            {
                imposto = (valor - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (valor - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            if(valor > 2000.0)
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }

            Console.ReadKey();
        }
    }
}
