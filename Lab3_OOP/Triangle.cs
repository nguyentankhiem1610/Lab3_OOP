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
            if (random.Next(2) == 1)
            {
                float x = (float)(random.Next(-10, 11));
                float y = (float)(random.Next(-10, 11));
                float z = (float)(random.Next(-10, 11));
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
    public double chuvi()
    {
        return Point.DistanceTo(point1, point2) + Point.DistanceTo(point2, point3) + Point.DistanceTo(point3, point1);
    }
    // Tính diện tích tam giác
    public double dientich()
    {
        double a = Point.DistanceTo(point1, point2);
        double b = Point.DistanceTo(point2, point3);
        double c = Point.DistanceTo(point3, point1);
        double s = chuvi() / 2;
        return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 5);
    }

    // Tính các góc của tam giác
    //    Cách 1: Sử dụng định lý cosin
    // cosA = (b² + c² - a²) / (2bc)
    public static void Angles(Point point1, Point point2, Point point3)
    {
        double a = Point.DistanceTo(point1, point2); //AB
        double b = Point.DistanceTo(point2, point3); //BC
        double c = Point.DistanceTo(point3, point1); //CA
        double angleA = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI;
        double angleB = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI;
        double angleC = 180 - angleA - angleB;
        Console.WriteLine($"Góc A: {angleA:F5} độ ");
        Console.WriteLine($"Góc B: {angleB:F5} độ");
        Console.WriteLine($"Góc C: {angleC:F5} độ");
    }
    //  Cách 2: Sử dụng tích vô hướng của hai vectơ
    // // Tích vô hướng của hai vectơ 
    public static double tichvohuong (Point point1, Point point2, Point point3)
    {
        double vector1_x = point2.X - point1.X;
        double vector1_y = point2.Y - point1.Y;
        double vector1_z = point2.Z - point1.Z;
        double vector2_x = point3.X - point1.X;
        double vector2_y = point3.Y - point1.Y;
        double vector2_z = point3.Z - point1.Z;
        return vector1_x * vector2_x + vector1_y * vector2_y + vector1_z * vector2_z;
    }
    public static void Angles2(Point point1, Point point2, Point point3)
    {
        double a = Point.DistanceTo(point1, point2);
        double b = Point.DistanceTo(point2, point3);
        double c = Point.DistanceTo(point3, point1);
        double dotA = tichvohuong(point1, point2, point3);
        double dotB = tichvohuong(point2, point1, point3);
        double dotC = tichvohuong(point3, point1, point2);
        double angleA = Math.Acos(dotA / (a * c)) * 180 / Math.PI;
        double angleB = Math.Acos(dotB / (a * b)) * 180 / Math.PI;
        double angleC = Math.Acos(dotC / (b * c)) * 180 / Math.PI;
        Console.WriteLine($"Góc A: {angleA:F5} độ ");
        Console.WriteLine($"Góc B: {angleB:F5} độ");
        Console.WriteLine($"Góc C: {angleC:F5} độ");
    }
    // in ra tọa độ tam giác
    public override string ToString()
    {
        return $"Tam giác có 3 đỉnh: A({point1}), B({point2}), C({point3})";
    }

}