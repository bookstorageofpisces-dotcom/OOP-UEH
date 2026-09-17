using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SachGiaoKhoa sach1 = new SachGiaoKhoa("SGK001", 2023, 100000, 10, "KimDong", "moi");
            SachGiaoKhoa sach2 = new SachGiaoKhoa("SGK002", 2023, 120000, 5, "NXBTre", "cu");
            SachGiaoKhoa sach3 = new SachGiaoKhoa("SGK003", 2023, 150000, 8, "KimDong", "moi");
            SachThamKhao sach4 = new SachThamKhao("STK001", 2023, 200000, 15, "NXBTre", 10);
            SachThamKhao sach5 = new SachThamKhao("STK002", 2023, 250000, 12, "KimDong", 15);
            SachThamKhao sach6 = new SachThamKhao("STK003", 2023, 300000, 20, "NXBTre", 20);
            Sach[] List = { sach1, sach2, sach3, sach4, sach5, sach6 };
            //Tổng Thành Tiền từng loại
            Console.WriteLine("Tổng thành tiền của sách giáo khoa: " + (sach1.TinhThanhTien() + sach2.TinhThanhTien() + sach3.TinhThanhTien()));
            Console.WriteLine("Tổng thành tiền của sách tham khảo: " + (sach4.TinhThanhTien() + sach5.TinhThanhTien() + sach6.TinhThanhTien()));
            //Xuất ra các sách giáo khoa của nhà xuất bản K (yêu cầu nhập K).
            Console.Write("Nhập tên nhà xuất bản cần tìm: ");
            string tenNXB = Console.ReadLine();
            foreach (Sach sach in List)
            {
                if (sach is SachGiaoKhoa && sach.NXB == tenNXB)
                {
                    Console.WriteLine($"Mã sách: {sach.MaSach}, Ngày nhập: {sach.NgayNhap}, Đơn giá: {sach.DonGia}, Số lượng: {sach.SoLuong}, Nhà xuất bản: {sach.NXB}");
                }
            }
            //Tìm thành tiền cao nhất.
            double Max = 0;
            foreach (Sach sach in List)
            {
                if (sach.TinhThanhTien() > Max)
                {
                    Max = sach.TinhThanhTien();
                }
            }
            Console.WriteLine("Thành tiền cao nhất là: " + Max);
        }
    }
}
