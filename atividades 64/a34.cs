using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números positivos (para encerrar, digite um número negativo):");

            int numero = 0;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            while (true)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                    break;

                if (numero < menor)
                    menor = numero;

                if (numero > maior)
                    maior = numero;
            }

            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
        }
    }
}
