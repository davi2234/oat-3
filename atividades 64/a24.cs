﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, escolha;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números lidos são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro");
                    }
                    break;
                case 2:
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares");
                    }
                    else
                    {
                        Console.WriteLine("Pelo menos um dos números não é par");
                    }
                    break;
                case 3:
                    double media = (num1 + num2) / 2.0;
                    if (media >= 7)
                    {
                        Console.WriteLine("A média dos dois números é maior ou igual a 7");
                    }
                    else
                    {
                        Console.WriteLine("A média dos dois números é menor que 7");
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
