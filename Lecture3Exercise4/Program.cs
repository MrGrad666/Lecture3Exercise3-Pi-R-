using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;
            double r = 5, a = 2;
            double result = Math.Pow(r, a) * pi;
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
