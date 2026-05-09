using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int numberInt = int.Parse(numberString);
        return numberInt;
    }
    static int SquareNumber(int numberInt)
    {
        return (int)Math.Pow(numberInt, 2);
    }
    static void DisplayResult(string name, int numberSquare)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquare}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        string name = PromptUserName();
        int numberInt = PromptUserNumber();
        int numberSquare = SquareNumber(numberInt);
        DisplayResult(name, numberSquare);
    }
}