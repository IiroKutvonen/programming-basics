using System;

namespace SkyNet_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.Write("Y");
                if (userInput.Key.ToString() == "Y")
                    break;
                //string xxx = userInput.Key.ToString();
            }
            Console.WriteLine("Ohjelman suoritus päättyy");
            Console.ReadKey();
        }
    }
}
