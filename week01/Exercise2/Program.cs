using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What your grade?");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Bonus defi that consists to find if the stuedent get a + or a - in their letter grade
        if (grade >= 60 && grade <= 100)
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                letter += "+";
            }
            else if (lastDigit <= 2)
            {
                letter += "-";
            }
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a {letter}.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass the course. Your grade is {letter}.");
        }
    }
}