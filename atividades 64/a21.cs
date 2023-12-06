using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite um número inteiro (0 para sair): ");
                numero = int.Parse(Console.ReadLine());

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
                    continuar = false;
                }
            }
        }
    }
}
