using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Iteracja

{
    class Program
    {
        static void M()
        {
            double[] tab = new double[100];
            tab[0] = 1;
            tab[1] = -3.0 / 4.0;
            tab[2] = 1.5;

            Console.Write("Podaj liczbę: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i < 100; i++)
            {
                tab[i] = tab[i - 3] * 0.5 * tab[i - 2] - 5 / 4.0 * tab[i - 1];
            }
            Console.WriteLine(tab[n]);
        }
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            M();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
