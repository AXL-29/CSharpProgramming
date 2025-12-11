using System;

namespace CodingExercise
{
    class CodingExercise004
    {
        static void Main(string[] args)
        {
            // Task 1: Ask the user for their full name.
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine().ToUpper();
            int nameLength = fullName.Length;

            Console.WriteLine("Your name in uppercase: " + fullName);
            Console.WriteLine("Total numbers of characters: " + nameLength + "\n");

            // Task 2: Ask the user for their age.
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 60)
            {
                Console.WriteLine("You are a Senior");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You're an Adult");
            }
            else if (age >= 13)
            {
                Console.WriteLine("You're a Teen.");
            }
            else if (age >= 0)
            {
                Console.WriteLine("You're a Child");
            }
            else
            {
                Console.WriteLine("You haven't born yet!");
            }
            Console.WriteLine("");

            // Task 3. Perform arithmetic operations
            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double diff = number1 - number2;
            double product = number1 * number2;
            double qoutient = number1 / number2;
            double remainder = number1 % number2;

            Console.WriteLine("");
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The difference is: " + diff);
            Console.WriteLine("The product is: " + product);

            if (number2 == 0)
            {
                Console.WriteLine("Cannot be divided by zero.");
            }
            else
            {
                Console.WriteLine("The qoutient is: " + qoutient);
                Console.WriteLine("The remainder is: " + remainder);
            }


            // Task 4: Calculate circle area using a constant.
            const double PI = 3.14159;
            
            Console.WriteLine("");
            Console.Write("Enter the radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaOfACircle = PI * radius * radius;

            Console.WriteLine("");
            Console.WriteLine("The area of a circle is: " + Math.Round(areaOfACircle, 2));

            // Task 5. Use the Math class
            double largerNumber = Math.Max(number1, number2);
            double smallerNumber = Math.Min(number1, number2);
            double sqrt = Math.Sqrt(number1);

            Console.WriteLine("");
            Console.WriteLine("The Larger number is: " + largerNumber);
            Console.WriteLine("The Smaller number is: " + smallerNumber);
            Console.WriteLine("The Square root of " + number1 + " is: " + Math.Round(sqrt, 2));

            // Random number mini-game
            Console.WriteLine("");
 
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.Write("Guess a number from 1 - 10: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess > randomNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (userGuess < randomNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("Correct! You guessed it!");
            }

            Console.WriteLine("The secret number was: " + randomNumber);

            Console.ReadKey();

        }
    }
}