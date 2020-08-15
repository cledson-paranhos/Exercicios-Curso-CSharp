using System;
using System.Globalization;

namespace Vetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                compra[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }
            int contLucroAbaixoDe10 = 0, contLucroEntre10E20 = 0, contLucroAcimaDe20 = 0;

            for(int i = 0; i < n; i++)
            {
                double lucro =  venda[i] - compra[i];

                double porcentagemLucro = lucro / compra[i] * 100.0;
                if(porcentagemLucro < 10.0)
                {
                    contLucroAbaixoDe10++;
                }else if(porcentagemLucro <= 20.0)
                {
                    contLucroEntre10E20++;
                }
                else
                {
                    contLucroAcimaDe20++;
                }  
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contLucroAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contLucroEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contLucroAcimaDe20);

            double totalCompra = 0.0, totalVenda = 0.0, lucroTotal = 0.0;
            for(int i = 0; i < n; i++)
            {
                totalCompra = totalCompra + compra[i];
                totalVenda = totalVenda + venda[i];
                lucroTotal = totalVenda - totalCompra ; 
            }
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: "+ totalVenda.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: "+lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
