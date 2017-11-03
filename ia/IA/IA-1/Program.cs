using System;

namespace IA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötteen viidesti.")
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{userInput}");
            }

            Console.ReadKey();
        }
    }
}
