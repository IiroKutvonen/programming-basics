using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna ikä: ");
                string userInput;
                userInput = Console.ReadLine();

                int hinta = 16;
                int ageMan;
                bool isAge = int.TryParse(userInput, out ageMan);

            if (isAge == true)

                {
                    if (ageMan >= 7)
                    {

                        Console.WriteLine("Oletko opiskelija? y/n");
                            string skyNetOpiskelija = Console.ReadLine();

                        Console.WriteLine("Oletko MTK jäsen? y/n");
                            string skyNetMTK = Console.ReadLine();

                        Console.WriteLine("Oletko varusmies? y/n");
                            string skyNetVarusmies = Console.ReadLine();

                            if (skyNetOpiskelija == "y" && skyNetMTK == "y")

                                {
                        Console.WriteLine($"Lipun hinta on {hinta * 0.4}");
                                }

                            else if (skyNetOpiskelija == "y")

                                {
                        Console.WriteLine($"Lipun hinta on {hinta * 0.55}");
                                }

                            else if (skyNetMTK == "y")

                                {
                        Console.WriteLine($"Lipun hinta on {hinta * 0.85}");
                                }

                            else if (skyNetVarusmies == "y")

                                {
                        Console.WriteLine($"Lipun hinta on {hinta * 0.5}");
                                }
                            
                            else

                                if (ageMan <= 15)

                                    {
                                        Console.WriteLine($"Lipun hinta on {hinta * 0.5}");
                                    }

                                else if (ageMan >= 65)

                                    {
                                        Console.WriteLine($"Lipun hinta on {hinta * 0.5}");
                                    }

                                else

                                    {
                                        Console.WriteLine($"Lipun hinta on {hinta}");
                                    }

                    }

                    else
                    {
                        Console.WriteLine("Lapsi pääsee ilmaiseksi.");
                    }

                } Console.ReadKey();
            }
        }
}
