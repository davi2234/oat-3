using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números a serem lidos: ");
            int n = int.Parse(Console.ReadLine());

          
            int[] numeros = new int[n];

        
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

     
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += numeros[i];
            }
            double media = (double)soma / n;

         
            int maior = numeros[0];
            for (int i = 1; i < n; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            // exibe os resultados
            Console.WriteLine($"A média é {media:F2}");
            Console.WriteLine($"O maior número é {maior}");
        }
    }
}
