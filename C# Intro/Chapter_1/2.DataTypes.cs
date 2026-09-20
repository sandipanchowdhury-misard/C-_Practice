using System;

class DataTypes
{
    static void Main()
    {
        // Declare a variable of type int
        int myInt = 42;
        Console.WriteLine($"Integer Max-Val: {int.MaxValue}");
        Console.WriteLine($"Integer Min-Val: {int.MinValue}");

        // Declare a variable of type decimal
        decimal myDecimal = 19.99m;
        // Declare a variable of type float
        float myFloat = 3.14f;
        // Declare a variable of type double
        double myDouble = 3.14;
        // Declare a variable of type string
        string myString = "Hello, World!";
        // Declare a variable of type bool
        bool myBool = true;
        // Declare a variable of type char
        char myChar = 'A';
        // Declare a varibale of type String
        string myStr = " Hey I am learning C#";
        // Output the values to the console
        Console.WriteLine("Integer: " + myInt);
        Console.WriteLine("Decimal: " + myDecimal);
        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("String: " + myString);

        Console.WriteLine("Boolean: " + myBool);
        Console.WriteLine($"Character : {myChar}");
        Console.WriteLine($"String : {myStr}");
    }
}

