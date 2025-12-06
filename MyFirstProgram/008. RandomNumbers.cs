using System;

namespace MyFirstProgram
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            // Random Class - random numbers are numbers that appear to have no pattern.

            // To use Random in C# import the namespace "using System;" this allows us to use the Random class.
            // To create a Random objeect:
            Random random = new Random();
            // This creates a random number generator.
            // You should create one object and reuse it; don't create a new one repeatedly.

            // Generate numbers:
            // 1. Random integer:
            int number1 = random.Next();
            Console.WriteLine(number1);

            // 2. Random integer with a range:
            int number2 = random.Next (1, 11); // generate from 1 to 10 (upper limit is exclusive)
            Console.WriteLine(number2);

            // 3. Random decimal/floating-point number:
            double number3 = random.NextDouble();   // generate from 0.0 to less than 1.0
            Console.WriteLine(number3);

            // 4. Random boolean (true/false):
            bool isActive = random.Next(0, 2) == 0;
            Console.WriteLine(isActive);

            Console.ReadKey();
        }
    }
}