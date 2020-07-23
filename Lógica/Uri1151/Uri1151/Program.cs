using System;

namespace Uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if(i == n - 1)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.Write(num1 + " ");
                }
                int aux = num2;
                num2 = num1;
                num1 = aux + num2;
                
            }
            Console.ReadKey();
        }
    }
}
