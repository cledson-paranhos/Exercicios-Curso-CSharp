using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vect = new Pessoa[10];
            int cont = 1;

            Console.Write("Quantos quartos irá ser alugado: ");
            int n = int.Parse(Console.ReadLine());
     
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Rent #" + cont);
                cont++;

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[i] = new Pessoa { Name = name, Email = email, Room = room };

            }

            int aux;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(vect[i].Room > vect[j].Room)
                    {
                        aux = vect[j].Room;
                        vect[j].Room = vect[i].Room;
                        vect[i].Room = aux;
                    }
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Dados " + vect[i]);
                Console.WriteLine();
            }

        }
    }
}
