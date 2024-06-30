using System;

class Scripture
{
    private readonly string _text;
    private readonly string _reference;

    private List<Word> _words = new List<Word>();


    public Scripture(string reference, string text)
    {
        _text = text;
        _reference = reference;
        MakeWords();
    }

    public bool IsCompletelyHidden()
    {
        bool isHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return isHidden;
    }

    public string GetDisplayText()
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            scripture = scripture + " " + word.GetDisplayText();
        }
        return scripture;
    }

    public void MakeWords()
    {
        List<string> words = _text.Split(new char[] { ' ' }).ToList();
        foreach (string word in words)
        {
            var myword = new Word(word);
            _words.Add(myword);

        }
        Console.Clear();
        Console.WriteLine($"{_reference} {_text}");

    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int numToHide = random.Next(1, _words.Count); // Random number of words to hide

        for (int i = 0; i < numToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }
}