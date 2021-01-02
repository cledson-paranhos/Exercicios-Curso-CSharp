﻿using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vect = new Pessoa[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write("Aluguel #"+ i);
                Console.WriteLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Pessoa(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.Write(i+": "+ vect[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
