class Activity
{
    private DateTime _date;
    private TimeSpan _lengthMinutes;

    public Activity(DateTime date, TimeSpan lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public TimeSpan LengthMinutes
    {
        get { return _lengthMinutes; }
    }

    public virtual double GetDistance()
    {
        // To be overridden by derived classes
        return 0;
    }

    public virtual double GetSpeed()
    {
        // To be overridden by derived classes
        return 0;
    }

    public virtual double GetPace()
    {
        // To be overridden by derived classes
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {_lengthMinutes.TotalMinutes} min";
    }
}
