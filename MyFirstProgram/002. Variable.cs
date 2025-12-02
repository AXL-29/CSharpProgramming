namespace MyFirstProgram
{
    class Variable
    {
        static void Main(string[] args)
        {
            int x;      // declaration
            x = 123;    // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 25;

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);

            System.Console.WriteLine("My age is " + age);   // Display the variable by using concatenation.
        }
    }
}
