using System;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses=0, guess, number;
            int min=0, max=100;
            bool playAgain=true;
            String response;
            Random rand = new Random();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to Number Guessing Game");
            Console.WriteLine("-------------------------------");

            while (playAgain)
            {
                number= rand.Next(min,max);                
                response = "";

                Console.Write("Enter a number: ");
                guess=Convert.ToInt32(Console.ReadLine());

                while (guess!=number)
                {
                    if (guess>number)
                    {
                        Console.WriteLine(guess + " is too high!");
                        guesses++;
                        Console.Write("Enter an another number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if(guess<number) 
                    {
                        Console.WriteLine(guess + " is too low!");
                        guesses++;
                        Console.Write("Enter an another number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }
                if (guess==number)
                {
                    Console.WriteLine("You WON!");
                    guesses++;
                }
                Console.WriteLine("Would you like to play again?(Y/N)");
                response= Console.ReadLine();
                response = response.ToUpper();

                if (response=="Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain=false;
                }
            }

            Console.WriteLine("You have tried " + guesses + " times.");
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Goodbye!");
            Console.WriteLine("-------------------------------");

            Console.ReadKey();
        }
    }
}