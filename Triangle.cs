namespace Lab3_OOP;
public class Triangle
{
    private Point point1;
    private Point point2;
    private Point point3;
    public Point Point1
    {
        get { return point1; }
        set { point1 = value; }
    }
    public Point Point2
    {
        get { return point2; }
        set { point2 = value; }
    }
    public Point Point3
    {
        get { return point3; }
        set { point3 = value; }
    }
    public Triangle(Point p1, Point p2, Point p3)
    {
        this.point1 = p1;
        this.point2 = p2;
        this.point3 = p3;
    }
    // Phương thức khởi tạo để tạo ra một list các Point
    public static List<Point> Generate()
    {
        List<Point> points = new List<Point>();
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            int random = rand.Next(0, 2);

            if (random == 0)
            {
                continue;
            }
            else
            {
                float x = rand.Next(-10, 10);
                float y = rand.Next(-10, 10);
                float z = rand.Next(-10, 10);
                points.Add(new Point(x, y, z));
            }
        }
        return points;
    }
    // Số lượng Point được tạo ra
    public static int CountPoints()
    {
        return Point.Counter;
    }
    // Tính chu vi tam giác
    public double Perimeter()
    {
        return Point.DistanceTo(point1, point2) + Point.DistanceTo(point2, point3) + Point.DistanceTo(point3, point1);
    }
    // Tính diện tích tam giác
    public double Area()
    {
        double a = Point.DistanceTo(point1, point2);
        double b = Point.DistanceTo(point2, point3);
        double c = Point.DistanceTo(point3, point1);
        double s = Perimeter() / 2;
        return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)),5);
    }
    // Tính các góc của tam giác
    // cosA = (b² + c² - a²) / (2bc)
    public static void Angles(Point point1, Point point2, Point point3)
    {
        double a = Point.DistanceTo(point1, point2);
        double b = Point.DistanceTo(point2, point3);
        double c = Point.DistanceTo(point3, point1);
        double angleA = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI;
        double angleB = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI;
        double angleC = 180 - angleA - angleB;
        Console.WriteLine($"Góc A: {angleA:F5} độ ");
        Console.WriteLine($"Góc B: {angleB:F5} độ");
        Console.WriteLine($"Góc C: {angleC:F5} độ");
    }
}
