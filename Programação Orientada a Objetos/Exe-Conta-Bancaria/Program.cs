using System;
using System.Globalization;

namespace Exe_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n?) ");
            char decisao = char.Parse(Console.ReadLine());

            if(decisao == 's' || decisao == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                c = new ContaBancaria(numero, nome);
            }

            Console.Write("Dados da conta: "+c);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double novoDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            c.Deposito(novoDeposito);

            Console.WriteLine("Dados da conta atualizados: "+c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: "+ c);

        }
    }
}
