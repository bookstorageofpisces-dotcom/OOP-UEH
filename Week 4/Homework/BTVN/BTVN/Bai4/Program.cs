using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SachGiaoKhoa s1 = new SachGiaoKhoa("SGK001",new DateTime(2026, 9, 18),20000, 5,"Kim Dong",true);
            SachGiaoKhoa s2 = new SachGiaoKhoa("SGK002", new DateTime(2026, 9, 18), 25000, 3, "Tre", false);
            SachGiaoKhoa s3 = new SachGiaoKhoa("SGK003", new DateTime(2026, 9, 18), 30000, 2, "Kim Dong", true);
            SachThamKhao s4 = new SachThamKhao("STK001", new DateTime(2026, 9, 18), 15000, 4, "Tre", 10);
            SachThamKhao s5 = new SachThamKhao("STK002", new DateTime(2026, 9, 18), 20000, 6, "Kim Dong", 15);
            SachThamKhao s6 = new SachThamKhao("STK003", new DateTime(2026, 9, 18), 25000, 8, "Tre", 20);
            DanhSachSach ds = new DanhSachSach(10);
            ds.them(s1);
            ds.them(s2);
            ds.them(s3);
            ds.them(s4);
            ds.them(s5);
            ds.them(s6);
            //Tổng Thành Tiền từng loại
            Console.WriteLine("Tổng thành tiền sách giáo khoa: " + ds.tinhTongThanhTienSGK());
            Console.WriteLine("Tổng thành tiền sách tham khảo: " + ds.tinhTongThanhTienSTK());
            //Xuất ra các sách giáo khoa của nhà xuất bản K (yêu cầu nhập K).
            Console.WriteLine("Nhập tên nhà xuất bản cần tìm: ");
            string nxb = Console.ReadLine();
            List<Sach> sachTheoNXB = ds.timSGKTheoNXB(nxb);
            foreach (Sach sach in sachTheoNXB)
            {
                Console.WriteLine(sach.toString());
            }
            //Tìm thành tiền cao nhất.
            Console.WriteLine("Thành tiền cao nhất: " + ds.timThanhTienCaoNhat());
        }
    }
}
