using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            f = double.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine("A temperatura em graus Celsius é: " + c);
        }
    }
}
