using System;
using System.Globalization;

namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idades = int.Parse(Console.ReadLine());
            int soma = 0;
            double cont = 0.0;
            while(idades > 0)
            {
                soma += idades;
                cont++;
                idades = int.Parse(Console.ReadLine());
                
            }
            double media = soma / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
