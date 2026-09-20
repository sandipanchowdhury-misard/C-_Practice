using System;

class Strings
{
    static void Main()
    {
        string myName = "Sandipan Chowdhury";
        Console.WriteLine($"My Name is : {myName}");

        string name = "Sayani Saha";
        int age = 26;
        string msg = $"Name is : {name}, \nAge is : {age}";
        Console.WriteLine(msg);

        // Property: describes about characteristics .Used for data access
        // Method : actions. used for execute the tasks | actions.

        string text = " This is a sample string";
        int textLength = text.Length;
        Console.WriteLine("textLenght");

        //text.ToUpper();
        //text.ToLower();

        string text2 = "*******Sandipan*******";
        text2.Trim('*');
        text2.TrimEnd('*');
        text2.TrimStart('*');

        string password = "HereIs_my@Password";
        bool isCorrect = password.Equals("HereIsmyPassword");
        Console.WriteLine(isCorrect);


        string sentence = "The quick brown fox jumps over the lazy fox";
        string substringb=sentence.Substring(4, 10);
        Console.WriteLine(substringb);

        var replacedSentence = sentence.Replace("brown", "red");
        Console.WriteLine(replacedSentence);

        int quantity = 5;
        double price = 9.99;

        string receipt = string.Format("You puchased {0} items for ${1}", quantity, price);
        Console.WriteLine(receipt);


    }
}

