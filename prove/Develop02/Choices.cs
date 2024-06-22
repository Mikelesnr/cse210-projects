using System;
using System.Collections.Generic;

class Choices
{
    public string _choise = "";
    private List<string> _choices = new List<string>();

    public Choices()
    {
        _choices =
        [
            "Write", "Display", "Load", "Save", "Quit"];
    }

    public void GetChoices()
    {
        Console.WriteLine("Please select one of the following choices :");
        for (int i = 0; i < _choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_choices[i]}");
        };
        Console.Write("What would you like to do? ");
        _choise = Console.ReadLine();
    }
}
