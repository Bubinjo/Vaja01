// 13.naloga: Napiši program, ki prebere dve realni števili, eno tipa float, drugo double in shrani njun seštevek v spremenljivko tipa float, 
// zmnožek pa v spremenljivko tipa double. Po potrebi uporabi prisiljeno pretvorbo med tipi.

using System;

namespace Naloga13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = Convert.ToSingle(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            float sestevek = x + (float)y;
            Console.WriteLine(sestevek);

            double zmnozek = (double)x * y;
            Console.WriteLine(zmnozek);
        }
    }
}