using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();
            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Funcionário: "+F);
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porce = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            F.AumentarSalario(porce);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: "+ F);
        }
    }
}
