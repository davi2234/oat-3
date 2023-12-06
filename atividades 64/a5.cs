using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempoGasto, velocidadeMedia, distancia, litrosUsados;

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            tempoGasto = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média durante a viagem (em km/h): ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;
            litrosUsados = distancia / 12;

            Console.WriteLine("\nVelocidade média: " + velocidadeMedia.ToString("F2") + " km/h");
            Console.WriteLine("Tempo gasto: " + tempoGasto.ToString("F2") + " horas");
            Console.WriteLine("Distância percorrida: " + distancia.ToString("F2") + " km");
            Console.WriteLine("Litros de combustível utilizados: " + litrosUsados.ToString("F2"));
        }
    }
}
