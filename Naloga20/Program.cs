// 20.naloga: Napiši program, ki izračuna BMI (ang. Body Mass Index). Formula je:
// BMI = teža[kg] / višina2[m2]
// Program naj omogoči vnos teže in višine (v kg in cm), na koncu pa naj izračuna in izpiše BMI na 3 decimalk.

using System;

namespace Naloga20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi tezo v kg: ");
            double teza = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vnesi visino v cm: ");
            double visina = Convert.ToDouble(Console.ReadLine());

            double bmi = teza / (visina * visina / 10000);

            Console.WriteLine("Tvoj BMI je: {0, 0:F3}", bmi);
        }
    }
}