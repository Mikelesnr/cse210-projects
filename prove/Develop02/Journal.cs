using System;
using System.Collections.Generic;

class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("");
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void SaveToFile(string filename)
    {
        string file = CheckFilename(filename, 4);
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // add text
                outputFile.WriteLine("");
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine($"{entry._entryText}");
            }
            outputFile.WriteLine("");
        }
    }

    public void LoadFromFile(string filename)
    {
        string file = CheckFilename(filename, 4);
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    private string CheckFilename(string filename, int tail_length)
    {
        // this method checks if filename has extctention and adds .txt if it is missing 
        if (tail_length >= filename.Length)
            return filename + ".txt";
        string tail = filename.Substring(filename.Length - tail_length);
        if (tail == ".txt")
            return filename;
        return filename + ".txt";
    }
}