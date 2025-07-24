namespace OOP_5;
class program
{
    static void Main(string[] args)
    {
        #region Q1
        //        Point3D P1 = ReadPoint("P1");
        //        Point3D P2 = ReadPoint("P2");
        //        Console.WriteLine(P1.ToString());
        //        Console.WriteLine(P2.ToString());

        //        Console.WriteLine(P1 == P2 ? "P1 equal P2." : "P1 not equal P2.");

        //        Point3D[] points = new Point3D[]
        //        {
        //            new Point3D(3,2,5),
        //            new Point3D(1,4,3),
        //            new Point3D(1,2,1),
        //            new Point3D(2,2,2)
        //        };

        //        Array.Sort(points);
        //        foreach (var pt in points)
        //            Console.WriteLine(pt);

        //        Point3D clone = (Point3D)P1.Clone();
        //        Console.WriteLine($"\nCloned P1: {clone}");
        //    }
        //    static Point3D ReadPoint(string label)
        //    {
        //        int x = 0, y = 0, z = 0;

        //        Console.WriteLine($"\nEnter coordinates for {label}:");

        //        while (true)
        //        {
        //            Console.Write("Point X: ");
        //            string input = Console.ReadLine();
        //            if (int.TryParse(input, out x)) break;
        //            Console.WriteLine("Invalid Input.");
        //        }

        //        while (true)
        //        {
        //            Console.Write("Point Y: ");
        //            string input = Console.ReadLine();
        //            if (int.TryParse(input, out y)) break;
        //            Console.WriteLine("Invalid Input.");
        //        }

        //        while (true)
        //        {
        //            Console.Write("Point Z: ");
        //            string input = Console.ReadLine();
        //            if (int.TryParse(input, out z)) break;
        //            Console.WriteLine("Invalid Input.");
        //        }

        //        return new Point3D(x, y, z);
        //    }
        //    #endregion
        #endregion

        #region Q2
        //Console.WriteLine("Addition: " + Maths.Add(20, 10));
        //Console.WriteLine("Subtraction: " + Maths.Subtract(20, 10));
        //Console.WriteLine("Multiplication: " + Maths.Multiply(20, 10));
        //Console.WriteLine("Division: " + Maths.Divide(20, 10));
        #endregion
    }

#region Q1
//public class Point3D : IComparable<Point3D>, ICloneable
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public int Z { get; set; }
//    public Point3D() : this(0, 0, 0) { }
//    public Point3D(int x, int y) : this(x, y, 0) { }
//    public Point3D(int x, int y, int z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }
//    public override string ToString()
//    {
//        return $"Point Coordinates: ({X}, {Y}, {Z})";
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj is Point3D p)
//            return X == p.X && Y == p.Y && Z == p.Z;
//        return false;
//    }
//    public override int GetHashCode()
//    {
//        return HashCode.Combine(X, Y, Z);
//    }
//    public static bool operator ==(Point3D p1, Point3D p2)
//    {
//        if (ReferenceEquals(p1, p2)) return true;
//        if (p1 is null || p2 is null) return false;
//        return p1.Equals(p2);
//    }
//    public static bool operator !=(Point3D p1, Point3D p2)
//    {
//        return !(p1 == p2);
//    }
//    public int CompareTo(Point3D other)
//    {
//        if (X != other.X)
//            return X.CompareTo(other.X);
//        return Y.CompareTo(other.Y);
//    }
//    public object Clone()
//    {
//        return new Point3D(X, Y, Z);
//    }
//}
#endregion

#region Q2
//public static class Maths
//{
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public static int Subtract(int a, int b)
//    {
//        return a - b;
//    }
//    public static int Multiply(int a, int b)
//    {
//        return a * b;
//    }
//    public static double Divide(int a, int b)
//    {
//        if (b == 0)
//        {
//            Console.WriteLine("Error");
//            return double.NaN;
//        }
//        return (double)a / b;
//    }
//}

#endregion