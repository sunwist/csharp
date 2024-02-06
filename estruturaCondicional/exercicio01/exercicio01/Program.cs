using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            if(numero >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}