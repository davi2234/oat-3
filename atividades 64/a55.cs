using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase (até 50 caracteres): ");
            string frase = Console.ReadLine();

          
            string fraseSemEspacos = frase.Replace(" ", "");

            
            int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;

            Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
            Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);
        }
    }
}
