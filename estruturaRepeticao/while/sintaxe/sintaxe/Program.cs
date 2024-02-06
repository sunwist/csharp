using System;
using System.Globalization;

namespace sintaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, raiz = 0;

            Console.WriteLine("Digite um número:");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x >= 0.0)
            {
                raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}