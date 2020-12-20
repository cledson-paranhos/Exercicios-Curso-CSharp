using System;
using System.Globalization;
namespace Struct
{
    struct Carro
    {
        //atributos
        public string Marca;
        public string Modelo;
        public string Cor;
        public double Valor;

        //construtor com 4 parametros

        public Carro(string marca, string modelo, string cor, double valor)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Valor = valor;
        }

        public void Info()
        {
            Console.WriteLine("Marca: "+Marca);
            Console.WriteLine("Modelo: "+Modelo);
            Console.WriteLine("Cor: "+Cor);
            Console.WriteLine("Valor: "+ Valor.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
