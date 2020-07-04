using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valor;
            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horasTrabalhadas * valor;

            Console.WriteLine("NUMBER = "+numeroFuncionario);
            Console.WriteLine("SALARY = U$ "+salario.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
            

        }
    }
}
