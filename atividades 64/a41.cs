using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            while (true)
            {
                Console.Write("Digite a idade do nadador (ou S para sair): ");
                string input = Console.ReadLine();
                if (input.ToUpper() == "S") break;

                if (int.TryParse(input, out idade))
                {
                    string categoria;

                    if (idade >= 5 && idade <= 7)
                    {
                        categoria = "Infantil A";
                    }
                    else if (idade >= 8 && idade <= 11)
                    {
                        categoria = "Infantil B";
                    }
                    else if (idade >= 12 && idade <= 13)
                    {
                        categoria = "Juvenil A";
                    }
                    else if (idade >= 14 && idade <= 17)
                    {
                        categoria = "Juvenil B";
                    }
                    else if (idade >= 18)
                    {
                        categoria = "Adultos";
                    }
                    else
                    {
                        categoria = "Idade inválida";
                    }

                    Console.WriteLine("Categoria: {0}\n", categoria);
                }
                else
                {
                    Console.WriteLine("Valor inválido\n");
                }
            }
    }
}
}
