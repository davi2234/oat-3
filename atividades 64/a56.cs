using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[50];
            int countPares = 0, countMultiplosDe5 = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    countPares++;
                }
                if (numeros[i] % 5 == 0)
                {
                    countMultiplosDe5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {countPares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {countMultiplosDe5}");
        }
    }
}
