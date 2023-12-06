using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int modulo;
            if (numero >= 0)
            {
                modulo = numero;
            }
            else
            {
                modulo = numero * (-1);
            }

            Console.WriteLine("O módulo do número digitado é: " + modulo);
        }
    }
}
    

