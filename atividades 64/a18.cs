using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro (1, 2 ou 3): ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
    

