using System;

namespace Uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            int anos = i / 365;
            int anosMod = i % 365;

            int meses = anosMod / 30;
            int dias = anosMod % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
            Console.ReadKey();
        }
    }
}
