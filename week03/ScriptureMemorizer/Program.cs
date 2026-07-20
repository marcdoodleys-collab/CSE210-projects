using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        // === Ce qui a ete fait pour depasser les exigences de base ===
        // 1. Bibliotheque de plusieurs versets : un verset different est
        //    choisi au hasard a chaque lancement du programme.
        // 2. HideRandomWords() ne choisit que parmi les mots encore visibles
        //    (stretch challenge de la consigne), au lieu de re-tirer au sort
        //    des mots deja caches.
        // 3. Le nombre de mots caches augmente d'un a chaque tour, ce qui
        //    accelere naturellement la fin de la partie.
        static void Main(string[] args)
        {
            List<Scripture> library = new List<Scripture>
            {
                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world that he gave his only begotten Son"),
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
                new Scripture(
                    new Reference("Philippians", 4, 13),
                    "I can do all things through Christ which strengtheneth me"),
                new Scripture(
                    new Reference("John", 14, 15),
                    "If you love me keep my commandments")
            };

            Random random = new Random();
            Scripture scripture = library[random.Next(library.Count)];

            int round = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.Write("Press Enter to continue or type 'quit': ");
                string? input = Console.ReadLine();

                if (input != null && input.Trim().ToLower() == "quit")
                {
                    break;
                }

                int numberToHide = 1 + round;
                scripture.HideRandomWords(numberToHide);
                round++;
            }
        }
    }
}