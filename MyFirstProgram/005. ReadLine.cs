using System;

namespace MyFirstProgram
{
    class ReadLine
    {
        static void Main(string[] args)
        {
            // Console.ReadLine() - reads input from the user via the console.
            // It pauses the program until the user types something and presses Enter.
            // The input is always returned as a string.

            Console.Write("Enter your name: ");  // Prompt for user
            string name = Console.ReadLine();    // Read user input as string

            Console.Write("Enter your age: ");  
            int age = Convert.ToInt32(Console.ReadLine());  // Convert string to int

            // Display the input back to the user
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadKey(); // Wait for a key press before closing
        }
    }
}