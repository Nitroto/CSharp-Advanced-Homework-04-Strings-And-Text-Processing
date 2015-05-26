using System;
using System.Globalization;
using System.Threading;

/// Write a program that converts a string to a sequence of C# Unicode character literals.

class UnicodeCharacters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        foreach (char value in input)
        {
            Console.Write("\\u{0:x4}", Convert.ToInt16(value));
        }
        Console.WriteLine();
    }
}
