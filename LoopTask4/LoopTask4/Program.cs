using System;

namespace LoopTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetun luvun perusluvut yhteen. Myös negatiiviset");
            int number = 0;
            int i = 0;
            int sum = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("virheellinen syöte");
                }
            } while (number == 0);
            if (number > 0)
                {
                while (i <=number)
                {
                    sum = sum + i;
                    i = i + 1;

                
                }
                
            }
            else
            {
                while (i >=number)
                {
                    sum = sum + i;
                    i = i - 1;
                }

            }
            Console.WriteLine($"Luvun {number} summa = {sum}");
            
           
        }
    }
}

