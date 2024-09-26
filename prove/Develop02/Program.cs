using System;

class Program
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            // Used switch statement rather than for loop as it has likely faster
            // according to StackOverflow website 
            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    DisplayPrompt();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    // Display the menu
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Get a writing prompt");
        Console.WriteLine("6. Quit");
        Console.Write("Choose an option: ");
    }

    // Write a journal entry
    static void WriteEntry()
    {
        Console.Write("Enter your journal entry (Note: Make sure to save every entry): ");
        string entry = Console.ReadLine();
        journal.AddEntry(entry);
    }

    // Save the journal to a file
    static void SaveJournal()
    {
        Console.Write("Enter the filename to save (e.g., journal.txt): ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    // Load the journal from a file
    static void LoadJournal()
    {
        Console.Write("Enter the filename to load (e.g., journal.txt): ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    // Display a random prompt
    static void DisplayPrompt()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }
}
