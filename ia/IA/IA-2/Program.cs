using System;

namespace IA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötteen kirjainten verran syötteen uudestaan.");
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine();
            string characters = userInput.Replace(" ", "");
            int count = characters.Length;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{userInput}");
            }

            Console.ReadKey();
        }
    }
}
