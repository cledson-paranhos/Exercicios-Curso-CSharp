using System;

namespace Uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = 0, SomaInter = 0, empate = 0, somaGremio = 0, cont = 0;
            while(repeticao != 2)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int inter = int.Parse(vet[0]);
                int gremio = int.Parse(vet[1]);
                cont++;
                if(inter > gremio)
                {
                    SomaInter++;
                }else if(gremio == inter)
                {
                    empate++;
                }
                else
                {
                    somaGremio++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repeticao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:"+ SomaInter);
            Console.WriteLine("Gremio:"+ somaGremio);
            Console.WriteLine("Empates:"+ empate);
            if(SomaInter > somaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }else if( SomaInter == somaGremio)
            {
                Console.WriteLine("Nao houve vencedor");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
           
            Console.ReadKey();
        }
    }
}
