using System;

public class Journal
{
    public string _JournalEntry = "";
    public string _PromptOutput = "";
    public string _Date = "";

    public void entry()
    {
        Console.WriteLine($"Date: {Prompts.GetDate()} - Prompt: {Prompts.GetPrompt()}");
        Console.WriteLine("Enter your response here: ");
        _JournalEntry = Console.ReadLine();
    }

    public void display()
    {
        Console.WriteLine($"Date: {Prompts.GetDate()} - Prompt: {Prompts.GetPrompt()}");
        Console.WriteLine(_JournalEntry);
    }
}
