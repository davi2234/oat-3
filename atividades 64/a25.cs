using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o sexo (M ou F): ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());

            double pesoIdeal;

            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine($"O peso ideal para uma pessoa com altura {altura}m e sexo {sexo} é {pesoIdeal:F2}kg.");
        }
    }
    }

