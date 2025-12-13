using System;

namespace MyFirstProgram
{
    class Switches
    {
        static void Main(string[] args)
        {
            /*
             In C#, a switch is a selection (decision-making) statement used to execute one
             block of code out of many, based on the value of expression.

             It's open used as a cleaner alternative to multiple if-else if statement when you're
             comparing one variable against many possible values.

             Basic Syntax:

             switch (expression)
             {
                case value1:
                    code runs if expression == value1
                    break;

                case value2:
                    code runs if expression == value2
                    break;

                case value3:
                    code runs if expression == value3
                    break;
                
                default:
                    code runs if no case matches
                    break;
             }
            */

            Console.Write("What day is today?: ");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("It's Monday");
                    break;
                
                case "tuesday":
                    Console.WriteLine("It's Tuesday.");
                    break;
                
                case "wednesday":
                    Console.WriteLine("It's Wednesday.");
                    break;
                
                case "thursday":
                    Console.WriteLine("It's Thursday.");
                    break;
                
                case "friday":
                    Console.WriteLine("It's Friday.");
                    break;
                
                case "saturday":
                    Console.WriteLine("It's Saturday.");
                    break;
                
                case "sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                
                default:
                    Console.WriteLine("The " + day + " is not a day.");
                    break;
            }

            Console.ReadKey();

            /*
                Why break is important
                    - break stops the execution once a matching case is found.
                    - Without a break, C# will throw a compile-time error (unlike some other languages).

                defaul Case:
                    - runs when no case matches.
                    - similar to the final else in an if-else chain.
                    - Optional, but recommended.

                When to use "switch" vs "if-else"
                1. Use switch when:
                    - You're checking one variable
                    - Against many fixed values
                    - And want cleaner, more readable code.
                
                2. Use if-else when:
                    - Conditions are ranges (>, <)
            */
        }
    }
}
