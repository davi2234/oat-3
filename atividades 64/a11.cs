using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Antes da troca: a = {a}, b = {b}");
            Troca(ref a, ref b);
            Console.WriteLine($"Depois da troca: a = {a}, b = {b}");
        }

        public static void Troca(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
