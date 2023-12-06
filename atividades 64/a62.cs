using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo, alturaTriangulo;
            Console.Write("Digite o valor da base do triângulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do triângulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine($"A hipotenusa do triângulo é {Hipotenusa(baseTriangulo, alturaTriangulo):F2}");
        }

        public static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return hipotenusa;
        }
    }
    }

