﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int maior, menor;

            Console.WriteLine("Digite três valores inteiros maiores que zero:");

            do
            {
                Console.Write("Valor de A: ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.Write("Valor de B: ");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);

            do
            {
                Console.Write("Valor de C: ");
                c = int.Parse(Console.ReadLine());
            } while (c <= 0);

            maior = Math.Max(a, Math.Max(b, c));
            menor = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("Menor valor multiplicado pelo maior valor: " + (maior * menor));
            Console.WriteLine("Maior valor dividido pelo menor valor: " + ((double)maior / menor));
        }
    }
}
