using System;

namespace newconditionsthesecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulut luvuille 1-9.");

            for (int i = 1; i < 10; i++)
            {
                
                
                    for (int j = 1; j < 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                

                
            }
            Console.ReadKey();
        }
    }
}
