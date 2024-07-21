class Running : Activity
{
    private double _distance;

    public Running(DateTime date, TimeSpan lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / LengthMinutes.TotalHours;
    }

    public override double GetPace()
    {
        return LengthMinutes.TotalMinutes / _distance;
    }

    public new string GetSummary()
    {
        return $"{base.GetSummary()} - Running\nDistance {_distance:F1} miles\nSpeed {GetSpeed():F1} mph\nPace: {GetPace():F1} min per mile\n";
    }
}
