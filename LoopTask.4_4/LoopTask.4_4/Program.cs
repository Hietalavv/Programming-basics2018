using System;

namespace LoopTask._4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi rahan heittoa(Kruunu ja klaava)");
            bool validNumber;
            bool isNegative;
            int converted;


            do
            {
                Console.Write("Syötä heittomäärä:");

                string inputStr = Console.ReadLine();
                validNumber = int.TryParse(inputStr, out converted);

                if (!validNumber || converted < 1)
                {
                    Console.WriteLine("Väärä syöte");
                    Console.WriteLine();
                    validNumber = false;
                }
            } while (!validNumber);

            Random rnd = new Random();
            int headsCount = 0;
            int tailsCount = 0;

            for (int i = 1; i <= converted; i++)
            {
                int x = rnd.Next(2);

                if (x == 0)
                {
                    tailsCount += 1;
                }
                else
                {
                    headsCount += 1;
                }


            }
            Console.WriteLine("Heitetty {0} kertaa.", converted);
            Console.WriteLine("Klaava {0} ja kruunu {1}.", tailsCount, headsCount);

        }
    }
}
