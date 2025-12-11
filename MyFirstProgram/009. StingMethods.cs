using System;

namespace MyFirstProgram
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            /*
            In C#, string methods are built-in functions you can use to manipulate or analyze text.
            The string type is very powerful and comes with many commonly used methods.
            */

            // 1. Length    - returns how many characters are in the string.

            string name = "Jade Mark";
            int len = name.Length;
            Console.WriteLine(len);
            Console.WriteLine(name.Length);     // This is another way of declarion of StringMethods

            // 2. ToUpper() & ToLower() - converts the string to ALL CAPS or all lowercase
            string a = "hello";
            Console.WriteLine(a.ToUpper());     // HELLO
            Console.WriteLine(a.ToLower());     // hello

            // 3. Trim(), TrimStart(), TrimEnd()    - removes spaces at the start/end.
            string b = "     hello    ";
            Console.WriteLine(b.Trim());        // hello 
            Console.WriteLine(b.TrimStart());   // hello    
            Console.WriteLine(b.TrimEnd());     //      hello

            // 4. Contains()    - checks if a string contains another substring.
            Console.WriteLine("Hello World".Contains("World"));   // True

            // 5. StartsWith() & EndsWith() - checks how the string begins or ends
            Console.WriteLine("Hello".StartsWith("He"));    // True
            Console.WriteLine("Hello".EndsWith("lo"));      // True

            // 6. IndexOf() & LastIndexOf()    - finds position of a character/substring.
            string c = "banana";

            Console.WriteLine(c.IndexOf("a"));      // 1
            Console.WriteLine(c.LastIndexOf("a"));  // 5

            // 7. Substring(start, length)  - Extracts part of a string.
            string d = "Hello";
            Console.WriteLine(d.Substring(1, 3));   // ell

            // 8. Replace(old, new) - Replace text.
            Console.WriteLine("Hello World".Replace("World", "Jade"));      // Hello Jade

            // 9. Split()   - Breaks a string into an array based on a separator.
            string data = "apple,banana,orange";
            string[] fruits = data.Split(',');
            Console.WriteLine(fruits);

            // 10. Join() (static method)   - Combine array items into one string.
            string result = string.Join("-", fruits);
            Console.WriteLine(result);

            // 11. Equals() - Compare two strings (case-sensitive unless specified).
            string hello = "hello";
            Console.WriteLine(hello.Equals("HELLO"));       //  False
            Console.WriteLine(hello.Equals("HELLO", StringComparison.OrdinalIgnoreCase));   // True

            // 12. IsNullOrEmpty() / IsNullOrWhiteSpace() (static)  - Checks if a string has no usable content.
            string empty = "";
            Console.WriteLine(string.IsNullOrEmpty(empty));     //  True
            Console.WriteLine(string.IsNullOrWhiteSpace(" "));  //  True

            // 13. Insert() - add (insert) text at a specific position inside an existing string
            string insertResult = name.Insert(5, "The ");
            Console.WriteLine(insertResult);
            Console.ReadKey();
        }
    }
}