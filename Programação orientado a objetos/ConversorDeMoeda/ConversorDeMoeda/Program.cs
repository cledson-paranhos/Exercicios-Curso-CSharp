using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = Conversor.ValorASerPago(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais " + resultado.ToString("F2", CultureInfo.InvariantCulture));

          
            
            Console.ReadKey();
        }
        
    }
}
