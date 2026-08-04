using System;
using System.Collections.Generic;

// ------------------------------------------------------------------
// What I did to go beyond the base requirements:
//
// 1. I added a fourth activity, a Gratitude Journal, on top of the three
//    that were asked for. It follows the same start/end pattern as the
//    others but writes what you typed into a text file with a timestamp,
//    so you actually have something to look back on later instead of it
//    just disappearing when the program closes.
//
// 2. For the Reflection activity, I made sure the random questions don't
//    repeat until every single one has already been shown once. I kept
//    a "remaining questions" list that empties out as we go, and only
//    refills once it's completely empty.
//
// 3. I added a simple history feature that keeps count of how many times
//    each activity has been completed, and saves that to its own file so
//    it survives between sessions. You can check it from the menu without
//    starting a new activity.
//
// I tried to keep everything consistent with the inheritance structure
// the assignment asked for, so none of this bonus logic duplicates code
// that already lives in the base Activity class.
// ------------------------------------------------------------------

class Program
{
    static void Main(string[] args)
    {
        // Nou chaje istwa aktivite yo depi nan kòmansman, konsa nou pa pèdi
        // sa ki te fèt nan lòt sesyon avan.
        Dictionary<string, int> counts = ActivityLogger.LoadCounts();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Pwogram Plennitid ===");
            Console.WriteLine("1. Aktivite Respirasyon");
            Console.WriteLine("2. Aktivite Refleksyon");
            Console.WriteLine("3. Aktivite Lis");
            Console.WriteLine("4. Aktivite Remèsiman (bonus)");
            Console.WriteLine("5. Gade istwa aktivite ou yo");
            Console.WriteLine("6. Kite pwogram nan");
            Console.WriteLine();
            Console.Write("Chwazi yon opsyon: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    ActivityLogger.Increment(counts, "Respirasyon");
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    ActivityLogger.Increment(counts, "Refleksyon");
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    ActivityLogger.Increment(counts, "Lis");
                    break;

                case "4":
                    GratitudeJournalActivity gratitude = new GratitudeJournalActivity();
                    gratitude.Run();
                    ActivityLogger.Increment(counts, "Remèsiman");
                    break;

                case "5":
                    ShowHistory(counts);
                    break;

                case "6":
                    running = false;
                    ActivityLogger.SaveCounts(counts);
                    Console.WriteLine();
                    Console.WriteLine("Orevwa, pran swen tèt ou!");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Opsyon sa a pa egziste, tanpri eseye ankò.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // Ti fonksyon senp ki montre konbyen fwa itilizatè a fè chak aktivite.
    static void ShowHistory(Dictionary<string, int> counts)
    {
        Console.Clear();
        Console.WriteLine("=== Istwa aktivite ou yo ===");
        Console.WriteLine();

        if (counts.Count == 0)
        {
            Console.WriteLine("Ou poko fè okenn aktivite pou kounye a.");
        }
        else
        {
            foreach (KeyValuePair<string, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value} fwa");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Peze Antre pou retounen nan meni an...");
        Console.ReadLine();
    }
}