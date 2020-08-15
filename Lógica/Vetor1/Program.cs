using System;
using System.Globalization;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++){
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
            }
            double maior = vet[0];
            int posicao = 0;
            for(int i = 0; i < n; i++){
                if(vet[i] > maior){
                    maior = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicao.ToString("F1",CultureInfo.InvariantCulture));

        }
    }
}