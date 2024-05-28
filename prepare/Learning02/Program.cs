using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1CPD = new Job();
        job1CPD._jobTitleCPD = "Relm Ranger";
        job1CPD._companyCPD = "Wizard Quest";
        job1CPD._startYearCPD = 2015;
        job1CPD._endYearCPD = 2020;

        Job job2CPD = new Job();
        job2CPD._jobTitleCPD = "Missionary";
        job2CPD._companyCPD = "Kisha e Jezu Krishtit - Shqipëria";
        job2CPD._startYearCPD = 2020;
        job2CPD._endYearCPD = 2022;

        Job job3CPD = new Job();
        job3CPD._jobTitleCPD = "Harvest Truck Driver";
        job3CPD._companyCPD = "Dance Farms";
        job3CPD._startYearCPD = 2022;
        job3CPD._endYearCPD = 2022;

        Resume myResumeCPD = new Resume();
        myResumeCPD._nameCPD = "Chandler Dance";

        myResumeCPD._jobsCPD.Add(job1CPD);
        myResumeCPD._jobsCPD.Add(job2CPD);
        myResumeCPD._jobsCPD.Add(job3CPD);

        myResumeCPD.Display();
    }
}