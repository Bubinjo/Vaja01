// 15.naloga: Napiši program, ki izračuna naslednjo enačbo s podanimi začetnimi vrednostmi spremenljivk: 
// int x = 9, y = 4; float a = 2.5f;
// y += (int)(x++ - (float)y-- / ++a);
// S pomočjo programa preveri vrednosti spremenljivk x, y in a, nato pa v komentarju napiši, kako se je izraz izvajal korak po korak, 
// da so spremenljivke dobile končne vrednosti.

using System;

namespace Naloga15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 4; float a = 2.5f;

            y += (int)(x++ - (float)y-- / ++a);

            Console.Write(y);
        }
    }
}