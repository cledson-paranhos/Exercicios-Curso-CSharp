using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0, soma = 0.0;
            int cont = 0;

            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i<n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            foreach(int valores in vet)
            {
                if(valores % 2 == 0)
                {
                    cont = cont + 1;
                    soma = soma + valores;
                    media = soma / cont;
                }
            }
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
