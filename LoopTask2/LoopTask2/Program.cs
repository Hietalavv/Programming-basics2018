using System;

namespace LoopTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetun luvun perusluvut yhteen");
            int number = 0;
            int i = 1;
            int sum = 1;
            do
            {
                Console.Write("syötä Luku; ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("virheellinen syöte!");
                }
            } while (number <= 0);
            
            while (i <=number)
            {
                sum = sum + i; 
                i = i + 1; 
            }
            Console.WriteLine($"Luvun {number}! = {sum}");

        }
    }
}
