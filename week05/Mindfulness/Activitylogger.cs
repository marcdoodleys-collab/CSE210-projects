using System.Collections.Generic;
using System.IO;
using System.Linq;

// Klas sa a okipe l ak konte konbyen fwa itilizatè a fè chak aktivite,
// epi li sove enfòmasyon sa a nan yon fichye pou l pa pèdi lè pwogram nan fèmen.
public static class ActivityLogger
{
    private const string LogFile = "activity_log.txt";

    public static Dictionary<string, int> LoadCounts()
    {
        Dictionary<string, int> counts = new Dictionary<string, int>();

        if (File.Exists(LogFile))
        {
            foreach (string line in File.ReadAllLines(LogFile))
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                {
                    counts[parts[0]] = count;
                }
            }
        }

        return counts;
    }

    public static void SaveCounts(Dictionary<string, int> counts)
    {
        List<string> lines = counts.Select(kvp => $"{kvp.Key}:{kvp.Value}").ToList();
        File.WriteAllLines(LogFile, lines);
    }

    public static void Increment(Dictionary<string, int> counts, string activityName)
    {
        if (counts.ContainsKey(activityName))
        {
            counts[activityName]++;
        }
        else
        {
            counts[activityName] = 1;
        }
    }
}