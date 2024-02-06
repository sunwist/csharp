using System;
using System.Globalization;

namespace exercicioFixacao
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Console.Write("Qual a cotação do dólar? " + ConversorDeMoeda.cotacaoDolar.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Valor(dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}