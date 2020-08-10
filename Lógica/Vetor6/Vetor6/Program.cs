using System;

namespace Vetor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            int[] idade = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int idadeMaior = idade[0];
            int posicao = 0;
            for(int i = 0; i<n; i++)
            {
                if(idade[i] > idadeMaior)
                {
                    idadeMaior = idade[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: "+nome[posicao]);
            
        }
    }
}
