using System;

public class Save
{
    public static void ReadFile()
    {
        Console.WriteLine("What file would you like to open:");
        string readname = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(readname);
                    
        int counter = 0;  
    
        // Read the file and display it line by line.  
        foreach (string line in lines)
        {  
            System.Console.WriteLine(line);  
            counter++;  
        }  
    }

    public static void SaveFile()
    {
        string filename = "";
        Console.WriteLine("What is the file name? (be sure to end with .txt): ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{Journal._Date}");
            outputFile.WriteLine($"{Journal._Prompt}");
            outputFile.WriteLine($"{Journal._JournalEntry}");
            outputFile.WriteLine(" ");
                    
        }
    }
}