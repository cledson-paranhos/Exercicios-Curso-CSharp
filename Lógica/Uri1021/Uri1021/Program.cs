using System;
using System.Globalization;

namespace Uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem = 100, cinquenta = 50, vinte = 20, vinteCinco = 25, dez = 10, cinco = 5, dois = 2;
            double resto;

            double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");

            Console.WriteLine((int)notas / cem + " nota(s) de R$ 100.00");
            resto = notas % cem;

            Console.WriteLine((int)resto / cinquenta + " nota(s) de R$ 50.00");
            resto = resto % cinquenta;

            Console.WriteLine((int)resto / vinte + " nota(s) de R$ 20.00");
            resto = resto % vinte;

            Console.WriteLine((int)resto / dez + " nota(s) de R$ 10.00");
            resto = resto % dez;

            Console.WriteLine((int)resto / cinco + " nota(s) de R$ 5.00");
            resto = resto % cinco;

            Console.WriteLine((int)resto / dois + " nota(s) de R$ 2.00");
            resto = resto % dois;

            resto = resto * 100.0;

            Console.WriteLine("MOEDAS:");

            Console.WriteLine((int)resto / cem + " moeda(s) de R$ 1.00");
            resto = resto % cem;

            Console.WriteLine((int)resto / cinquenta + " moeda(s) de R$ 0.50");
            resto = resto % cinquenta;

            Console.WriteLine((int)resto / vinteCinco + " moeda(s) de R$ 0.25");
            resto = resto % vinteCinco;

            Console.WriteLine((int)resto / dez + " moeda(s) de R$ 0.10");
            resto = resto % dez;

            Console.WriteLine((int)resto / cinco + " moeda(s) de R$ 0.05");
            resto = resto % cinco;

            Console.WriteLine((int)resto + " moeda(s) de R$ 0.01");

            Console.ReadKey();

        }
    }
}
