using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startDate = 2019;
        job1._endDate = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Amazon";
        job2._startDate = 2022;
        job2._endDate = 2023;

        // job1.display();
        // job2.display();

        Resume resume1 = new Resume();
        resume1._name = "Resume";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.display();
    }
}