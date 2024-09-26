using System;

public class Entry
{
    private string text;
    private DateTime timestamp;

    // Constructor to create a new entry
    public Entry(string text)
    {
        this.text = text;
        this.timestamp = DateTime.Now;
    }

    // Override ToString to format the entry with date and time
    public override string ToString()
    {
        return $"{timestamp}: {text}";
    }
}
