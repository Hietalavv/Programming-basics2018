using System;

namespace LoopTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Ohjelma laskee parittomien ja parillisten lukujen summan, myös negatiiviset");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                while (i <= number)
                {
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i; //juu
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                    i++;

                }

            }
            else
            {
                while (i >= number)
                {

                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                    i--;
                }
            }



            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"Parittomien summa on {oddSum}");

        }
    }
}
