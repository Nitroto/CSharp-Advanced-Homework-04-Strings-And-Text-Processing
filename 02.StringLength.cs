using System;
using System.Globalization;
using System.Text;
using System.Threading;

/// Write a program that reads from the console a string of maximum 20 characters. If the length 
/// of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.

class StringLength
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userInput = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < 20; i++)
        {
            if (i < userInput.Length)
            {
                output.Append(userInput[i]);
            }
            else
            {
                output.Append("*");
            }
        }
        Console.WriteLine(output.ToString());
    }
}
