using System;
using System.Collections.Generic;

// Aktivite lis la. Itilizatè a ekri kantite bagay li kapab jiskaske tan a rive.
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Ki moun ou apresye anpil?",
        "Ki kèk nan fòs pèsonèl ou?",
        "Ki moun ou te ede semèn sa a?",
        "Kilè ou te santi prezans Bondye mwa sa a?",
        "Kilès ki kèk nan ewo pèsonèl ou yo?"
    };

    public ListingActivity()
        : base(
            "Lis",
            "Aktivite sa a ap ede w reflechi sou bon bagay yo nan lavi w "
            + "lè l fè w mande pou ou lis otan bagay ou kapab nan yon domèn."
        )
    { }

    public void Run()
    {
        DisplayStartMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("Ou gen kèk segond pou reflechi anvan ou kòmanse...");
        PauseWithCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Kòmanse lis ou a kounye a. Peze Antre apre chak bagay.");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Detay: Console.ReadLine bloke pwogram nan pandan l ap tann itilizatè a ekri.
        // Sa vle di si moun nan pa ekri anyen tout tan an ka pase pandan
        // pwogram nan ap tann - se yon senplifikasyon egzèsis la aksepte.
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Ou te ekri {items.Count} bagay total!");

        DisplayEndMessage();
    }
}