using System;

namespace LoopTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo syötetyn luvun (1-9) kertotaulun");
            Console.WriteLine("Syötä luku: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{number}x{i}\t=\t{number*i}"); 
                
                

            }
        }
    }
}
