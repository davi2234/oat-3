﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + numero + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.ReadKey();
        }
    }
}
