using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            Console.WriteLine("hasil penambahan "+a+" + "+b "=" + Penambahan(a,b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}",a,b pengurangan (a,b));
            Console.WriteLine()
        }
        static int Penambahan(int a, int b)

        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
    }
}