using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while( cod != 4)
            {
                if( cod == 1)
                {
                    alcool++;
                }else if( cod == 2)
                {
                    gasolina++;
                }else if ( cod == 3) 
                { 
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Digite Novamente:");
                }

                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

