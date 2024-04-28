using System;

class Program
{
    static void Main(string[] args)
    {
//Title
        Console.WriteLine("Grade Calculator");

//This asks for Your Grade precentage, and then turns it into a number.
        Console.WriteLine("What Grade Precentage do you have?");
        string gradeStringCPD = Console.ReadLine();
        int gradeCPD = int.Parse(gradeStringCPD);
//Variables
        string letterCPD = "";
        string plusOrMinusCPD = "";

//This Determines the overall letter grade.
        if (gradeCPD >= 90) 
        {
            letterCPD = "A";
        }
        else if (gradeCPD >= 80)
        {
            letterCPD = "B";
        }
        else if (gradeCPD >= 70)
        {
            letterCPD = "C";
        }
        else if (gradeCPD >= 60)
        {
            letterCPD = "D";
        }
        else
        {
            letterCPD = "F";
        }
//This determines if You have a 'Plus or minus grade'
        if (gradeCPD >= 97)
        {
            plusOrMinusCPD = "!";
        }
        else if (gradeCPD <= 59)
        {
            plusOrMinusCPD = "!";
        }
        else if ((gradeCPD % 10) >= 7)
        {
            plusOrMinusCPD = "+!";
        }
        else if ((gradeCPD % 10) <= 3)
        {
            plusOrMinusCPD = "-!";
        }
//This Determines if you passed or not.
        Console.WriteLine($"Your Grade is a {letterCPD}{plusOrMinusCPD}");
        if (gradeCPD >= 70)
        {
            Console.WriteLine("Congradulations! You Passed!!!!!");
        }
        else
        {
            Console.WriteLine("Sorry, You Failed.  Better Luck Next Time!");
        }
    }
}

/*
Overview
Write a program that determines the letter grade for a course according to the following scale:

A >= 90
B >= 80
C >= 70
D >= 60
F < 60
Assignment
Start by completing the core requirements, then when that part is complete, if you have time, see if you can complete some of the stretch challenges as well.

Please work through the requirements in order rather than jumping ahead to more complicated steps, to ensure that everyone is following the concepts.

Core Requirements
Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
*/