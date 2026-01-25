using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = LoadScriptures("scriptures.txt");

            if (scriptures.Count == 0)
            {
                Console.WriteLine("doesn't found scriptures.txt or it's empty.");
                return;
            }
            Random rand = new Random();
            Scripture scripture = scriptures[rand.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\npress enter to begin.");

                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);

                if (scripture.AllHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll the worlds are hidden.");
                    break;
                }
            }
        }
        static List<Scripture> LoadScriptures(string filePath)
        {
            List<Scripture> scriptures = new List<Scripture>();

            if (!System.IO.File.Exists(filePath))
                return scriptures;

            foreach (var line in System.IO.File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 4) continue;

                string book = parts[0];
                int chapter = int.Parse(parts[1]);

                string versePart = parts[2];
                string text = parts[3];

                Reference reference;
                if (versePart.Contains("-"))
                {
                    var range = versePart.Split('-');
                    reference = new Reference(book, chapter, int.Parse(range[0]), int.Parse(range[1]));
                }
                else
                {
                    reference = new Reference(book, chapter, int.Parse(versePart));
                }

                scriptures.Add(new Scripture(reference, text));
            }

            return scriptures;
        }
    }
}