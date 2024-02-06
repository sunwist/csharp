using System;
using System.Globalization;

namespace exercicio03
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFInal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Resultado()
        {
            if(NotaFInal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Resto()
        {
            if(Resultado() == false)
            {
                return 60.0 - NotaFInal();
            }
            else
            {
                return 0.0;
            }
        }
    }
}
