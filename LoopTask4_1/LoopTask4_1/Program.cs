using System;

namespace LoopTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo syötetyn luvun (1-10) neliöjuuren");
            Console.WriteLine("#\tSQRT");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{Math.Sqrt(i)}");
            }
        }
    }
}
