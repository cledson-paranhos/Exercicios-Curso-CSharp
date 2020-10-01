using System;
using System.Globalization;


namespace This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            this.Quantidade = 10;
        }
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public Produto(string Nome, double Preco, int Quantidade) : this(Nome, Preco)
        {
            this.Quantidade = Quantidade; 
        } 
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
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
