using System;

namespace _02.DistanceCalculator.Tools
{
    class Program
    {
        static void Main()
        {
            Point3D a = new Point3D(2, 3, 6);
            Point3D b = new Point3D(12, 33, 106);

            Console.WriteLine(DistanceCalculator.DistCalc(a, b));
        }
    }

}
    
