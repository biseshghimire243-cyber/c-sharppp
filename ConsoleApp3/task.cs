using System;

class StaffInfo
{
    public string FirstName;
    public string LastName;
    public double Salary;

   
    public StaffInfo(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

   
    public void ShowFullName()
    {
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
    }

    
    public void IncrementSalary(double amount)
    {
        Salary += amount;
    }

    
    public void ShowSalary()
    {
        Console.WriteLine("Salary: " + Salary);
    }
}

class StaffProgram
{
    static void Main()
    {
        StaffInfo emp = new StaffInfo("Ra", "Bahadur", 20000);

        Console.WriteLine("Employee Details:");
        emp.ShowFullName();
        emp.ShowSalary();

        Console.WriteLine();

        emp.FirstName = "Hari";
        emp.IncrementSalary(5000);

        Console.WriteLine("Updated Employee Details:");
        emp.ShowFullName();
        emp.ShowSalary();
    }
}