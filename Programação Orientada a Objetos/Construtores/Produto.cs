using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidadade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidadade;
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture); 
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
