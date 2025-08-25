namespace Lab3_OOP;

public class Point
{
    private float x;
    private float y;
    private float z;
    public static int Counter = 0;
    public float X
    {
        get { return x; }
        set { x = value; }
    }
    public float Y
    {
        get { return y; }
        set { y = value; }
    }
    public float Z
    {
        get { return z; }
        set { z = value; }
    }
    public Point(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        Counter++;
    }
    // Tính khoảng cách giữa hai Point
    public static double DistanceTo(Point p1, Point p2)
    {
        return Math.Round(Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2) + Math.Pow(p2.Z - p1.Z, 2)), 5);
    }
    public override string ToString()
    {
        return $"{x}, {y}, {z}";
    }
}