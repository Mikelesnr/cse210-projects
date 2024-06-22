using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        var _journal = new Journal();
        var _choices = new Choices();
        _choices.GetChoices();
        string _choise = _choices._choise;
        while (_choise != "5")
        {
            if (_choise == "1")
            {
                var _prompt1 = new PromptGenerator();
                string _prompt = _prompt1.GetPrompt();
                Console.WriteLine(_prompt);
                Console.Write("> ");
                string _entryText = Console.ReadLine();
                Entry _entry = new Entry(_prompt, _entryText);
                _journal.AddEntry(_entry);

            }
            if (_choise == "2")
            {
                _journal.DisplayAll();
            }
            if (_choise == "3")
            {
                Console.WriteLine("What is the File name :");
                Console.Write("> ");
                string _filename = Console.ReadLine();
                _journal.LoadFromFile(_filename);
            }
            if (_choise == "4")
            {
                Console.WriteLine("What is the File name :");
                Console.Write("> ");
                string _filename = Console.ReadLine();
                _journal.SaveToFile(_filename);
            }

            _choices.GetChoices();
            _choise = _choices._choise;
        }
    }
}