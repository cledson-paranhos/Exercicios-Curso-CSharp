using System;

namespace Uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);
            int horaTotal = 24;
            
            if(horaInicio > horaFinal)
            {
                Console.WriteLine("O JOGO DUROU " + (horaTotal - horaInicio + horaFinal)+ " HORA(S)");
            }else if(horaInicio == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU " + horaTotal +" HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + (horaFinal - horaInicio) + " HORA(S)");
            }

            Console.ReadKey();
        }
    }
}
