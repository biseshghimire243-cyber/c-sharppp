using System;

class StudentInfo
{
    public string Name;
    public string Faculty;
    public double GPA;

    public StudentInfo(string name, string faculty, double gpa)
    {
        Name = name;
        Faculty = faculty;
        GPA = gpa;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Faculty: " + Faculty);
        Console.WriteLine("GPA: " + GPA);
    }

    public void UpdateGPA(double newGPA)
    {
        GPA = newGPA;
    }
}

class StudentProgram
{
    static void Main()
    {
        StudentInfo s1 = new StudentInfo("Ram", "BSc.CSIT", 3.40);

        s1.ShowDetails();

        Console.WriteLine();

        s1.Name = "Hari";
        s1.UpdateGPA(3.80);

        s1.ShowDetails();
    }
}