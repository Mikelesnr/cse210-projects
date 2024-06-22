using System;
using System.Collections.Generic;

class Entry
{
    public string _date = DateTime.Now.ToString("MM/dd/yyyy");
    public string _promptText = "";
    public string _entryText = "";
    public Entry(string promptText, string entryText)
    {
        _promptText = promptText;
        _entryText = entryText;

    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}
