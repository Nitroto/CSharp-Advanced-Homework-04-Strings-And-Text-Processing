using System;
using System.Globalization;
using System.Threading;

/// Write a program that reads a string from the console, reverses it and prints the result back at the console.

class ReverseString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userInput = Console.ReadLine();
        string reversed = ReverseText(userInput);
        Console.WriteLine(reversed);
    }

    private static string ReverseText(string userInput)
    {
        string reversed = string.Empty;
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed += userInput[i];
        }

        return reversed;
    }
}
