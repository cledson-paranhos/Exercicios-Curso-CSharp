using System;
using System.Globalization;

namespace Vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] s = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);

            }
            for(int i= 0; i<n; i++)
            {
                media = media + vet[i] / n;
            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for(int i =0; i < n; i++)
            {
                if(vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
