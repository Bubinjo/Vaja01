// Napiši program, ki prebere število v spremenljivko x tipa ushort in ga izpiše. Nato naj izvede ukaz ++x in izpiše x ter še ukaz x++ in izpiše x.
// Nato naj izpiše x++ (npr. s Console.WriteLine(++x) ), za tem x, za tem x++ in spet x.
// Opazuj, kdaj se izvede povečanje števila x pri uporabi ++x in kdaj pri x++.

using System;

namespace Naloga11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort x = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(++x);
            Console.WriteLine(x++);
            Console.WriteLine(x);
        }
    }
}