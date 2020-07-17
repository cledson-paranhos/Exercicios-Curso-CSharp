using System;

namespace Uri1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrado = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    quadrado = i * i;
                    Console.WriteLine(i +"^"+ "2" +" = "+ quadrado );
                }
            }
            
            Console.ReadKey();
        }
    }
}
