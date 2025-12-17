using System;

class Method
{
    static void Main(string[] args)
    {
        /*
            method - is a block of code that performs a specific task.
            you can call (use) it whenever you need, instead of rewriting the same code again.

            Think of a method as a function or action.

            syntax:
                accessModifier returnType MethodName(parameters)
                {
                    // code to execute
                }
        */

        // Calling the SingHappyBirthday() method with no parameters
        SingHappyBirthday();
        SingHappyBirthday();
        SingHappyBirthday();


        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Calling the Greet() method with parameters
        Greet(name);

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        // Calling the Add() method with parameters and return type
        int result = Add(num1, num2);
        Console.WriteLine(result);

        Console.ReadKey();
    }

    // Simple example (no parameters)
    static void SingHappyBirthday()
    {
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday dear YOU!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine();
    }

    // Method with parameters
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    // Method with return value

    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>The sum of a and b</returns>
    static int Add(int a, int b)
    {
        return a + b;
    }

    /* 
        Key parts explained
            - access modifier - public, private, static, etc.
            - return type - void (no return) or a data type like int, string
            - parameters - values passed into the method
            - return - sends a value back

        Why methods are important
            - Avoid repeating code
            - Make code readable
            - Easier debugging
            - Core skill for OOP and algorithms

        '///' XML Documentation Comments
            - Explain what in the method does
            - Describe parameters
            - Describe return values
            - Show up as tooltips in IDEs
    */

}