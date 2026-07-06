using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
 
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
 
        int squaredNumber = SquareNumber(userNumber);
 
        DisplayResult(userName, squaredNumber);
    }
 
    // Affiche un message de bienvenue
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
 
    // Demande le nom de l'utilisateur et le retourne
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
 
    // Demande le nombre favori de l'utilisateur et le retourne
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
 
    // Reçoit un nombre et retourne son carré
    static int SquareNumber(int number)
    {
        return number * number;
    }
 
    // Affiche le résultat final avec le nom et le carré du nombre
    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");;
    }
}