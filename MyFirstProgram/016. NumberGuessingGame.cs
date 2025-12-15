using System;

namespace MyFirstProgram
{
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            int guess = 0;

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);

            Console.WriteLine(numberToGuess);

            while (guess != numberToGuess)
            {
                Console.Write("Guess a number between 1 - 100: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > 100 || guess < 0){
                    Console.WriteLine("Please input a number between 1 - 100 only.");
                }
                else if (guess > numberToGuess){
                    Console.WriteLine(guess + " is to high!");    
                }
                else if (guess < numberToGuess){
                    Console.WriteLine(guess + " is to low!");    
                }
                else{
                    Console.WriteLine(guess + " is the correct answer, yey!");
                }
            }


            Console.ReadKey();
        }
    }
}