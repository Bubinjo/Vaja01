// 17.naloga: Napiši program, ki bo za vnešeni polmer kroga r izračunal obseg (2rπ) in površino kroga(r2π). 
// π naj ima vrednost 3.141 in naj bo v programu deklarirana kot konstanta.

using System;

namespace Naloga17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;

            Console.WriteLine("Vnesi polmer kroga za izracun obsega in povrsino kroga");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Obseg kroga je: {0}", 2 * r * pi);
            Console.WriteLine("Povrsina kroga je: {0}", pi * r * r);
        }
    }
}