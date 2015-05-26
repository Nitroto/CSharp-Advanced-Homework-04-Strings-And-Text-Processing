using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on 
/// the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and 
/// exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically.

class Palindromes
{
    public static CultureInfo CUltureInfo { get; private set; }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        List<string> palindromes = new List<string>();
        foreach (string word in text)
        {
            if (IsPalindromes(word))
            {
                palindromes.Add(word);
            }
        }
        palindromes.Sort();
        string palindromesList = String.Join(", ", palindromes);
        Console.WriteLine(palindromesList);
    }

    private static bool IsPalindromes(string word)
    {
        bool isPalindromes = false;
        if (word.Length == 1)
        {
            return true;
        }
        for (int i = 0; i < word.Length / 2; i++)
        {
            isPalindromes = word[i] == word[word.Length - i - 1];
            if (!isPalindromes)
            {
                return false;
            }
        }
        return isPalindromes;
    }
}
