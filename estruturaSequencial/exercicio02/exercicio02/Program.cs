using System;
using System.Globalization;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio de um círculo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(2, raio);

            Console.WriteLine("Área: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}