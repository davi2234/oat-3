﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite três números inteiros:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int maior, segundoMaior, menor;

            // Verifica qual é o maior número
            if (a >= b && a >= c)
            {
                maior = a;
                if (b >= c)
                {
                    segundoMaior = b;
                    menor = c;
                }
                else
                {
                    segundoMaior = c;
                    menor = b;
                }
            }
            else if (b >= a && b >= c)
            {
                maior = b;
                if (a >= c)
                {
                    segundoMaior = a;
                    menor = c;
                }
                else
                {
                    segundoMaior = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a >= b)
                {
                    segundoMaior = a;
                    menor = b;
                }
                else
                {
                    segundoMaior = b;
                    menor = a;
                }
            }

          
            Console.WriteLine(maior + " " + segundoMaior + " " + menor);
        }
    }
}
    

