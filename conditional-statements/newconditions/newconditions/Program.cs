using System;

namespace newconditions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ohjelma tulostaa luvut 1-10 ja tulostaa niiden neliöjuuret.");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{Math.Sqrt(i):f2}");
            }
            Console.ReadKey();    
            
        }
    }
}
