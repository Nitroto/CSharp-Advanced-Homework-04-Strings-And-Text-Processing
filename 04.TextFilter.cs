using System;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with 
/// asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
// The ban list should be entered on the first input line and the text on the second input line.

class TextFilter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] banList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string text = Console.ReadLine();
        string[] censored = new string[banList.Count()];
        for (int i = 0; i < banList.Count(); i++)
        {
            censored[i] = new string('*', banList[i].Length);
        }
        Console.WriteLine();
        for (int i = 0; i < banList.Count(); i++)
        {
            text =text.Replace(banList[i], censored[i]);
        }
        Console.WriteLine(text);
    }
}
