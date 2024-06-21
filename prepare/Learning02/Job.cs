using System;
using System.Collections.Generic;

class Job
{
    public string _company { get; }
    public string _jobTitle { get; }
    public int _startYear { get; }
    public int _endYear { get; }

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}