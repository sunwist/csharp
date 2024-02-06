using System;
using System.Globalization;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double total = 0;

            string[] item = Console.ReadLine().Split(' ');

            cod = int.Parse(item[0]);
            qtd = int.Parse(item[1]);

            if( cod == 1)
            {
                Console.WriteLine("Cachorro Quente");
                total = qtd * 4.0;

                Console.WriteLine("Valor a Pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }else if( cod == 2)
            {
                Console.WriteLine("X-Salada");
                total = qtd * 4.5;

                Console.WriteLine("Valor a Pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }else if( cod == 3 )
            {
                Console.WriteLine("X-Bacon");
                total = qtd * 5.0;

                Console.WriteLine("Valor a Pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }else if( cod == 4 )
            {
                Console.WriteLine("Torrada Simples");
                total = qtd * 2.0;

                Console.WriteLine("Valor a Pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 5)
            {
                Console.WriteLine("Refrigerante");
                total = qtd * 1.5;

                Console.WriteLine("Valor a Pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Não temos essa opção");
            }
        }
    }
}
