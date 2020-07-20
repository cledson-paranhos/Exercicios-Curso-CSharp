using System;
using System.Globalization;

namespace Uri1116
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);

                double resultado = (double) X / Y;
                if(resultado == 0.0)
                {
                    Console.WriteLine("0.0");
                }else if(Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else 
                {
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();
        }
    }
}
