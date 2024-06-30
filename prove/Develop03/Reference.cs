using System;

class Reference
{
    private readonly string _book;
    private readonly string _chapter;
    private readonly string _verse;
    private readonly string _endVerse;

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetUrl()
    {
        return $"https://bible-api.com/{_book}+{_chapter}:{_verse}-{_endVerse}";
    }

    public string GetScripture()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
