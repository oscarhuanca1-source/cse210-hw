using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        
        // I use this to find out the generated number
        // I delete the redundant question "What is your guess? "
        Console.WriteLine("Welcome to the guess the number game, the magic number is within the range of 1 to 100");
        Console.Write("What is the magic number? ");
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