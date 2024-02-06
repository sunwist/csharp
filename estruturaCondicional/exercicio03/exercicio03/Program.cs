using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multíplos");
            }
            else
            {
                Console.WriteLine("Não são multíplos");
            }

        }
    }
}
