using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Katriyèm aktivite a - se sa m ajoute an plis pou al pi lwen pase sa
// egzèsis la mande. Chak bagay itilizatè a ekri anrejistre nan yon
// fichye tèks pou l ka gade l ankò pita, menm apre l fèmen pwogram nan.
public class GratitudeJournalActivity : Activity
{
    private const string LogFile = "gratitude_log.txt";

    public GratitudeJournalActivity()
        : base(
            "Remèsiman",
            "Aktivite sa a ap ede w rekonèt bagay ou rekonesan pou yo kounye a. "
            + "Chak bagay ou ekri ap sove nan yon ti jounal pou ou ka gade l pita."
        )
    { }

    public void Run()
    {
        DisplayStartMessage();

        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Ekri yon bagay ou rekonesan pou li kounye a: ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                entries.Add(entry);
            }
        }

        // Nou ajoute dat la devan chak antre pou nou ka konnen kilè li te ekri
        File.AppendAllLines(
            LogFile,
            entries.Select(e => $"{DateTime.Now:yyyy-MM-dd HH:mm} - {e}")
        );

        Console.WriteLine();
        Console.WriteLine($"Ou te ajoute {entries.Count} bagay nan jounal remèsiman ou a.");

        DisplayEndMessage();
    }
}