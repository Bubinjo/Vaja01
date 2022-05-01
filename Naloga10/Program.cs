// Napiši program, ki prebere dve števili tipa int in ju izpiše. 
// Nato naj izpiše še njuno vsoto, razliko, zmnožek, količnik in ostanek pri deljenju.
// Program večkrat zaženi in vpiši različne vrednosti. Kaj se zgodi, če je rezultat operacije število, ki je preveliko za izbrani tip?
// Kako dobimo zadnjo števko prvega števila?

// Uporabimo operacijo ostanek pri deljenju %
using System;

namespace Naloga10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvo, drugo;

            prvo = Convert.ToInt32(Console.ReadLine());
            drugo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Njuna vsota je: {0}", prvo + drugo);
            Console.WriteLine("Njuna razlika je: {0}", prvo - drugo);
            Console.WriteLine("Njun zmnozek je: {0}", prvo * drugo);
            Console.WriteLine("Njun kolicnik je: {0}", prvo / drugo);
            Console.WriteLine("Njun ostanek pri deljenju je: {0}", prvo % drugo);

        }
    }
}