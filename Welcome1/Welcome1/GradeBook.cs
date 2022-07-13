// Class declaration with a method that has a parameter.
using System;

public class GradeBook
{
   public string CourseName { get; set; }

    public GradeBook(string name)
    {
        CourseName = name;
    }
    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName);
    }
} // end class GradeBook