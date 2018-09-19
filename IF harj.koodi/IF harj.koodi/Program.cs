using System;

namespace iftask1
{
    //this on line comment 
    class Program
    {
        
        static void Main(string[] args)
            
        {
        
         Console.WriteLine("Program solves if the given number is positive, negative or zero.");
            Console.WriteLine("Syötä numero");
         string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"Numero {number} on negatiivinen");
            else
                Console.WriteLine($"Numero {number} on positiivinen");

                    
        }
    }
}
