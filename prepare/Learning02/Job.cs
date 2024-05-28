using System;

public class Job
{
    public string _jobTitleCPD;
    public string _companyCPD;
    public int _startYearCPD;
    public int _endYearCPD;

    public void Display()
    {
        Console.WriteLine($"{_jobTitleCPD} ({_companyCPD}) {_startYearCPD}-{_endYearCPD}");
    }
}
