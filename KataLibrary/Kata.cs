// Stop gninnipS My sdroW
//
// Write a function that takes in a string of one or more words, and returns the same string, 
// but with all five or more letter words reversed (Just like the name of this Kata). Strings 
// passed in will consist of only letters and spaces. Spaces will be included only when more 
// than one word is present.

// Examples: 
// spinWords("Hey fellow warriors") => returns "Hey wollef sroirraw" 
// spinWords("This is a test") => returns "This is a test" 
// spinWords("This is another test")=> returns "This is rehtona test"

using System.Collections.Generic;

public static class Kata
{
    private const int MaxWordLength = 5;

    public static string SpinWords(string sentence)
    {
        string outputSentence;

        List<string> splittedInputSentence = StringHelper.SentenceToListOfWords(sentence);
        List<string> convertedSentenceWordList = new List<string>();

        splittedInputSentence.ForEach((word) => 
        {
            var outputWord = StringHelper.ReverseWordIfLengthExceeded(word, MaxWordLength);
            convertedSentenceWordList.Add(outputWord);
        });

        outputSentence = string.Join(" ", convertedSentenceWordList);

        return outputSentence;
    }
}