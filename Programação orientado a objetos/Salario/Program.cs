using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario f1 = new Salario();
            Salario f2 = new Salario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.SalarioFuncionario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionários: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.SalarioFuncionario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salarioMedio = (f1.SalarioFuncionario + f2.SalarioFuncionario) / 2.0;
            Console.Write("Salário médio = " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
