using System;

namespace newconditionsthefifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tulos;
        

            for (int i = 0; i < 12; i++)
            { 
               tulos = rnd.Next(0, 5);
                if (tulos < 2)
                    Console.WriteLine($"Kohde {i + 1}: 1");
                else if (tulos == 2)
                    Console.WriteLine($"Kohde {i + 1}: X");
                else
                    Console.WriteLine($"Kohde {i + 1}: 2");



            }
            Console.ReadKey();
        }
    }
}
