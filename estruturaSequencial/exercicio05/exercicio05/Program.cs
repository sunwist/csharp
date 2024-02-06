using System;
using System.Globalization;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, qtd1, cod2, qtd2;
            double valor1, valor2, total;

            Console.WriteLine("Peça 1:");

            string[] peca1 = Console.ReadLine().Split(' ');

            cod1 = int.Parse(peca1[0]);
            qtd1 = int.Parse(peca1[1]);
            valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Peça 2:");

            string[] peca2 = Console.ReadLine().Split(' ');

            cod2 = int.Parse(peca2[0]);
            qtd2 = int.Parse(peca2[1]);
            valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            total = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}