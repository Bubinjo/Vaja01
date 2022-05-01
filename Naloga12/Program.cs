// 12.naloga: Napiši program, ki prebere dve števili tipa float in ju izpiše. Nato naj izpiše še njuno vsoto, razliko, zmnožek in količnik.

using System;

namespace Naloga12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = Convert.ToSingle(Console.ReadLine());
            float y = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.Write("\n");
            Console.WriteLine("Njuna vsota je: {0}", x + y);
            Console.WriteLine("Njuna razlika je: {0}", x - y);
            Console.WriteLine("Njun zmnozek je: {0}", x * y);
            Console.WriteLine("Njun kolicnik je: {0}", x / y);
        }
    }
}