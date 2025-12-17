using System;

class Arrays
{
    static void Main(string[] args)
    {
        /*
            In C#, an array is a data structure that lets you store multiple values of the same data type
            in a single variable, using an index to acces each value.

            syntax: dataType[] variableName = {firstValue, secondValue, etc.};

            Key Characteristics of arrays in C#
            1. Fixed size
                - Once created, the size of an array cannot change.
            2. Same data type
                - All elements must be same type (e.g., all int, all string).
            3. Zero-based index
                - Indexing starts at 0, not 1
        */

        // string[] new_cars = new string[10];     this set's the size of an array in advance.

        string[] cars = {"BMW", "Mustang", "Corvette"};

        cars[0] = "Tesla";      // Update an element
        
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Console.ReadKey();
    }
}
