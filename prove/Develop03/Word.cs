using System;

public class word 
{
     public static int _wordLength = Scripture._scriptureList.Count;

    public static List<int> _isHiddenList = new List<int>();

    public void _hideRandomWords()
    {
        var random = new Random();

        int blankSpaceValue = random.Next(1,_wordLength + 1);
        
        _isHiddenList.Add(blankSpaceValue);
    }
}