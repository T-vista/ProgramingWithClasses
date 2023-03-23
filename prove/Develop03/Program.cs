using System;

class Program
{
    static void Main(string[] args)
    {
        Reference._setReference(Scripture._book, Scripture._chapter, Scripture._verseStart, Scripture._verseEnd, Scripture._text);

        Reference._displayScripture();
        Console.WriteLine(" ");
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("it worked!");
    }
}