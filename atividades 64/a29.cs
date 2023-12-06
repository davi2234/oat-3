using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
