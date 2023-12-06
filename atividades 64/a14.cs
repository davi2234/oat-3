using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int diferenca = Math.Abs(num1 - num2); // Math.Abs retorna o valor absoluto

            if (num1 > num2)
            {
                Console.WriteLine($"A diferença entre {num1} e {num2} é {diferenca}.");
            }
            else
            {
                Console.WriteLine($"A diferença entre {num2} e {num1} é {diferenca}.");
            }
        }
    }
}
