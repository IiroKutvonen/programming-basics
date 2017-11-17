using System;

namespace funk_on2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy lukua väliltä 1-10");

            int lowerBound;
            int upperBound;
            int luku;

            Console.WriteLine("Syötä luku.");
            int.TryParse(Console.ReadLine(), out luku);


            static int vertailu(int luku)
            {
                if (luku < 1 && luku > 10)
                {
                    Console.WriteLine("Luku ei ole väliltä 1-10");
                }
                else
                {
                    Console.WriteLine("Luku on väliltä 1-10");
                }
            }
            retNumber = numberFromRange(lowerBound, upperBound);
        }
    }
}
