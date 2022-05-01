// 6.naloga: Pri prejšnji nalogi namenoma naredi nekaj napak (npr.: poskusi nepredznačenemu tipu vpisati negativno vrednost, 
// celemu številu, znaku ali nizurealno število, logični vrednosti znak, vpiši preveliko vrednost …) in opazuj, kaj se dogaja.

using System;

namespace Naloga06
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
            ushort my_ushort = -32; // prevajalnik ne prevede kode
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
