using System;

namespace funk_on
{
    class Program
    {
        static void Main(string[] args)
        {
            int eka;
            Console.WriteLine("Syötä ensimmäinen luku.");
            int.TryParse(Console.ReadLine(), out eka);

            int toka;
            Console.WriteLine("Syötä toinen luku.");
            int.TryParse(Console.ReadLine(), out toka);

            Console.WriteLine($"Pienempi luku on: {vertailu(toka, eka)}");

            Console.ReadKey();
        }
        static int vertailu(int eka, int toka)
        {
            int vertaa;

            if (eka > toka)
            {
                vertaa = toka;
            }
            else if (toka > eka)
            {
                vertaa = eka;
            }

            return vertaa;
        }
    }
}
