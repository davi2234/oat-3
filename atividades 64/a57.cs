using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            string vogais = "aeiouAEIOU"; // string com todas as vogais

            Console.WriteLine("Vogais na frase:");
            foreach (char letra in frase)
            {
                if (vogais.Contains(letra))
                {
                    Console.Write(letra);
                }
            }
    }
}
