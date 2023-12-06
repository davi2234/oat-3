using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int idadeEmDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine($"A idade em dias é: {idadeEmDias}");
        }
    }
}
