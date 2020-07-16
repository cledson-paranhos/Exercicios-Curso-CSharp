using System;

namespace Uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0, fora = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            Console.ReadKey();

        }
    }
}
