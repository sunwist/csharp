using System;
using System.Globalization;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args) 
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}