using System;

namespace newconditionsthethird
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma valitsee 20 satunnaista numeroa väliltä 0-50 ja tulostaa ne neljässä rivissä.");
            Random rnd = new Random();

            //for (int i = 0; i < 4; i++)
            //  {
            //   Console.Write($"Rivi {i}: ");
            //    for (int j = 0; j < 5; j++)
            //    {
            //      Console.Write($"{rnd.Next(0, 51)}, ");
            //  }
            //    Console.WriteLine();

            Console.WriteLine($"Rivi 1: {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}");
            Console.WriteLine($"Rivi 2: {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}");
            Console.WriteLine($"Rivi 3: {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}");
            Console.WriteLine($"Rivi 4: {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}, {rnd.Next(0, 51)}");

            Console.ReadKey();




        }
    }
}
