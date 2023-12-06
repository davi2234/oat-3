using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maior = int.MinValue; // Valor mínimo para que qualquer número seja maior que ele
            int menor = int.MaxValue; // Valor máximo para que qualquer número seja menor que ele

            do
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }

            } while (numero != 0);

            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);

            Console.ReadLine();
        }
    }
    }
}
