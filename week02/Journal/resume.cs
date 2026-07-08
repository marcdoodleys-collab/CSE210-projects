using System;
using System.Collections.Generic;

// A code template for a Resume. The responsibility of a Resume is to hold
// a person's name and their list of jobs, and to display them together.
public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}