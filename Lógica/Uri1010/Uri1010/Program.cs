using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados1 = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(dados1[0]);
            int numPeca1 = int.Parse(dados1[1]);
            double valor1 = double.Parse(dados1[2],CultureInfo.InvariantCulture);

            string[] dados2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(dados2[0]);
            int numPeca2 = int.Parse(dados2[1]);
            double valor2 = double.Parse(dados2[2],CultureInfo.InvariantCulture);

            double valorAPagar = (numPeca1 * valor1) + (numPeca2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ "+ valorAPagar.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
