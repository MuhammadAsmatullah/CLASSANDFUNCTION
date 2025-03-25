using System;

class Students
{
    public string Name;
    public int RollNumber;
    public char Grade;

    public Students (string name , int rollNumber , char grade)
    {
        Name = name;
        RollNumber = rollNumber;
        Grade = grade;
    } 
    public void DisplayStudentDetails ()
    {
        Console.WriteLine($"Student Details: Name: {Name} Roll_NO: {RollNumber} Grade: {Grade}");
    }

    class Progarm
    {
        static void Main (string[] args)
        {
            Students s_details = new Students("Muhammad Asmatullah", 2040, 'B');
            s_details.DisplayStudentDetails();
        }
    }
}
