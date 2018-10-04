using System;

namespace Lipun_hinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo linpun hinnan alennuksineen");
            int TicketPrice = 16;
            double discount = 0; 
            int age = 0;

            Console.WriteLine("Oletko varusmies K tai E");
            string userInput = Console.ReadLine();

            if (userInput == "K")
                discount = 0.50;
            else
            {
                Console.WriteLine("Oletko opiskelija K tai E");
                userInput = Console.ReadLine();
                if (userInput == "k")
                {
                    Console.WriteLine("Oletko MTK jäsen");
                    userInput = Console.ReadLine();
                    if (userInput == "K")
                        discount = 0.6;
                    else
                        discount = 0.45;
                }
                else
                {
                    Console.WriteLine("Syötä ikä");
                    string userInput1 = Console.ReadLine();
                    age = int.Parse(userInput1);
                    if (age < 7)
                    {
                        discount = 1.0;
                        
                    }
                    else if (age >= 7 && age <= 15 || age > 65)
                    {
                        discount = 0.5;
                    }
                    else
                    {
                        Console.WriteLine("Oletko MTK jäsen K tai E");
                        userInput = Console.ReadLine();
                        if (userInput == "K")
                        {
                            discount = 0.15;
                        }



                    }
                        
                        
                    
                }
            }                
            
            Console.WriteLine($"Lipun hinta on {TicketPrice - TicketPrice * discount}");

        }
    }
}
