class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, TimeSpan lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Calculate distance using speed (assuming constant speed during the activity)
        return _speed * LengthMinutes.TotalHours;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public new string GetSummary()
    {
        var distanceKm = GetDistance();
        var distanceMiles = distanceKm * 0.62; // Convert km to mile

        return $"{base.GetSummary()} - Cycling\nDistance {distanceKm:F1} km ({distanceMiles:F1} miles)\nSpeed {_speed:F1} kph\nPace: {GetPace():F2} min per km\n";
    }
}
