using System;
using System.Globalization;
namespace Uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            float N1 = float.Parse(vet[0],CultureInfo.InvariantCulture);
            float N2 = float.Parse(vet[1],CultureInfo.InvariantCulture);
            float N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            float N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            float media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: "+ exame.ToString("F1",CultureInfo.InvariantCulture));
                media = (media + exame) / 2;
                
                if(media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else

                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));

            }
            


            Console.ReadKey();
        }
    }
}
