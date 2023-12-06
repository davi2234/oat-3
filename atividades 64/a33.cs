using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaNotas = 0;
            int contadorAlunos = 0;

            while (true)
            {
                Console.Write("Digite a matrícula do aluno (ou um número negativo para sair): ");
                int matricula = int.Parse(Console.ReadLine());

                if (matricula < 0)
                {
                    break;
                }

                Console.Write("Digite a nota do aluno: ");
                double nota = double.Parse(Console.ReadLine());

                Aluno aluno = new Aluno(matricula, nota);
                somaNotas += nota;
                contadorAlunos++;
            }

            double mediaNotas = somaNotas / contadorAlunos;

            Console.WriteLine("Média das notas dos alunos: " + mediaNotas);
        }
    }
    }
}
