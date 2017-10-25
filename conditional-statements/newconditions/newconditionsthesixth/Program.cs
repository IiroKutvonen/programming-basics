using System;

namespace newconditionsthesixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int noppa;
            int kutonen = 0;
            int vitonen = 0;
            int nelonen = 0;
            int kolmonen = 0;
            int kakkonen = 0;
            int ukone = 0;

            for (int i = 0; i < 1000; i++)
            {
                noppa = rnd.Next(1, 7);
                Console.WriteLine($"{i + 1}. {noppa}");

                if (noppa == 6)
                    kutonen++;
                else if (noppa == 5)
                    vitonen++;
                else if (noppa == 4)
                    nelonen++;
                else if (noppa == 3)
                    kolmonen++;
                else if (noppa == 2)
                    kakkonen++;
                else
                    ukone++;
            }
            Console.WriteLine($"Kuutosia heitettiin yhteensä {kutonen} kertaa.");
            Console.WriteLine($"Viitosia heitettiin yhteensä {vitonen} kertaa.");
            Console.WriteLine($"Nelosia heitettiin yhteensä {nelonen} kertaa.");
            Console.WriteLine($"Kolmosia heitettiin yhteensä {kolmonen} kertaa.");
            Console.WriteLine($"Kakkosia heitettiin yhteensä {kakkonen} kertaa.");
            Console.WriteLine($"Ykkösiä heitettiin yhteensä {ukone} kertaa.");
            Console.ReadKey();
        }
    }
}
}
