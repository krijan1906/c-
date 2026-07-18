using System;

public partial class Student
{
    public void DisplayName()
    {
        Console.WriteLine("Name : Ram");
    }
}

public partial class Student
{
    public void DisplayAge()
    {
        Console.WriteLine("Age : 20");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.DisplayName();
        s.DisplayAge();
    }
}