using System;

public class Reference
{
    private static string _book = "";
    private static string _chapter = "";
    private static string _verseStart = "";
    private static string _verseEnd = "";
    private static string _text = "";

    public static void _displayScripture()
    {
        if (_verseEnd != "")
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd} {_text}");
        }
        else 
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart} {_text}");
        }
    }
    public static void _setReference(string book, string chapter, string verseStart, string verseEnd, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _text = text;
    }
}