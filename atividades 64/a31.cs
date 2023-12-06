using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, pares = 0, impares = 0;
            Console.WriteLine("Digite um número positivo ou um número negativo para sair:");

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("O número {0} é par", num);
                        pares += num;
                    }
                    else
                    {
                        Console.WriteLine("O número {0} é ímpar", num);
                        impares += num;
                    }
                }
            } while (num >= 0);

            Console.WriteLine("A soma dos números pares é {0}", pares);
            Console.WriteLine("A soma dos números ímpares é {0}", impares);
        }
    }
}
