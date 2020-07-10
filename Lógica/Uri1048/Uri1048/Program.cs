using System;
using System.Globalization;

namespace Uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double novoSalario, reajusteGanho;

            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salario <= 400.0)
            {
                double perc = 15;
                novoSalario = (salario * perc) / 100 + salario;
                reajusteGanho = salario * perc / 100;

                Console.WriteLine("Novo salario: "+ novoSalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+ reajusteGanho.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+ perc + " %");
            }
            else if(salario <= 800.0)
            {
                double perc = 12;
                novoSalario = (salario * perc) / 100 + salario;
                reajusteGanho = salario * perc / 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + perc + " %");
            }else if (salario <= 1200.0)
            {
                double perc = 10;
                novoSalario = (salario * perc) / 100 + salario;
                reajusteGanho = salario * perc / 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + perc + " %");
            }else if(salario <= 2000.0)
            {
                double perc = 7;
                novoSalario = (salario * perc) / 100 + salario;
                reajusteGanho = salario * perc / 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + perc + " %");
            }
            else
            {
                double perc = 4;
                novoSalario = (salario * perc) / 100 + salario;
                reajusteGanho = salario * perc / 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + perc + " %");
            }

            Console.ReadKey();
        }
    }
}
