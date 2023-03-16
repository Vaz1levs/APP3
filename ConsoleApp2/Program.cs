using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 0;
            Console.WriteLine(f = 2 * Math.Sin(x) + 3 * Math.Cos(x));
            Console.ReadKey();
        }
    }
}
