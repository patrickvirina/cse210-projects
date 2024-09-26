using System;

public class PromptGenerator
{
    private static Random random = new Random();
    private static string[] prompts = new string[]
    {
        "What made you happy today?",
        "Describe a challenging moment from your day.",
        "What are you thankful for today?",
        "What did you learn today?",
        "Write about a goal you want to achieve."
    };

    // Get a random prompt
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}
