using System;

namespace newconditionsthefourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää kolikkoa kertoo heittojen määrän ja tulokset.");
            int.TryParse(Console.ReadLine(), out int N);
            Random rnd = new Random();
            int flip;
            int ruuna = 0;
            int laava = 0;

            for (int i = 0; i < N; i++)
            {
                flip = rnd.Next(1, 3);

                if (flip % 2 == 1)
                {
                    ruuna = ruuna + 1;
                }

                else
                {
                    laava = laava + 1;
                }
            }
            Console.WriteLine($"Kolikkoa heitettiin {N} kertaa. Heitoista {ruuna} oli kruunuja ja {laava} oli klaavoja.");
            Console.ReadKey();

        }
    }
}
