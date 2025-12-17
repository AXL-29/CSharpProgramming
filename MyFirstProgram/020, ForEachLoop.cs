using System;

class ForEachLoop
{
    static void Main(string[] args)
    {
        /*
        foreach loop is used to iterate (loop through) each element in a collection such as an array, list, or string
        without using an index.

        basic syntax:
            foreach (type variable in collection)
            {
                // code to execute for each item
            }
        */

        string[] cars = {"BMW", "Mustang", "Corvette"};

        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        /*
            What happens here:
                - The loop goes through each element in cars
                - car holds the current item
                - The loop stops automatically when all item processesd.

            Key Characteristics
                - Simple and readable
                - No index needed
                - You cannot modify the collection elements directly
                - You cannot control the index (use for if you need it)
            
            When should you use foreach?
                - You just want to read and process it.
                - You don't need the index.
                - You want cleaner cpde (great for beginners)
        */

        Console.ReadKey();
    }
}