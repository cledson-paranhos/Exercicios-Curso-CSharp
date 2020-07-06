using System;
using System.Globalization;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double consumo = (horas * velocidade / 12.0);
            Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadKey();


        }
    }
}
