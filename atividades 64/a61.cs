using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a61
{
    internal class Program
    {
        public static double REAJUSTE(double salario, double indice)
        {
            double novoSalario = salario * (1 + indice / 100);
            return novoSalario;
        }

        public static void Main()
        {
            Console.Write("Digite o valor do salário atual: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.Write("Digite o índice de reajuste (em %): ");
            double indiceReajuste = double.Parse(Console.ReadLine());

            double novoSalario = REAJUSTE(salarioAtual, indiceReajuste);

            Console.WriteLine("O novo salário é R$ {0:F2}", novoSalario);
        }
    }
}