using System;

class Word
{
    private readonly string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
        Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('-', _text.Length);
        }
        return _text;
    }
}