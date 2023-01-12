using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 0;
        do
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
            numbers.Add(number);  
            }
        } while (number != 0);

        int sum = numbers.Sum();
        double avg = Queryable.Average(numbers.AsQueryable());
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {avg}");
        Console.WriteLine($"The Largest number is: {max}");
    }
}