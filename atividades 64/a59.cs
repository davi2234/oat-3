using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 2 caracteres (em ordem alfabética): ");
            string entrada = Console.ReadLine();

            if (entrada.Length != 2 || entrada[0] >= entrada[1])
            {
                Console.WriteLine("Erro: caracteres inválidos.");
                return;
            }

            int numeroDeCaracteres = entrada[1] - entrada[0] - 1;

            Console.WriteLine("O número de caracteres entre os dois é: " + numeroDeCaracteres);
        }
    }
}
