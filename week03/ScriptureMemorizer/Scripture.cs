using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    // Represente le verset complet : sa reference et la liste de ses mots
    public class Scripture
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;
        private readonly Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        // Depassement des exigences : on ne tire au sort que parmi les mots
        // encore visibles, pour ne pas "gaspiller" un tour sur un mot deja cache.
        public void HideRandomWords(int numberToHide)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            int count = Math.Min(numberToHide, visibleWords.Count);

            for (int i = 0; i < count; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }

        public string GetDisplayText()
        {
            string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{_reference.GetDisplayText()}\n\n{wordsText}";
        }
    }
}