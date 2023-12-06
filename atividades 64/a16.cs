using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a16
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

            if (num1 > num2)
            {
                Console.WriteLine("Maior número: " + num1);
                Console.WriteLine("Menor número: " + num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Maior número: " + num2);
                Console.WriteLine("Menor número: " + num1);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais: " + num1);
            }
        }
    }
}
