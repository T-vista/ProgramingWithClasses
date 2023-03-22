using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while(run == true)
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
                run = true;
                Console.WriteLine(" ");
            }
            else if (command == "2")
            {
                Journal.display();
                Console.WriteLine(" ");
            }
            else if (command == "3")
            { 
                Save.ReadFile();
                Console.WriteLine(" ");
            }
            else if (command == "4")
            {
                Save.SaveFile();
                Console.WriteLine(" ");
            }
            else if (command == "5")
            {
                run = false;
            } 
        } 
    }
}