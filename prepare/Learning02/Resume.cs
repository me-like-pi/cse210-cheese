using System;

public class Resume
{
    public string _nameCPD;

    // initialize the list
    public List<Job> _jobsCPD = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_nameCPD}");
        Console.WriteLine("Jobs:");

        
        foreach (Job jobCPD in _jobsCPD)
        {
            
            jobCPD.Display();
        }
    }
}