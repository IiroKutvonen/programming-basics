using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                if (isNumber == true)

                {

                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Luku {evaluatedNumber} on negatiivinen.");
                    }

                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Luku {evaluatedNumber} on positiivinen.");
                    }

                    else
                    {
                        Console.WriteLine($"Luku {evaluatedNumber} on nolla.");
                    }

                }

                else

                {

                    Console.WriteLine("Ei ole numero.");

                }

            } while (isNumber == false);
            Console.ReadKey();
        }
    }
}