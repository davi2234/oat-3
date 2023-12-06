using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            
            string resultado = Verifica(num);

            
            Console.WriteLine(resultado);
        }

        public static string Verifica(int n)
        {
           
            if (n % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";
            }
        }
    }
}
