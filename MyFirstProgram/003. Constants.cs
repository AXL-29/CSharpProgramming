namespace MyFirstProgram
{
    class Constants
    {
        static void Main(string[] args)
        {
            // a constant in C# is a variable whose cannot be changed once it is assigned.
            // it is fixed, or "constant," throughout the entire program.

            // syntax: const dataType variableName = value;

            const int MAX_USERS = 100;

            // Key Rules for Constants:
            // 1. Must be initialized immediately.
            //      - You cannot declare and then assign later.

            const int AGE = 25;

            // 2. Value cannot be changed.

            //AGE = 26;       // This will raise an error.

            // 3. Must use simple value types.

            // Naming Convention:
            // - Constant are usually written in ALL CAPS with underscores:

            const int MIN_AGE = 12;
            const int MAX_POINTS = 5000;
        }
    }
}