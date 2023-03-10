using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal program!");
        Console.WriteLine("Select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");

        string command = "";
        command = Console.ReadLine();

        if (command == "1")
        {
            Journal.entry();
        }
        if (command == "2")
        {
            Journal.display();
        }
        if (command == "3")
        {
            Console.WriteLine("What file would you like to open:");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
}
        }
        if (command == "4")
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
                
            }
        }
        if (command == "5")
        {
            
        }
    }
}