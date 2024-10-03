using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRef = new Reference("Proverbs", 3, 5);
        Scripture scripture = new Scripture(scriptureRef, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        while(true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter key to continously hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You memorized the scripture.");
                break;
            }
        }
    }
}