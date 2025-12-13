using System;

namespace MyFirstProgram
{
    class LogicalOperators
    {
        static void Main(string[] args)
        {
            /*
                Logical Operators - is used to combine or modify boolean (true / false) expressions.

                Main Logical Operators in C#

                && (Logical AND)    - true if both conditions are true
                || (Logical OR)     - true if one conditions are true, false if both conditions are false.
                !  (Logical NOT)    - revers the boolean value
            */ 

            // Logical AND (&&):
            int age = 20;
            bool hasID = true;

            if (age >= 18 && hasID)
            {
                Console.WriteLine("Access Granted!");
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
            // both condition must be true, if not it will be false.

            // Logical OR (||):
            bool isAdmin = false;
            bool isModerator = true;

            if (isAdmin || isModerator)
            {
                Console.WriteLine("You have permission.");
            }
            // Only one condition needs to be true.

            // Logica NOT (!)
            bool isLoggedIn = false;
            if (!isLoggedIn)
            {
                Console.WriteLine("Please log in!");
            }
            // !false becomes true

            // Exercise: Ask for the temperature outside

            Console.Write("What's the temperature outside (C): ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside");
            }
            else if (temp <= -25 ||  temp <= 40)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }
            Console.ReadKey();
        }
    }
}
