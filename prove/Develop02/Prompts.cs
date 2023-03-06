using System;

public class Prompts
{
    public List<string> _Prompts = new List<string>() {"Who was the most interesting person you interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What made me the most happy today?",
    "What was the funnest part of today?",
    "What spiritual experience did I have today?",
    "What was the most exciting thing I learned today?"
    };

    public string _Prompt = "";

    public void GetPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_Prompts.Count);
        _Prompt = _Prompts[r];
    }

    public void GetDate()
    {
        Date date = Date.today;
    }
}
