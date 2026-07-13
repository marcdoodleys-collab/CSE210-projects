using System;
using System.Collections.Generic;
using System.IO;


// Cette classe représente le journal complet.
public class Journal
{

    // Liste qui contient toutes les entrées
    private List<Entry> _entries = new List<Entry>();


    // Ajoute une entrée dans le journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    // Affiche toutes les entrées
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }


        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    // Sauvegarde le journal dans un fichier
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }



    // Charge le journal depuis un fichier
    public void LoadFromFile(string file)
    {

        _entries.Clear();


        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);


            foreach (string line in lines)
            {
                Entry entry = new Entry();

                entry.FromFileString(line);

                _entries.Add(entry);
            }


            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}