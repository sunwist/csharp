﻿using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for(int i= 1; i <= n; i++) { 
                
                if( i % 2 != 0 )
                {
                    Console.WriteLine(i);
                }
            
            }

        }
    }
}

