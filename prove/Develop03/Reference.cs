using System;

public class Reference
{
    private string Book;
    private int StartVerse;
    private int? EndVerse;

    // Constructor for a single verse
    public Reference(string book, int verse)
    {
       Book = book;
       StartVerse = verse;
       EndVerse = null;
    }

    // Constructor for a verse range
    public Reference(string book, int startVerse, int endVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    // Method to return the formatted reference string
    public override string ToString()
    {
        if (EndVerse.HasValue)
        {
            return $"{Book} {StartVerse}:{EndVerse}";
        }
       
        return $"{Book} {StartVerse}";
    }
}

