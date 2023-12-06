using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números que deseja processar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }

            Console.ReadLine();
        }
    }
    }

