﻿using System;

namespace Uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else if(x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }else if( x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }else if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }
            

        }
    }
}
