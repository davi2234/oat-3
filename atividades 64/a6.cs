using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit.ToString("F1"));
        }
    }
}
