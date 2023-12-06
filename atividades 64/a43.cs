using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numQuadros = 64;
            double numGraos = Math.Pow(2, numQuadros) - 1;

            Console.WriteLine($"O monge esperava receber {numGraos:N0} grãos de trigo.");
        }
    }
}
