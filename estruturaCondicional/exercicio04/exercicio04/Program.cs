using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicial, final, duracao = 0;

            string[] horas = Console.ReadLine().Split(' ');

            inicial= int.Parse(horas[0]);
            final= int.Parse(horas[1]); 

            if(inicial < final)
            {
                duracao = final - inicial;
                Console.WriteLine($"O jogo durou {duracao} horas");
            }
            else if(inicial > final)
            {
                duracao = (24 - inicial) + final;
                Console.WriteLine($"O jogo durou {duracao} horas");
            }
            else
            {
                Console.WriteLine("O jogo durou 24 horas");
            }
        }
    }
}
