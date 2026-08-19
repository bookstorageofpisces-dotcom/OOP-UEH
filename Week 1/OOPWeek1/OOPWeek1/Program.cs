using OOPWeek1;

class Program
{
    static void Main(string[] args)
    {
        Dogs kiki = new Dogs(1, "Co", "Black", "KiKi");
        Console.WriteLine(kiki.GetInfor());
        Student A = new Student("John", 20, "Male", 3);
        Student B = new Student("Jane", 22, "Female", 4);
        Console.WriteLine(A.GetInform());
        Console.WriteLine(B.GetInform());
    }
}