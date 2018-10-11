using System;

namespace LoopTask1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo annetun luvun summan");
            int number = 0;
            int i = 1;
            int fact = 1;
            do
            {
                Console.Write("syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0) 
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            } while (number <= 0);

            while (i <=number)
            {
                fact = fact * i; //i++;
                i = i + 1; //i++;
               
            }
            Console.WriteLine($"Luvun {number}! = {fact}");

        }

    }
}
