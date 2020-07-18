using System;
using System.Globalization;

namespace Uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCobaia = 0, totalCoelho = 0, totalRato = 0, totalSapo = 0 ;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int quant = int.Parse(vet[0]);
                char cobaia = char.Parse(vet[1]);

                totalCobaia += quant;

                if (cobaia == 'C')
                {
                    totalCoelho += quant;
                }else if(cobaia == 'R')
                {
                    totalRato += quant;
                }else
                {
                    totalSapo += quant;
                }
            }
            double porcentagemCoelho = (double) totalCoelho / totalCobaia * 100.0;
            double porcentagemRato = (double)totalRato / totalCobaia * 100.0;
            double porcentagemSapo = (double) totalSapo / totalCobaia * 100.0;
            Console.WriteLine("Total: "+ totalCobaia + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelho);
            Console.WriteLine("Total de ratos: " + totalRato);
            Console.WriteLine("Total de sapos: " + totalSapo);
            Console.WriteLine("Percentual de coelhos: "+ porcentagemCoelho.ToString("F2",CultureInfo.InvariantCulture)+ " %");
            Console.WriteLine("Percentual de ratos: "+porcentagemRato.ToString("F2",CultureInfo.InvariantCulture)+ " %");
            Console.WriteLine("Percentual de sapos: "+ porcentagemSapo.ToString("F2",CultureInfo.InvariantCulture)+ " %");

            Console.ReadKey();
        }
    }
}
