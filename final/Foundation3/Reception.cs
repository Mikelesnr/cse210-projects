class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}