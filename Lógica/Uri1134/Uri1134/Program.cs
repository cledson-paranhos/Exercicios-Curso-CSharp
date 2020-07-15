using System;

namespace Uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;
            while(combustivel != 4)
            {
                if(combustivel == 1)
                {
                    alcool = alcool + 1;
                }else if( combustivel == 2)
                {
                    gasolina = gasolina + 1;
                }else if(combustivel == 3)
                {
                    diesel = diesel + 1;
                }
                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ alcool);
            Console.WriteLine("Gasolina: "+ gasolina);
            Console.WriteLine("Diesel: "+diesel);
            Console.ReadKey();
        }
    }
}
