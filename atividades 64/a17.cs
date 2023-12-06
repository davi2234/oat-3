using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
    }
}
}
