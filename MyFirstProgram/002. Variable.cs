namespace MyFirstProgram
{
    class Variable
    {
        static void Main(string[] args)
        {
            // syntax: dataType variableName;

            // examples:
            int number;         // declares an integer variable
            string username;    // declares a string variable
            bool isActive;      // declares a boolean variable
            float pi;           // declares a floating variable (a float needs an f at the end)
            double num;         // declares a double variable
            char a;             // declares a char variable

            // What is a Data Type? - a data types tells c# what kind of value a variable will store - numbers, text, true/false, etc.

            // 1. int - Integer 
            //  - Stores whole numbers (no decimal)
            //  - Uses 4 bytes

            int age = 21;
            int numberOfStudents = 32;

            // 2. float - Floating Point (less precision)
            // - Stores decimal numbers
            // - Around 7 digits precision
            // - Must end with 'f'

            float temperature = 36.5f;

            // 3. double - Double Precision (more precision)
            // - Stores decimal numbers
            // - Around 15-16 digits precision
            // - Default decimal type

            double pi = 3.14159265358979;

            // 4. decimal - High precision (best for money)
            // - Stores very accurate decimal values
            // - Used in financial or currency calculations
            // - Must end with 'm'

            decimal price = 999.99m;

            // 5. char - Character
            // - Stores one single character
            // - Must use single quotes ' '

            char letter = 'A';
            char symbol = '@';

            // 6. string - Text
            // - Stores multiple characters (words, sentences)
            // - Uses double quotes " "

            string name = "Jade";
            string greeting = "Hello World!";

            // bool - Boolean
            // - Stores true or false

            bool isOnline = true;
            bool isAdmin = false;

            // 8. long - Large Integer
            // - Stores very large numbers (bigger than int)

            long population = 11000000000000000000;

            // 9. short - Small Integer
            // - Stores smaller whole numbers

            short score = 225;

            // 10. byte - Small number 0 - 255
            // uses only 1 byte

            byte level = 255;

        }
    }
}
