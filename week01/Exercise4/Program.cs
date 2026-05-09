using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        Console.Write("Enter number: ");
        string stringNumber = Console.ReadLine();;
        int listNumber = int.Parse(stringNumber);

        while (listNumber !=0)
        {
            if (listNumber > 0)
            {
                numbers.Add(listNumber);
            }
            else if (listNumber < 0)
            {
                numbers.Add(listNumber);
            }
            Console.Write("Enter number: ");
            listNumber = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int largestNumber = 0;
        int smallestPositive = numbers[0];

        foreach (int number in numbers)
        {
            sum = sum + number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number > 0)
            {
                if (number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

        }

        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}