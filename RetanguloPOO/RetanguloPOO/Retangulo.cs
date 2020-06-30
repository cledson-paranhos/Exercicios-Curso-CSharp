using System;
using System.Collections.Generic;
using System.Text;

namespace RetanguloPOO
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura + Largura) + ( Altura + Altura);
        }
        public double Diagonal()
        {
            double lado1 = Math.Pow(Largura, 2);
            double lado2 = Math.Pow(Altura, 2);
            double total = lado1 + lado2;
            return Math.Sqrt(total);
        }
    }
}
