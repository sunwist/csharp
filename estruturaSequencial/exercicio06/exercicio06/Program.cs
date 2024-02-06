using System;
using System.Globalization;

namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = pi * c * c;
            trapezio = ((a + b) * c) / 2.0;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
} 