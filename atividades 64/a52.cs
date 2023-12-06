using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de alunos: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota do aluno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += notas[i];
            }

            double media = soma / n;
            Console.WriteLine($"Média aritmética: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            int acimaSete = 0;
            for (int i = 0; i < n; i++)
            {
                if (notas[i] > 7.0)
                {
                    acimaSete++;
                }
            }

            if (acimaSete > 0)
            {
                Console.WriteLine($"Alunos com nota acima de 7.0: {acimaSete}");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
            }
        }
    }
}
