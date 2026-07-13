using System;

// La classe Entry représente UNE entrée du journal.
public class Entry
{
    // Date de création de l'entrée
    public string _date = "";

    // Question donnée à l'utilisateur
    public string _promptText = "";

    // Réponse écrite par l'utilisateur
    public string _entryText = "";


    // Affiche une entrée complète
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-----------------------------");
    }


    // Transforme une entrée en texte pour sauvegarde
    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }


    // Recrée une entrée à partir d'une ligne du fichier
    public void FromFileString(string line)
    {
        string[] parts = line.Split("|");

        if (parts.Length >= 3)
        {
            _date = parts[0];
            _promptText = parts[1];
            _entryText = parts[2];
        }
    }
}