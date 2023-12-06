using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor em dólares: ");
            double valorDolar = double.Parse(Console.ReadLine());

            double valorReal = valorDolar * cotacao;

            Console.WriteLine("O valor em reais é: " + valorReal);
        }
    }
}
