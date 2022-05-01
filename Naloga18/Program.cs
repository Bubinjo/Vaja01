// 18.naloga: Nekdo je zaprosil, da napišemo programček za izračun hitrosti pri prostem padu. 
// Formula je v=gt, pri čem je v hitrost, t čas in g gravitacija (9,81). Gravitacija naj bo v programu nespremenljiva (konstanta).
// Deklariraj in inicializiraj potrebne spremenljivke in napiši program, ki bo izračunal hitrost prostega padca po t sekundah.
// Rezultate prikaži v eksponentni obliki.

using System;

namespace Naloga18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.81;

            Console.Write("\n");
            Console.WriteLine("Vpisi cas trajanja prostega pada v sekundah");
            double t = Convert.ToDouble(Console.ReadLine());

            double v = g * t;

            Console.WriteLine("Hitrost po {0} sekundah prostega pada bo: {1, 0:e} m/s", t, v);
        }
    }
}