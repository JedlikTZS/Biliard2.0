using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biliárd2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyok = new List<int>();
            Feltolto(golyok);
            foreach (int golyo in golyok)
            {
                Console.WriteLine(golyo);
            }
            Console.ReadKey();
        }

        static void Feltolto(List<int> golyok)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyok.Add(i);
            }
        }
    }
}
