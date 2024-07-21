class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, TimeSpan lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthMinutes.TotalHours;
    }

    public override double GetPace()
    {
        return LengthMinutes.TotalMinutes / GetDistance();
    }

    public new string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming\nDistance {GetDistance():F1} km\nSpeed {GetSpeed():F1} kph\nPace: {GetPace():F2} min per km";
    }
}