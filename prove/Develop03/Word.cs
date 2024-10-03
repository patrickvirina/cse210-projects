using System;

public class Word
{
    private string Text;
    public bool IsHidden;

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    } 

    // Method to hide word
    public void Hide()
    {
        IsHidden = true;
    }

    // Method to check if the word is hidden
    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}