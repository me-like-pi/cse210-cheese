using System;

public class Resume
{
    public string _nameCPD;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobsCPD = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_nameCPD}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job jobCPD in _jobsCPD)
        {
            // This calls the Display method on each job
            jobCPD.Display();
        }
    }
}