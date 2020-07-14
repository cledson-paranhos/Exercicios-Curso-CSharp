using System;

namespace uri1066
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
            int positivo = 0, negativo = 0, par = 0, impar = 0; 
            if(num1 % 2 == 0)
            {
                par = par += 1;
            }
            else
            {
                impar = impar += 1;
            }
            if (num2 % 2 == 0)
            {
                par = par += 1;
            }
            else
            {
                impar = impar += 1;

            }

            if (num3 % 2 == 0)
            {
                par = par += 1;
            }
            else
            {
                impar = impar += 1;
            }

            if (num4 % 2 == 0)
            {
                par = par += 1;
            }
            else
            {
                impar = impar += 1;
            }

            if (num5 % 2 == 0)
            {
                par = par += 1;
            }
            else
            {
                impar = impar += 1;
            }
            
            if(num1 > 0)
            {
                positivo = positivo += 1;
            }
            else
            {
                negativo = negativo += 1;
            }
            if(num2 > 0)
            {
                positivo = positivo += 1;
            }
            else
            {
                
                negativo = negativo += 1;
                if(num2 == 0)
                {
                    negativo = negativo -= 1;
                }
            }if(num3 > 0)
            {
                positivo = positivo += 1;
            }
            else
            {
                negativo = negativo += 1;
            }if(num4 > 0)
            {
                positivo = positivo += 1;
            }
            else
            {
                negativo = negativo += 1;
            }if(num5 > 0)
            {
                positivo = positivo += 1;
            }
            else
            {
                negativo = negativo += 1;
            }
            
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar+ " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
            Console.ReadKey();
        }
    }
}
