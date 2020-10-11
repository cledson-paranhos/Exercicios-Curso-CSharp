using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.GetNome();
            Console.WriteLine(p);
            Console.WriteLine(p.GetPreco());
        }
    }
}
