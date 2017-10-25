using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace M1
{
    class Program
    {
        static double M(double m)
        {
            //double m0 = 1;
            //double m1 = -3.0/4.0;
            //double m2 = 1.5;

            if (m == 0)
                return 1;
            if (m == 1)
                return -3.0 / 4.0;
            if (m == 2)
                return 1.5;
            return M(m - 3) * 0.5 * M(m - 2) - 5 / 4.0 * M(m - 1);
        }
        static void Main(string[] args)
        {
            // var liczba = -3.0 / 4.0;
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(M(5));
            //Console.WriteLine(liczba);
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
