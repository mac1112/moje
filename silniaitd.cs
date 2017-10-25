using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int zakres = 50;
            List<int> lotki = new List<int>(zakres);

            for (int i = 1; i <= zakres; i++)
            {
                lotki.Add(i);
            }
            Random nazwa = new Random();
            for (int i = 0; i <= 6; i++)
            {
                
                int liczba = nazwa.Next(0,zakres);
                Console.WriteLine(lotki[liczba]);
                zakres--;
                lotki.Remove(liczba);
            }
            
            Console.ReadKey();
        }
    }
}
