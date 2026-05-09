using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 21);
        
        // Console.WriteLine(number);
        // I use this to find out the generated number

        Console.WriteLine("What is the magic number? ");
        Console.Write("What is your guess? ");
        string numberGuess = Console.ReadLine();
        int numberInt = int.Parse(numberGuess);
        
        while (numberInt != number)
        {
            if (numberInt > number)
            {
                Console.WriteLine("Lower");
            }
            else if (numberInt < number)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            numberGuess = Console.ReadLine();
            numberInt = int.Parse(numberGuess);
        }   
        Console.WriteLine("You guessed it!");
    }
}