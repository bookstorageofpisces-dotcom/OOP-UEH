using BTVN;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Student[] ListStudents = new Student[5];
        ListStudents[0] = new Student("Nguyen Van A", 9);
        ListStudents[1] = new Student("Tran Thi B", 8);
        ListStudents[2] = new Student("Le Van C", 7);
        ListStudents[3] = new Student("Pham Thi D", 6);
        ListStudents[4] = new Student("Hoang Van E", 5);
        Console.WriteLine("Tổng số học sinh:" +Student.GetTotalStudent());
        ListStudents[0].GetTotalStudent();
        foreach (Student student in ListStudents)
        {
            Console.WriteLine("Tên học sinh: " + student.GetName());
            Console.WriteLine("Điểm số: " + student.GetScore());
            Console.WriteLine("Xếp loại: " + student.GetClassification());
            if (student.IsPassed())
            {
                Console.WriteLine("Kết quả: Đậu");
            }
            else
            {
                Console.WriteLine("Kết quả: Rớt");
            }
            Console.WriteLine("-----------------------------");
        }
        Console.WriteLine("Học sinh xuất sắc nhất:"+Student.FindTopStudent(ListStudents));
        Console.WriteLine("Điểm trung bình cả lớp:" + Student.CalculateAverageScore(ListStudents));
    }
}