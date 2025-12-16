using System;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        bool isCalculatorOn = true; // Keeps the calculator running
        double result;              // Stores the calculation result
        
        while (isCalculatorOn)
        {
            // Ask user for the first number
            Console.Write("Enter a first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            string mathOperator = ""; // Operator for calculation

            // Keep asking until a valid operator is entered
            while(true)
            {       
                Console.Write("Enter an operator (+, -, *, /, or %): ");
                mathOperator = Console.ReadLine();

                if (mathOperator == "+" || mathOperator == "-" ||
                    mathOperator == "*" || mathOperator == "/" || mathOperator == "%")
                {
                    break; // Valid operator, exit loop
                }

                Console.WriteLine("Please type (+, -, *, /, or %) only.");  
            }

            // Ask user for the second number
            Console.Write("Enter a second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            // Perform calculation based on operator
            switch (mathOperator)
            {
                case "+":
                    result = firstNum + secondNum;
                    Console.WriteLine("The sum of two numbers is: " + Math.Round(result, 2));
                    break;

                case "-":
                    result = firstNum - secondNum;
                    Console.WriteLine("The difference of two numbers is: " + Math.Round(result, 2));
                    break;

                case "*":
                    result = firstNum * secondNum;
                    Console.WriteLine("The product of two numbers is: " + Math.Round(result, 2));
                    break;

                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Sorry, the first number cannot be divided by zero");
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        Console.WriteLine("The quotient of two numbers is: " + Math.Round(result, 2));
                    }
                    break;
                
                case "%":
                    result = firstNum % secondNum;
                    Console.WriteLine("The remainder of two numbers is: " + Math.Round(result, 2));
                    break;
            }
            
            Console.WriteLine();

            // Ask if user wants to calculate again
            while (true)
            {
                Console.Write("Do you want to calculate again? (y/n): ");
                string calculateAgain = Console.ReadLine().ToLower();

                if (calculateAgain == "y")
                {
                    break; // Start new calculation
                }
                else if (calculateAgain == "n")
                {
                    Console.WriteLine("Thank you for using our calculator app!");
                    isCalculatorOn = false; // Stop calculator
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose between 'y' or 'n' only!");
                }
            }

            Console.WriteLine();
        }

        Console.ReadKey(); // Wait for key press before closing
    }
}
