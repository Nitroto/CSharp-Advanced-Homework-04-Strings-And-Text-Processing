using System;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. 
/// The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping 
/// between occurrences is allowed.

class CountSubstringOccurrences
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userInput = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int count = userInput.Select((c, i) => userInput.Substring(i)).Count(sub => sub.StartsWith(pattern));
        Console.WriteLine(count);
    }
}
