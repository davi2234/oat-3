using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());


            double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

            if (media >= 7.0)
            {
                
                Console.WriteLine($"O aluno foi aprovado com média {media:F2}");
            }
            else
            {
                
                Console.Write("Digite a nota da recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());

             
                double novaMedia = (media + notaRecuperacao) / 2.0;

                if (novaMedia >= 7.0)
                {
                   
                    Console.WriteLine($"O aluno foi aprovado na recuperação com média {novaMedia:F2}");
                }
                else
                {
                    
                    Console.WriteLine($"O aluno não foi aprovado, média final {novaMedia:F2}");
                }
            }
        }
    }
}
