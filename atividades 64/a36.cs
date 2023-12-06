using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int maior, menor;
            double media;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            maior = Maior(numeros);
            menor = Menor(numeros);
            media = Media(numeros);

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
            Console.WriteLine($"A média dos números é: {media}");
        }

        public static int Maior(int[] numeros)
        {
            int maior = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            return maior;
        }

        public static int Menor(int[] numeros)
        {
            int menor = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            return menor;
        }

        public static double Media(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return (double)soma / numeros.Length;
        }
    }
}
