using System;

namespace Tipo_Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo referencia não é usado como caixa, mas sim como ponteiro.

            Prod P = new Prod("TV", 500.0, 10);

            Prod p1 = P;

            Console.WriteLine(P);
            
            Console.WriteLine(p1);

            // Nesse caso o P1 está apontando para a variavel P que já foi instanciada. 
        }
    }
}
