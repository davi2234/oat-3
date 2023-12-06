using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            onsole.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}° número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequência na ordem inversa:");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
