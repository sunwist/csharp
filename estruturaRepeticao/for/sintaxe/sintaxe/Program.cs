using System;

namespace sintaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd, num, soma = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Valor {i + 1}:");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}

