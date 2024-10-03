using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Ref;
    private List<Word> Words;

    // Constructor that get the reference and text
    public Scripture(Reference reference, string text)
    {
        Ref = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(count, Words.Count(w => !w.IsHidden));

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0) break;

            Word wordToHide = visibleWords[rand.Next(visibleWords.Count)];
            wordToHide.Hide(); 
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    // Display the scripture
    public override string ToString()
    {
        return $"{Ref}\n{string.Join(" ", Words)}";
    }
}