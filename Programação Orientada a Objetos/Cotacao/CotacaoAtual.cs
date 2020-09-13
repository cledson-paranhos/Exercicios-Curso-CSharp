using System;
namespace Cotacao
{
    class CotacaoAtual
    {
        public static double IOF = 6.0;

        public static double ValorTotal(double valor, double quant)
        {
            double calculo = valor * quant * IOF /100;
            return calculo + valor * quant;
        }
    }
}
