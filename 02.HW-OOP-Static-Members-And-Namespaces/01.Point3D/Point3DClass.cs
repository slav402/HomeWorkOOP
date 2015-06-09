using System;

class Point3D
{
    private static int counter = 0;
    private static readonly Point3D startPoint = new Point3D(0,0,0);


    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
        counter++;
    }

    public static Point3D StartPoint
    {
        get { return startPoint; }
    }

    public int PointCurrentNumber 
    {
        get { return counter; }
    }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return string.Format("X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
    }
}
