using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project."); 
        Console.Write("Hello student, please insert your score: ");
        string scoreFromUser = Console.ReadLine();

        int score = int.Parse(scoreFromUser);

        string letterScore = "";

        if (score <= 100 && score >= 93)
        {
            letterScore = "A";
        }
        else if (score < 93 && score >= 90)
        {
            letterScore = "-A";
        }
        else if (score < 90 && score >= 87)
        {
            letterScore = "+B";
        }
        else if (score < 87 && score >= 83)
        {
            letterScore = "B";
        }
        else if (score < 83 && score >= 80)
        {
            letterScore = "-B";
        }
        else if (score < 80 && score >= 77)
        {
            letterScore = "+C";
        }
        else if (score < 77 && score >= 73)
        {
            letterScore = "C";
        }
        else if (score < 73 && score >= 70)
        {
            letterScore = "-C";
        }
        else if (score < 70 && score >= 67)
        {
            letterScore = "+D";
        }
        else if (score < 67 && score >= 63)
        {
            letterScore = "D";
        }
        else if (score < 63 && score >= 60)
        {
            letterScore = "-D";
        }
        else if (score < 60 && score == 0)
        {
            letterScore = "F";
        }
        else
        {
            Console.WriteLine("Your score is not between 0 at 100.");
            letterScore = "Incorrect";
        }

        Console.WriteLine($"Your grade is: {letterScore}");

        if (score <= 100 && score >= 70)
        {
            Console.WriteLine("Congrats You passed!");
        }
        else if (score < 70 && score >= 0)
        {
            Console.WriteLine("Better Luck next time!");
        }
        else
        {
            Console.Write("Your score is not between 0 at 100.");
        }
    }
}