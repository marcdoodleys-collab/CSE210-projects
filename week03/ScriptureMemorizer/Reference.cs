using System;

namespace ScriptureMemorizer
{
    // Represente la reference d'une ecriture (ex: "John 3:16" ou "Proverbs 3:5-6")
    public class Reference
    {
        private readonly string _book;
        private readonly int _chapter;
        private readonly int _verse;
        private readonly int _endVerse;

        // Constructeur pour un seul verset : ex Reference("John", 3, 16)
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = verse;
        }

        // Constructeur pour une plage de versets : ex Reference("Proverbs", 3, 5, 6)
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            if (_verse == _endVerse)
            {
                return $"{_book} {_chapter}:{_verse}";
            }

            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}