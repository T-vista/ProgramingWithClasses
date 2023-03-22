using System;

public class Journal
{
    public static string _JournalEntry = "";
    public static string _Prompt = "";
    public static string _Date = "";
    List<string> _Entries = new List<string>()

    public static void entry()
    {
        _Date = Prompts.GetDate();
        _Prompt = Prompts.GetPrompt();
         Console.WriteLine($"Date: {_Date} - Prompt: {_Prompt}");
        Console.WriteLine("Enter your response here: ");
        _JournalEntry = Console.ReadLine();
        _Entries.Add($"Date: {_Date} - Prompt: {_Prompt}
        {_JournalEntry}")
    }

    public static void display()
    {
        Console.WriteLine(_Entries);
    }
}
