using System;
using System.Globalization;

namespace Vetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                nota1[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            double media = 0.0, soma = 0.0;

            Console.WriteLine("Alunos aprovados:");
            for(int i = 0; i < n; i++)
            {
                soma = nota1[i] + nota2[i];
                media = soma / 2.0;
                if(media >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            
        }
    }
}
