using System;

// A code template for a Job. The responsibility of a Job is to hold and
// display the details of a single job (company, title, start/end years).
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}