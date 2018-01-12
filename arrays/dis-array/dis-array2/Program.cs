using System;

namespace dis_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] iT = new int[7];
            Random rnd = new Random();

            while (i < 6)
            {
                iT[i] = rnd.Next(1, 40);
                i++;
            }


        }
    }
}
