using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            int[] y = { 4, 5, 6 };
            int n = x.Length; 

           
            int produtoEscalar = 0;
            for (int i = 0; i < n; i++)
            {
                produtoEscalar += x[i] * y[i];
            }

          
            Console.WriteLine($"O produto escalar entre x e y é {produtoEscalar}.");
        }
    }
}
