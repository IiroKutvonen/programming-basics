using System;

namespace newconditionsthethird
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma valitsee 20 satunnaista numeroa väliltä 0-50 ja tulostaa ne neljässä rivissä.");
            Random rnd = new Random();

            for (int i = 1; i < 20; i++)
            {
                rnd.Next(0,51);
            }


        


        }
    }
}
