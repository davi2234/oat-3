using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, horasTrabalhadas;
            double salarioTotal, salarioExcedente = 0;

            char continuar = 'N';

            do
            {
                Console.Write("Informe o código do operário: ");
                codigo = int.Parse(Console.ReadLine());

                Console.Write("Informe o número de horas trabalhadas: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                if (horasTrabalhadas > 50)
                {
                    salarioExcedente = (horasTrabalhadas - 50) * 20.0;
                    salarioTotal = 50 * 10.0 + salarioExcedente;
                }
                else
                {
                    salarioTotal = horasTrabalhadas * 10.0;
                }

                Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
                Console.WriteLine($"Salário excedente: R$ {salarioExcedente:F2}");

                Console.Write("Deseja encerrar o programa? (S/N): ");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar != 'S' && continuar != 's');
        }
    }
}
