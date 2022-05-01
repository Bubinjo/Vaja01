// 19.naloga: Napiši program v katerem boš vnesel čas v sekundah, ga pretvoril v ure, minute in sekunde ter jih izpisal na zaslon.
// Bodi pozoren na format izpisa.
// Npr.: 123 s je 0 ur, 2 min in 3 s

using System;

namespace Naloga19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpisi cas v sekundah. Program ga bo pretvoril v ure, minute in sekunde");

            double cas = Convert.ToDouble(Console.ReadLine());

            double ure = (cas / 3600);
            double minute = (ure - (int)ure) * 60;
            Console.WriteLine(minute);
            double sekunde = (minute - (int)minute) * 60;
            Console.WriteLine(sekunde);

            int h = (int)ure;
            int m = (int)minute;
            //int s = (int)sekunde;

            Console.Write("\n");
            Console.WriteLine("{0} s je {1} ur, {2} min in {3, 0:F0} s", cas, h, m, sekunde);
        }
    }
}