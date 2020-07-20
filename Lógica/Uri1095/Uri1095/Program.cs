using System;

namespace Uri1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 60;
            for(int i = 1 ; i <= 37 ; i += 3)
            {
                Console.WriteLine("I="+i+ " J="+ (j));
                j -= 5;  
            }
            Console.ReadKey();
        }
    }
}
