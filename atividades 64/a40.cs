using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double indicePoluicao;
            char continuar;

            do
            {
                Console.WriteLine("Informe o índice de poluição medido:");
                indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indicePoluicao > 0.25 && indicePoluicao < 0.3)
                {
                    Console.WriteLine("Atenção: Indústrias do 1º grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
                {
                    Console.WriteLine("Atenção: Indústrias do 1º e 2º grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
                {
                    Console.WriteLine("Atenção: Indústrias do 1º, 2º e 3º grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Atenção: Todas as indústrias devem paralisar suas atividades.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar != 'S' && continuar != 's');
        }
    }
}
