using System;

public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startDate;
    public int _endDate;

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startDate}--{_endDate}");
    }
} 