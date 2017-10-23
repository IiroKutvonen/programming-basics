using System;

namespace loopyloops2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isNumber;
            int N = 0;
            int input;

            Console.Write("Syötä luku: ");

            if (isNumber = int.TryParse(Console.ReadLine(), out input))
            {
                if (input > 0)
                {
                    for (int i = 0; i <= input; i++)
                    {
                        N = N + i;
                    }

                    Console.WriteLine($"{N}");

                }
                else if (input < 0)
                {
                    for (int i = 0; i >= input; i--)
                    {
                        N = N + i;
                    }

                    Console.WriteLine($"{N}");
                }
            }

            Console.ReadKey();

        }
    }
}
