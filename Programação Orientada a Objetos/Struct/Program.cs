using System;
using System.Globalization;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colocando os valores diretos, usando o struct sempre deve iniciar com os valores
            Carro C;
            C.Marca = "Toyota";
            C.Modelo = "Hilux";
            C.Cor = "Branca";
            C.Valor = 80.000;

            Console.WriteLine("Marca: "+C.Marca);
            Console.WriteLine("Modelo: "+C.Modelo);
            Console.WriteLine("Cor: "+C.Cor);
            Console.WriteLine("Valor: "+ C.Valor.ToString("F3",CultureInfo.InvariantCulture));

            //O struct pode ser usado de 2 maneiras, colcocando valores direto ou usando comando new
            Console.WriteLine();
            C = new Carro("Vw", "Golf", "Preto", 50.00);
            C.Info();

            
            Console.WriteLine();
            Carro C1 = new Carro("BMW", "X7", "Prata", 60.000);
            C1.Info();
            
        }
    }
}
