using System;

class Program
{
    static void Main(string[] args)
    {
        string PlayAgain = "yes";
        while (PlayAgain == "yes")
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;
        int numberOfGuesses = 0;

        do
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                numberOfGuesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! ");
                    
                }
            } while (guess != magicNumber);
            Console.WriteLine("It took you " + numberOfGuesses + " guesses to find the magic number.");
            Console.WriteLine("Do you want to play again? (yes/no)");
            PlayAgain = Console.ReadLine();
        }
    }
}