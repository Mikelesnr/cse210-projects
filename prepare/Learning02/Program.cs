using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var job1 = new Job(company: "Microsoft", jobTitle: "Software Engineer", startYear: 2019, endYear: 2022);
        var job2 = new Job(company: "Apple", jobTitle: "Manager", startYear: 2022, endYear: 2023);

        var resume = new Resume(name: "Allison Rose");
        resume.AddJob(job1);
        resume.AddJob(job2);

        resume.DisplayResume();
    }
}