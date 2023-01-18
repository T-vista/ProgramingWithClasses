using System;

public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public string _startDate = "";
    public string _endDate = "";

    public Job()
    {  
    }

    public void display()
    {
        Console.WriteLine(_jobTitle);
        Console.WriteLine(_company);
    }
} 