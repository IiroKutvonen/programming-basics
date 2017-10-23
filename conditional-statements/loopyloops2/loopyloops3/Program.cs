using System;

namespace loopyloops3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;
            int N = 0;
            int odd = 0;
            int even = 0;
            int i = 0;

            Console.Write("Syötä luku: ");

            if (isNumber = int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    for (i = 0; i <= N; i++)
                    {

                        if (i % 2 == 0)
                        {
                            even = even + i;
                        }

                        else if (i % 2 == 1)
                        {
                            odd = odd + i;
                        }
                else (N < 0)
                        for (i = 0; i >= N; i--)
                        {

                            if (i % 2 == 0)
                            {
                                even = even + i;
                            }

                            else if (i % 2 == 1)
                            {
                                odd = odd + i;
                            }

                        }

                        
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Parillisten summa on {even} ja parittomien {odd}");
                Console.ReadKey();
            }
        }
    }
}
