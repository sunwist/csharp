using System;
using System.Runtime.Versioning;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int valor = 0, dentro = 0, fora = 0;

            for(int i = 0; i < n; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}

