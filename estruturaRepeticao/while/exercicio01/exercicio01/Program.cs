using System;
using System.Globalization;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());
            int senhacorreta = 2002;

            while( senha != senhacorreta)
            {
                Console.WriteLine("Senha Inválida!");
                senha = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}