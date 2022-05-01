// Napiši program, ki prebere malo črko in jo spremeni v veliko črko ter jo izpiše.

using System;

namespace Naloga14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Char.ToUpper(x));
        }
    }
}