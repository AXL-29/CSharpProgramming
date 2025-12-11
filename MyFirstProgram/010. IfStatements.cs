using System;

namespace MyFirstProgram
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            /*
                What is an if statement in C#?
                - An if statemtent lets your program makes decision - it runs certain code only if a condition is True.

                What is an else if?
                - An else if is a way to check another condition if the first if condition is false.

                Key points:
                - You can use as many else if as you want
                - Only one block runs
                - The chain stops as soon as one condition is True
                - else if MUST come after an if, but before an else.

                How else correlates with if
                - else always belongs to the nearest previous if that doesn't already have an else.
                - It runs only when the if condition is FALSE
                - It must follow an if or an else if - it cannot stand alone.

                Basic Syntax:
                if (condition1)
                {
                    runs if condition1 is TRUE
                }
                else if (condition2)
                {
                    runs if condition2 is TRUE (only if condition1 is FALSE)
                }
                else
                {
                    runs if the condition is FALSE
                }
            */

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't born yet!");
            }
            else
            {
                Console.WriteLine("Sorry, please be at age of 18+ to signed up.");
            }



            Console.ReadKey();
        }
    }
}