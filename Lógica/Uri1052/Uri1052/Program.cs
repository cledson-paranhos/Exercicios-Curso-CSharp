using System;

namespace Uri1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            if(valor == 1)
            {
                Console.WriteLine("January");
            }else if(valor == 2)
            {
                Console.WriteLine("February");
            }else if(valor == 3)
            {
                Console.WriteLine("March");
            }else if(valor == 4)
            {
                Console.WriteLine("April");
            }else if(valor == 5)
            {
                Console.WriteLine("May");
            }else if (valor == 6)
            {
                Console.WriteLine("June");
            }else if(valor == 7)
            {
                Console.WriteLine("July");
            }else if(valor == 8)
            {
                Console.WriteLine("August");
            }else if(valor == 9)
            {
                Console.WriteLine("September");
            }else if( valor == 10)
            {
                Console.WriteLine("October");
            }else if( valor == 11)
            {
                Console.WriteLine("November");
            }
            else 
            {
                Console.WriteLine("December");
            }
            Console.ReadKey();
        }
    }
}
