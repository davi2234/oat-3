using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double r, h, v;

            Console.Write("Digite o raio da base da lata de óleo: ");
            r = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo: ");
            h = double.Parse(Console.ReadLine());

            v = pi * Math.Pow(r, 2) * h;

            Console.WriteLine("O volume da lata de óleo é: " + v.ToString("F2"));
        }
    }
}
