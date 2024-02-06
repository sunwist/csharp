﻿using System;
using System.Globalization;

namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0, y = 0.0;

            string[] valores = Console.ReadLine().Split(' ');

            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if ( x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }else if( x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}

