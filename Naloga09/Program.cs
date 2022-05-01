// 9.naloga: Napiši program, ki bo uporabil spremenljivke ime, priimek in smer tipa string ter vpisnaStevilka tipa long. Priredi jim svoje podatke, 
// nato pa naj program izpiše: 
// »Tvoje ime je ime, tvoj priimek pa priimek.« 
// »Študiraš na smeri smer, tvoja vpisna številka je vpisnaStevilka .« 
// Nalogo reši tako, da uporabiš dva ukaza Console.WriteLine s parametri 
// Console.WriteLine("Tvoje ime je {0} ime …", ime, …);

using System;

namespace Naloga09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Danijel";
            string priimek = "Buba";
            string smer = "Informatika";

            long vpisnaStevilka = 00190700;

            Console.WriteLine("Tvoje ime je {0}, tvoj priimek pa {1}", ime, priimek);
            Console.WriteLine("Studiras na smeri {0}, tvoja vpisna stevilka je {1}", smer, vpisnaStevilka);
        }
    }
}