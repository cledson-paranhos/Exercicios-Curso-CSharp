using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Vetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
            char[] sexo = new char[n];

            for(int i = 0; i< n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }
            double menorAltura = altura[0];
            double maiorAltura = altura[0];
            for(int i = 0; i < n; i++)
            {
                if(altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }else if(altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }
            double soma = 0.0, media = 0.0;
            int contMulheres = 0, contHomens = 0;

            for(int i = 0; i < n; i++)
            {
                if(sexo[i] == 'F')
                {
                    contMulheres = contMulheres + 1;
                    soma = soma + altura[i];
                }
                else
                {
                    contHomens = contHomens + 1;
                }
            }
            media = soma / contMulheres;
            Console.WriteLine("Menor altura = "+menorAltura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = "+maiorAltura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = "+media.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
