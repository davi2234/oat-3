using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta = 'N';
            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }

                Console.Write("Deseja encerrar o programa? (S/N) ");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta != 'S' && resposta != 's');
        }
    }
}
