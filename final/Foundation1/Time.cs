public class Time
{
    public TimeSpan _videoLength;

    public Time(string videoLength)
    {
        SetVideoLength(videoLength);
    }
    public string GetTimeString()
    {
        string formattedDuration = _videoLength.ToString(@"hh\:mm\:ss");
        return formattedDuration;
    }


    private void SetVideoLength(string time)
    {
        int hour = 0;
        int minute = 0;
        int second = 0;

        List<string> TimeList = time.Split(':').ToList();
        if (TimeList.Count == 3)
        {
            hour = int.Parse(TimeList[0]);
            minute = int.Parse(TimeList[1]);
            second = int.Parse(TimeList[2]);
        }
        else if (TimeList.Count == 2)
        {
            minute = int.Parse(TimeList[0]);
            second = int.Parse(TimeList[1]);
        }
        else
        {
            second = int.Parse(time);
        }
        _videoLength = new TimeSpan(hour, minute, second);
    }
}