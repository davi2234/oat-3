using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, a = 0, b = 0;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                a = num;
            }
            else
            {
                b = num;
            }
            Console.WriteLine("A = {0}", a);
            Console.WriteLine("B = {0}", b);
        }
    }
}
