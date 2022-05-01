// 5. naloga: Ustvari pa eno spremenljivko vseh enostavnih tipov 
// (bool, char, sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal) in tipa string.
// Vsaki priredi neko vrednost, nato pa jo izpiši v obliki »spremenljivka = vrednost«, na primer »x = -23435«.
// To dosezi z lepljenjem vrednosti spremenljivke h konstantnemu nizu ("x = " + x).

using System;

namespace Naloga05
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

            Console.WriteLine("spremeljivka " + nameof(my_bool) + " = " + my_bool);
            Console.WriteLine("spremeljivka " + nameof(my_char) + " = " + my_char);
            Console.WriteLine("spremeljivka " + nameof(my_sbyte) + " = " + my_sbyte);
            Console.WriteLine("spremeljivka " + nameof(my_byte) + " = " + my_byte);
            Console.WriteLine("spremeljivka " + nameof(my_short) + " = " + my_short);
            Console.WriteLine("spremeljivka " + nameof(my_ushort) + " = " + my_ushort);
            Console.WriteLine("spremeljivka " + nameof(my_int) + " = " + my_int);
            Console.WriteLine("spremeljivka " + nameof(my_uint) + " = " + my_uint);
            Console.WriteLine("spremeljivka " + nameof(my_long) + " = " + my_long);
            Console.WriteLine("spremeljivka " + nameof(my_ulong) + " = " + my_ulong);
            Console.WriteLine("spremeljivka " + nameof(my_float) + " = " + my_float);
            Console.WriteLine("spremeljivka " + nameof(my_double) + " = " + my_double);
            Console.WriteLine("spremeljivka " + nameof(my_decimal) + " = " + my_decimal);
            Console.WriteLine("spremeljivka " + nameof(my_string) + " = " + my_string);
        }
    }
}