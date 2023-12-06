using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Igual");
            }
            else
            {
                Console.WriteLine("Não igual");
                if (num1 > num2)
                {
                    Console.WriteLine("Maior");
                    Console.WriteLine("Maior ou igual");
                    Console.WriteLine("Menor");
                    Console.WriteLine("Menor ou igual");
                }
                else
                {
                    Console.WriteLine("Menor");
                    Console.WriteLine("Menor ou igual");
                    Console.WriteLine("Maior");
                    Console.WriteLine("Maior ou igual");
                }
    }
}
    }
}
