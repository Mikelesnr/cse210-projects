using System;
using System.Collections.Generic;

class Resume
{
    public string _name = "";
    private List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.DisplayInfo();
        }
    }
}