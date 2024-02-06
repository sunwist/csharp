using System;

namespace Course
{
    class Triangulo
    {
        // atributos publicos, ou seja, podem ser usados em outros arquivos
        public double A;
        public double B;
        public double C;
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}