using System;

namespace MyFirstProgram
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            /*
                A for loop is used when you know in advance how many times you want a block of code to run.

                basic syntax:

                    for (initialization; condition; increment)
                    {
                        Code to repeat
                    }
            */

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}