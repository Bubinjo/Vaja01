// Napiši program, ki prebere 5 celih števil različne dolžine (npr. 2, -394, 20048, 34, 8002) in jih izpiše v naslednji obliki: 
// 1.število je: 2
// 2.število je: -394
// 3.število je: 20048
// 4.število je: 34
// 5.število je: 8002

// Za formatiranje izpisa širino 6 z desno poravnavo.

using System;

namespace Naloga16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvo = Convert.ToInt32(Console.ReadLine());
            int drugo = Convert.ToInt32(Console.ReadLine());
            int tretje = Convert.ToInt32(Console.ReadLine());
            int cetrto = Convert.ToInt32(Console.ReadLine());
            int peto = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("1. stevilo je: {0, 6}", prvo);
            Console.WriteLine("2. stevilo je: {0, 6}", drugo);
            Console.WriteLine("3. stevilo je: {0, 6}", tretje);
            Console.WriteLine("4. stevilo je: {0, 6}", cetrto);
            Console.WriteLine("5. stevilo je: {0, 6}", peto);

        }
    }
}