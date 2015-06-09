using System;

class Program
{
    static void Main()
    {
        Point3D a = new Point3D(2,3,6);
        Console.WriteLine("Point {0} --> {1}", a.PointCurrentNumber, a);
        
        Point3D b = new Point3D(4,4,8);
        Console.WriteLine("Point {0} --> {1}", b.PointCurrentNumber, b);

        Console.WriteLine("Starting point --> {0}", Point3D.StartPoint);
        
    }
}

