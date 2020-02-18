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
            int leesett; 
            do
            {
                leesett = LeesoSorsolo(golyok);
                Kiíró(golyok);
                Console.WriteLine();
            } while (golyok.Contains(8));
            if (golyok.Count==0)
            {
                Console.WriteLine("Nyertél!");
            }
            else
            {
                Console.WriteLine("Vesztettél!");
            }
            Console.ReadKey();
        }

        static void Kiíró(List<int> golyok)
        {
            foreach (int golyo in golyok)
            {
                Console.Write($"{golyo} ");
            }
        }

        static int LeesoSorsolo(List<int> golyok)
        {
            Random rnd = new Random();
            int sorsolt = rnd.Next(golyok.Count);
            int seged = golyok[sorsolt];
            Console.WriteLine($"A leesett golyó: {seged}");
            golyok.Remove(golyok[sorsolt]);
            return seged;
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
