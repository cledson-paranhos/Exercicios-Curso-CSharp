using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Aluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public bool AlunoAprovado()
        {
            if(NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Faltaram()
        {
            if (AlunoAprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
