using System;

class Shape
{
    private int length;
    private int breadth;
    private int height;

    // Rectangle Constructor
    public Shape(int l, int b)
    {
        length = l;
        breadth = b;
    }

    // Box Constructor
    public Shape(int l, int b, int h)
    {
        length = l;
        breadth = b;
        height = h;
    }

    public void FindAreaRectangle()
    {
        Console.WriteLine("Area = " + (length * breadth));
    }

    public void FindVolumeBox()
    {
        Console.WriteLine("Volume = " + (length * breadth * height));
    }
}

class Program
{
    static void Main()
    {
        Shape rectangle = new Shape(10, 5);

        rectangle.FindAreaRectangle();

        Shape box = new Shape(10, 5, 4);

        box.FindVolumeBox();
    }
}