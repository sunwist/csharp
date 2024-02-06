using System;
using System.Globalization;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1, n2;
            double divisao = 0;

            for(int i = 0; i < n; i++) {

                string[] numeros = Console.ReadLine().Split(' ');

                n1 = int.Parse(numeros[0]);
                n2 = int.Parse(numeros[1]);

                if(n2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    divisao = (double) n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}

