using System;

class EmployeeDetails
{
    protected int empId;
    protected string empName;
    protected string empGender;
    protected string empAddress;
    protected string empPosition;

    public EmployeeDetails(int id, string name, string gender, string address, string position)
    {
        empId = id;
        empName = name;
        empGender = gender;
        empAddress = address;
        empPosition = position;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID : " + empId);
        Console.WriteLine("Name        : " + empName);
        Console.WriteLine("Gender      : " + empGender);
        Console.WriteLine("Address     : " + empAddress);
        Console.WriteLine("Position    : " + empPosition);
    }
}

class SalaryInfo : EmployeeDetails
{
    private double salary;

    public SalaryInfo(int id, string name, string gender, string address, string position, double sal)
        : base(id, name, gender, address, position)
    {
        salary = sal;
    }

    public void calcTax()
    {
        double tax = 0;

        if (salary <= 400000)
            tax = salary * 0.01;
        else if (salary <= 800000)
            tax = salary * 0.10;
        else
            tax = salary * 0.20;

        double finalSalary = salary - tax;

        Console.WriteLine("Salary       : " + salary);
        Console.WriteLine("Tax          : " + tax);
        Console.WriteLine("Final Salary : " + finalSalary);
    }
}

class Program
{
    static void Main()
    {
        SalaryInfo emp = new SalaryInfo(
            101,
            "Ram",
            "Male",
            "Kathmandu",
            "Manager",
            900000
        );

        emp.Display();

        emp.calcTax();
    }
}