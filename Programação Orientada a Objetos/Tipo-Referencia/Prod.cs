using System;
using System.Collections.Generic;
using System.Text;

namespace Tipo_Referencia
{
    class Prod
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Prod(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco + ", " + Quantidade;
        }
    }
}
