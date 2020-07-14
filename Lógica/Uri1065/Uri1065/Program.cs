using System;

namespace Uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int aux = 0;
            if(num1 % 2 == 0)
            {
                aux = aux += 1;
            }if(num2 % 2 == 0)
            {
                aux = aux += 1;
            }if( num3 % 2 == 0)
            {
                aux = aux += 1;
            }if(num4 % 2 == 0)
            {
                aux = aux += 1;
            }if(num5 % 2 == 0)
            {
                aux = aux += 1;
            }
            Console.WriteLine(aux + " valores pares");
            Console.ReadKey();
        }
    }
}
