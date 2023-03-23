using System;

public class Scripture
{
    public static string _text = "For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the bunderstanding; for he speaketh unto men according to their clanguage, unto their understanding.";
    public static string _chapter = "31";
    public static string _book = "2 Nephi";
    public static string _verseStart = "3";
    public static string _verseEnd = "";

    public static List<string> _scriptureList = new List<string>(_text.Split(' '));
}