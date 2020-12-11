using System;
using System.Collections.Generic;
using System.Linq;

public static class StringHelper
{
    public static List<string> SentenceToListOfWords(string sentence) =>
        sentence
            .Split(' ')
            .ToList();

    public static string ReverseWordIfLengthExceeded(string word, int length)
    {
        string output;

        if (word.Length >= length)
            output = ReverseWord(word);
        else
            output = word;

        return output;
    }

    public static string ReverseWord(string word)
    {
        var charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return string.Concat(charArray);
    }
}
