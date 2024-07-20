public class Video
{
    public string _title;
    public string _author;
    public Time _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, String length)
    {
        _title = title;
        _author = author;
        _length = new Time(length);
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length.GetTimeString()}");

        Console.WriteLine($"Comments ({GetNumComments()}):");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

    }

    private int GetNumComments()
    {
        int numComments = _comments.Count();
        return numComments;
    }
}

