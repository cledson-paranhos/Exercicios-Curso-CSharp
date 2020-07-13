using System;

namespace Uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            int aux;

            if (num1 > num2)
            {
                aux = num2;
                num2 = num1;
                num1 = aux;
            }
            if (num1 > num3)
            {
                aux = num3;
                num3 = num1;
                num1 = aux;
            }
            if(num2 > num3)
            {
                aux = num3;
                num3 = num2;
                num2 = aux;
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine();
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

            Console.ReadKey();
        }
    }
}
