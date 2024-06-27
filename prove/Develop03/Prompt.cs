using System;
using System.Collections.Generic;

class Prompt
{

    public Prompt()
    {
    }

    public string GetPromptText(string promptText)
    {
        Console.Write($"{promptText} : ");
        return Console.ReadLine();
    }
}