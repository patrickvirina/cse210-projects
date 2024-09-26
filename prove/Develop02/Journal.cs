using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string text)
    {
        Entry newEntry = new Entry(text);
        entries.Add(newEntry);
        Console.WriteLine("Entry added.");
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    // Save entries to a file
    public void SaveToFile(string filename)
    {
        List<string> fileContent = new List<string>();
        foreach (Entry entry in entries)
        {
            fileContent.Add(entry.ToString());
        }
        File.WriteAllLines(filename, fileContent);
        Console.WriteLine("Entries saved successfully.");
    }

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] fileContent = File.ReadAllLines(filename);
            foreach (string line in fileContent)
            {
                entries.Add(new Entry(line));
            }
            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
