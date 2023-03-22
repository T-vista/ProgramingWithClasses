using System;

public class Scripture
{
    public static string _reference = "2 Nephi 31:3 For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the bunderstanding; for he speaketh unto men according to their clanguage, unto their understanding.";

    public static List<string> _scriptureList = new List<string>(_reference.Split(' '));

    public static int _wordLength = _scriptureList.Count;

    public static List<int> _isHiddenList = new List<int>();

    public void _hideRandomWords()
    {
        var random = new Random();

        int blankSpaceValue = random.Next(1,_wordLength + 1);
        
        _isHiddenList.Add(blankSpaceValue);
    }
    public void _displayConsole()
    {
        Console.WriteLine($"{reference._book} {reference._chapterVerse} {reference._verse}");
        Console.WriteLine(" ");
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
    }
}