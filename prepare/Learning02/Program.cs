using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Entry Specialist";
        job1._company = "The Allazo Group";
        job1._startYear = 2017;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "SEO Manager";
        job2._company = "No Joke Marketing";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "SEO Specialist";
        job3._company = "Clean Marketing";
        job3._startYear = 2023;
        job3._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Patrick Ed Viriña";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}