using System;

namespace exercicio01
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return 2.0 * (largura + altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((largura * largura) + (altura * altura)); 
        }

    }
}
