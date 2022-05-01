// 7.naloga: Napiši program, ki bo za vse enostavne tipe (bool, char, sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal) 
// izpisal, koliko bytov zasedajo v pomnilniku, za vse razen bool pa še minimalno in maksimalno vrednost, ki jo lahko predstavijo.
// Primer: Console.WriteLine("Velikost int v bytih: {0}", sizeof(int)); 

using System;

namespace Naloga07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velikost char v bytih: {0}", sizeof(char));
            Console.WriteLine("Vrednosti od {0} do {1}\n", char.MinValue, char.MaxValue);

            Console.WriteLine("Velikost sbyte v bytih: {0}", sizeof(sbyte));
            Console.WriteLine("Vrednosti od {0} do {1}\n", sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("Velikost byte v bytih: {0}", sizeof(byte));
            Console.WriteLine("Vrednosti od {0} do {1}\n", byte.MinValue, byte.MaxValue);

            Console.WriteLine("Velikost short v bytih: {0}", sizeof(short));
            Console.WriteLine("Vrednosti od {0} do {1}\n", short.MinValue, short.MaxValue);

            Console.WriteLine("Velikost ushort v bytih: {0}", sizeof(ushort));
            Console.WriteLine("Vrednosti od {0} do {1}\n", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("Velikost int v bytih: {0}", sizeof(int));
            Console.WriteLine("Vrednosti od {0} do {1}\n", int.MinValue, int.MaxValue);

            Console.WriteLine("Velikost uint v bytih: {0}", sizeof(uint));
            Console.WriteLine("Vrednosti od {0} do {1}\n", uint.MinValue, uint.MaxValue);

            Console.WriteLine("Velikost long v bytih: {0}", sizeof(long));
            Console.WriteLine("Vrednosti od {0} do {1}\n", long.MinValue, long.MaxValue);

            Console.WriteLine("Velikost ulong v bytih: {0}", sizeof(ulong));
            Console.WriteLine("Vrednosti od {0} do {1}\n", ulong.MinValue, ulong.MaxValue);

            Console.WriteLine("Velikost float v bytih: {0}", sizeof(float));
            Console.WriteLine("Vrednosti od {0} do {1}\n", float.MinValue, float.MaxValue);

            Console.WriteLine("Velikost double v bytih: {0}", sizeof(double));
            Console.WriteLine("Vrednosti od {0} do {1}\n", double.MinValue, double.MaxValue);

            Console.WriteLine("Velikost decimal v bytih: {0}", sizeof(decimal));
            Console.WriteLine("Vrednosti od {0} do {1}\n", decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("Velikost bool v bytih: {0}", sizeof(bool));
        }
    }
}
