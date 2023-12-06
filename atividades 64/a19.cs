using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o lado A do triângulo: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Informe o lado B do triângulo: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Informe o lado C do triângulo: ");
            double c = double.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados informados não formam um triângulo.");
            }
        }
    }
}
