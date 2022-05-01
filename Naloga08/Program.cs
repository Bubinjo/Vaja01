// 8.naloga: Napiši program, ki bo uporabil spremenljivke ime, priimek, ulica in kraj tipa string, ter stevilka in posta tipa int. 
// Priredi jim svoje ime podatke, nato pa naj program izpiše tvoje ime, priimek in naslov v obliki: 
// Janez Novak 

// Pod vedrim nebom 14 

// 2000 Maribor 

// Za vsako spremenljivko uporabi pri izpisu en Console.Write oziroma Console.WriteLine.

using System;

namespace Naloga08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Janez";
            string priimek = "Novak";
            string ulica = "Pod vedrim nebom";
            string kraj = "Maribor";

            int stevilka = 14;
            int posta = 2000;

            Console.WriteLine(ime + " " + priimek);
            Console.WriteLine("");
            Console.WriteLine(ulica + " " + stevilka);
            Console.WriteLine("");
            Console.WriteLine(posta + " " + kraj);
        }
    }
}