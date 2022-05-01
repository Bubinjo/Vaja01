// 4.naloga: Ustvari pa eno spremenljivko vseh enostavnih tipov
// (bool, char, sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal) in tipa string.
// Vsaki priredi neko vrednost, nato pa izpiši vse vrednosti, vsako v svoji vrstici (uporabi Console.WriteLine)

using System;

namespace Naloga04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool my_bool = true;
            char my_char = 'b';
            sbyte my_sbyte = 20;
            byte my_byte = 30;
            short my_short = 31;
            ushort my_ushort = 32;
            int my_int = 33;
            uint my_uint = 34;
            long my_long = 35;
            ulong my_ulong = 36;
            float my_float = 37.1f;
            double my_double = 38.2;
            decimal my_decimal = 39;
            string my_string = "hello";

            Console.WriteLine(my_bool);
            Console.WriteLine(my_char);
            Console.WriteLine(my_sbyte);
            Console.WriteLine(my_byte);
            Console.WriteLine(my_short);
            Console.WriteLine(my_ushort);
            Console.WriteLine(my_int);
            Console.WriteLine(my_uint);
            Console.WriteLine(my_long);
            Console.WriteLine(my_ulong);
            Console.WriteLine(my_float);
            Console.WriteLine(my_double);
            Console.WriteLine(my_decimal);
            Console.WriteLine(my_string);
        }
    }
}