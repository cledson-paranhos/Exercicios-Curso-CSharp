using System;

namespace Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(){
                Nome = "TV 4k",
                Preco = 500.0,
                Quantidade = 5
            };
            Console.Write("Dados atualizados: "+p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quant);

            Console.WriteLine("Dados atualizados: "+p);
            Console.WriteLine();

            Console.Write("Digite a quantidade a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quant);

            Console.WriteLine("Dados atualizado: "+p);

        }
    }
}
