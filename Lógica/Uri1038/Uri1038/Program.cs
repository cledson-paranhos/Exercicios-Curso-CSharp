using System;
using System.Globalization;

namespace Uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lanchonete = Console.ReadLine().Split(' ');
            int cod = int.Parse(lanchonete[0]);
            int quant = int.Parse(lanchonete[1]);
            double valorTotal = 0.0;

            if(cod == 1)
            {
                valorTotal = quant * 4.00;
            }else if (cod == 2)
            {
                valorTotal = quant * 4.50;
            }else if (cod == 3)
            {
                valorTotal = quant * 5.00;
            }else if(cod == 4)
            {
                valorTotal = quant * 2.00;

            }
            else
            {
                valorTotal = quant * 1.50;

            }
            Console.WriteLine("Total: R$ "+ valorTotal.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
