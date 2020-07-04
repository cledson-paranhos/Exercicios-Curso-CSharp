using System;
using System.Globalization;

namespace FuncionarioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: "+F);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porce = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porce);
            Console.WriteLine("Dados atualizados "+ F);

            Console.ReadKey();

        }
    }
}
