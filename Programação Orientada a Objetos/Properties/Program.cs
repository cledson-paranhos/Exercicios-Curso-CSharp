using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P = new Produto("TV", 500.00, 10);

            P.Nome = "T";

            Console.Write("Nome: "+P.Nome);
            Console.WriteLine();
            
            Console.Write("Preco: "+ P.Preco);
            Console.WriteLine();

            Console.WriteLine("Quantidade: "+ P.Quantidade);

        }
    }
}
