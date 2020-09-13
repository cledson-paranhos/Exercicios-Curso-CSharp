using System;
using System.Globalization;

namespace Cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double valorDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Valor a ser pago em reais = "+ CotacaoAtual.ValorTotal(valorDolar, quantidade).ToString("F2",CultureInfo.InvariantCulture)); 
        }
    }
}
