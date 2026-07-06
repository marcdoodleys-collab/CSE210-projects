using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Liste qui contiendra tous les nombres saisis par l'utilisateur 
        List<int> numbers = new List<int>();
    
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;

        // Boucle qui continue tant que l'utilisateur n'a pas saisi 0
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            // Lorsqu'on n'ajoute pas 0 a la liste
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        // 1. Calcul de la somme
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        // 2. Calcul de la moyenne
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        // 3. Calcul du maximum
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum of the numbers is: {max}");

        // Challenge (optional)
        int? smallestPositive = null;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // Tri de la liste et affichage
        numbers.Sort();
        Console.WriteLine("The sorted list of numbers is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}