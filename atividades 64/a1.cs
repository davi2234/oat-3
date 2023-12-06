using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Digite a quantidade mínima: ");
            int qtdMinima = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima: ");
            int qtdMaxima = int.Parse(Console.ReadLine());

            
            double estoqueMedio = (qtdMinima + qtdMaxima) / 2.0;

          
            Console.WriteLine($"O estoque médio é: {estoqueMedio}");
        }
    }
}
