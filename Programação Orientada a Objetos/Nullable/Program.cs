using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //O valor null pode ser declarado nos struct de duas maneiras.

            Nullable<double> x = null;
            double? y = 10;

            //GetValueOrDefault coloca na impressao o valor que possui na variavel ou coloca valor padrão. 

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //HasValue verifica se possui valor na variavel, se sim retorna true se não retorna false. 

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Value insere os valores, porém se houver algum nullo é quebrado a aplicação.

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é NULL");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é NULL");
            }

            //operador de coalescencia nula, nesse caso verifica se o valor de J é null caso sim é inserido o valor que está na variavel J

            Nullable<double> j = null;

            double l = j ?? 500;

            Console.WriteLine(l);
        }
    }
}
