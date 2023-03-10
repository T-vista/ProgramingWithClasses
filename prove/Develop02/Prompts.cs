using System;

public class Prompts
{
    public static List<string> _Prompts = new List<string>() {"Who was the most interesting person you interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What made me the most happy today?",
    "What was the funnest part of today?",
    "What spiritual experience did I have today?",
    "What was the most exciting thing I learned today?"
    };

    public static string _Prompt = "";

    public static string GetPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(Prompts._Prompts.Count());
        _Prompt = _Prompts[r];
        return _Prompt;
    }

    public static string GetDate()
    {
        DateTime now = DateTime.Now;
        string _date = now.ToString("F");
        return _date;
    }
}
