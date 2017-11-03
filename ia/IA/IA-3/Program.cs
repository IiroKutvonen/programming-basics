using System;

namespace IA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy numeroita kunnes -1 syötetään ja laskee lukujen summan.");
            int userInput = 0;
            int sum = 0;

            while (userInput != -1)
            {
                Console.Write("Syötä luku: ");
                int.TryParse(Console.ReadLine(), out userInput);

                if (userInput == -1)
                {
                    break;
                }
                else
                {
                    sum = sum + userInput;
                }

            }

            Console.WriteLine($"Summa on {sum - 1}");
            Console.ReadKey();

        }
    }
}
