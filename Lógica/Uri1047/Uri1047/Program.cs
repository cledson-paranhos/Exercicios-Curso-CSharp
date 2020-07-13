using System;

namespace Uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int minutoInicial = int.Parse(vet[1]);
            int horaFinal = int.Parse(vet[2]);
            int minutofinal = int.Parse(vet[3]);

            int duracao;
            int inicio = horaInicial * 60 + minutoInicial;
            int final = horaFinal * 60 + minutofinal;
            if(inicio < final)
            {
                duracao = final - inicio;
            }
            else
            {
                duracao = (24 * 60 - inicio) + final;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

            Console.ReadKey();
        }
    }
}
