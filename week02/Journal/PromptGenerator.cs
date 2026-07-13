using System;
using System.Collections.Generic;


// Cette classe fournit des questions aléatoires.
public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best thing that happened today?",
        "What did you learn today?",
        "Who helped you today?",
        "What challenge did you face today?",
        "What are you grateful for today?"
    };


    private Random _random = new Random();


    // Retourne une question aléatoire
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}