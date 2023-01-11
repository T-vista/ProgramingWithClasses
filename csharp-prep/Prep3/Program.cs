using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);
        int number = 0;
        do 
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            number = int.Parse(guess);
            if (number > random)
            {
                Console.WriteLine("Lower");
            }
            else if (number < random)
            {
                Console.WriteLine("Higher");
            }
            else if (number == random)
            {
                Console.WriteLine("That is correct ");
            }
        } while (number != random);
    }
}