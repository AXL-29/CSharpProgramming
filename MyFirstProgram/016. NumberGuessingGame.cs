using System;

namespace MyFirstProgram
{
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            int guess;
            int guesses;
            int min = 1;
            int max = 100;
            bool isGameOn = true;
            String playAgain = "";

            Random random = new();

            while (isGameOn)
            {
                guess = 0;
                guesses = 0;
                int numberToGuess = random.Next(min, max + 1);
                Console.WriteLine(numberToGuess);

                while(guess != numberToGuess)
                {
                    Console.Write("Guess a number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < 0 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100 only!");
                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine(guess + " is to low!");
                        guesses++;
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine(guess + " is to high!");
                        guesses++;
                    }
                }
                Console.WriteLine("You have guess the number: " + numberToGuess);
                Console.WriteLine("Number of guesses: " + guesses);

                Console.Write("Do you want to play again? (y/n): ");

                playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    Console.WriteLine("Thank you for playing!");
                    isGameOn = false;
                }
            }
            Console.ReadKey();
        }
    }
}