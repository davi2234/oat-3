using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            onst int MAX = 50; /
            int[] v1 = new int[MAX];
            int[] v2 = new int[MAX];
            int n, i, count = 0;

            Console.Write("Digite o tamanho dos vetores (no máximo 50): ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os elementos do vetor V1:");
            for (i = 0; i < n; i++)
            {
                Console.Write("V1[" + i + "]: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite os elementos do vetor V2:");
            for (i = 0; i < n; i++)
            {
                Console.Write("V2[" + i + "]: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

          
            for (i = 0; i < n; i++)
            {
                if (v1[i] == v2[i])
                {
                    count++;
                }
            }

            Console.WriteLine("\nNúmero de valores idênticos nas mesmas posições: " + count);
        }
    }
}
