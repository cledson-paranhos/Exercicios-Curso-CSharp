using System;

namespace Uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, valorTotal = 0;
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    valor1 = x;
                    valor2 = x += 2;
                    valor3 = x += 2;
                    valor4 = x += 2;
                    valor5 = x += 2;
                    valorTotal = valor1 + valor2 + valor3 + valor4 + valor5;
                    
                }
                else
                {
                    valor1 = x += 1;
                    valor2 = x += 2;
                    valor3 = x += 2;
                    valor4 = x += 2;
                    valor5 = x += 2;

                    valorTotal = valor1 + valor2 + valor3 + valor4 + valor5;
                    
                }
                Console.WriteLine(valorTotal);
                x = int.Parse(Console.ReadLine());
            }


            Console.ReadKey();
        }
    }
}
