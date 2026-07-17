using System;
class student
{
    string name;
    int id;
    public student()
    {
        name = "krijan";
        id = 3;
    }
    public student(string name,int id)
    {
        this.name = name;
        this.id = id;

    }
    public student(string name)
    {
        this.name = name;
        this.id = 5;
    }
    public void display()
    {
        Console.WriteLine("name :" + name);
        Console.WriteLine("id:" + id);

    }


}
class program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        s1.display();
        student s2 = new student("krijan");
        s2.display();
        student s3 = new student("bibek", 4);
        s3.display();
    }
}