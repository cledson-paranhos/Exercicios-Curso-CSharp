using System;

namespace Uri1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                aux =0;
                for(int j = 1; j <= x; j++){
                    if(x % j == 0){
                        aux++;
                    }
                }
                if (aux == 2)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }     
            }
        }
    }
}
