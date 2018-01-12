using System;

namespace dis_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            int[] iT = new int[100];
            Random rnd = new Random();

            while (i < 99)
            {
                iT[i] = rnd.Next(1, 51);
                sum += iT[i];
                i++;
            }

            Console.WriteLine($"Keskiarvo on {sum / 100}");
            Console.ReadKey();
        }


    }
}
