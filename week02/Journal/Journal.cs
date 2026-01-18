using System;
using systenm.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = List<Entry>();

    public void AddEntry(Entry entry)   {
        entries = Add(entry);
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
   
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal save in {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("The File doesn't exist.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
        Console.WriteLine($"Journal upload from  {filename}");
    }
}
