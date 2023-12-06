using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de voltas: ");
            int n = int.Parse(Console.ReadLine());

            double[] tempos = new double[n];
            double melhorTempo = double.MaxValue;
            int voltaMelhorTempo = 0;
            double somaTempos = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1}: ");
                tempos[i] = double.Parse(Console.ReadLine());

             
                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }

                somaTempos += tempos[i];
            }

            
            Console.WriteLine($"Melhor tempo: {melhorTempo:F2}s (volta {voltaMelhorTempo})");
            Console.WriteLine($"Tempo médio: {somaTempos / n:F2}s");
        }
    }
}
