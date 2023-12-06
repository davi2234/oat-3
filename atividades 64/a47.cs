using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int numeroX, maioresX = 0, menoresX = 0, iguaisX = 0;

            // leitura do vetor
            Console.WriteLine("Digite 10 números inteiros positivos maiores que zero:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // leitura do número X
            Console.Write("Digite um número inteiro positivo maior que zero: ");
            numeroX = int.Parse(Console.ReadLine());

            // contagem dos números maiores, menores e iguais a X
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > numeroX)
                {
                    maioresX++;
                }
                else if (vetor[i] < numeroX)
                {
                    menoresX++;
                }
                else
                {
                    iguaisX++;
                }
            }

            // exibição dos resultados
            Console.WriteLine("Números maiores que X: {0}", maioresX);
            Console.WriteLine("Números menores que X: {0}", menoresX);
            Console.WriteLine("Números iguais a X: {0}", iguaisX);

            Console.ReadLine(); // espera o usuário pressionar Enter para encerrar
        }
    }
}
