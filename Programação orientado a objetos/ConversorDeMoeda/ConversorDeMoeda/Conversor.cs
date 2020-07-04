using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class Conversor
    {
        public static double IOF = 6.0;

        public static double ValorASerPago(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            return total + total * IOF / 100.0;
        }
       
    }
}
