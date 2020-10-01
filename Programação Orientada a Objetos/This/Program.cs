using System;
using System.Globalization;
namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quant);

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite a quantidade a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quant);

            Console.WriteLine("Dados atualizado: " + p);
        }
    }
}
