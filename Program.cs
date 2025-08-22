/*Một lớp Point trong không gian 3 chiều có ba tọa độ float x, y, z. 
Câu 1: Khai báo lớp Point ở trên cùng với các method getter, setter, constructor cần thiết
Câu 2: Bổ sung một biến thành viên có tên là Counter ở mức truy cập là public và là thành viên tĩnh (static).
 Điều chỉnh constructor để đảm bảo rằng biến Counter cho phép đếm số lượng các Point được tạo ra
Câu 3: Thêm phương thức tính khoảng cách giữa hai Point

Một lớp tam giác Triangle được cấu tạo từ 3 Point. 
Câu 4: Khai báo lớp Triangle cùng với method getter, setter, constructor tương ứng
Câu 5: Bổ sung một phương thức khởi tạo (không phải constructor) tên là Generate để tạo ra một list các Point. 
Việc khởi tọa này được thực thi bên trong một vòng lặp (lặp khoảng 50 lần). 
Bên trong sử dụng một biến ngẫu nhiên có giá trị true false để đảm bảo rằng số lượng điểm được sinh ra không được kiểm soát. 
Các điểm được sinh ra có thể được bổ sung vào trong 1 list
Câu 6: Cho biết số lượng Point được tạo ra thông qua biến Counter (không truy cập vào method length của list)
Câu 7: Bổ sung method tính chu vi cho lớp Triangle
Câu 8: Bổ sung method tính diện tích 
Câu 9: Bổ sung method xác định độ lớn các góc của tam giác
Câu 10: Trong hàm main, chọn random 3 Point trong list của method Generate để tạo thành một tam giác bất kỳ. 
Sau đó gọi các phương thức đã xây dựng trong lớp Triangle (7 -> 8 -> 9).
 Đồng thời in ra độ dài các cạnh của tam giác (thông qua method khoảng cách của lớp Point)
*/

using System;
using System.Collections.Generic;
namespace Lab3_OOP;
class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách các Point
        List<Point> points = Triangle.Generate();
        
        // Chọn ngẫu nhiên 3 Point từ danh sách
        Random random = new Random();
        int point1 = random.Next(points.Count);
        int point2;
        do
        {
            point2 = random.Next(points.Count);
        } while (point2 == point1);
        
        int point3;
        do
        {
            point3 = random.Next(points.Count);
        } while (point3 == point1 || point3 == point2);

        Point p1 = points[point1];
        Point p2 = points[point2];
        Point p3 = points[point3];

        // Tạo tam giác từ 3 Point đã chọn
        Triangle triangle = new Triangle(p1, p2, p3);
        // Số lượng Point được tạo ra
        Console.WriteLine($"Số lượng Point được tạo ra: {Triangle.CountPoints()}");
        // In ra độ dài các cạnh của tam giác
        Console.WriteLine($"Độ dài cạnh AB: {Point.DistanceTo(p1, p2):F5}");
        Console.WriteLine($"Độ dài cạnh AC: {Point.DistanceTo(p2, p3):F5}");
        Console.WriteLine($"Độ dài cạnh BC: {Point.DistanceTo(p3, p1):F5}");        

        // Tính chu vi, diện tích và góc của tam giác
        double perimeter = triangle.Perimeter();
        double area = triangle.Area();
        
        Console.WriteLine($"Chu vi tam giác: {perimeter}");
        Console.WriteLine($"Diện tích tam giác: {area}");
        // Tính các góc của tam giác
        Triangle.Angles(p1, p2, p3);



    }
}