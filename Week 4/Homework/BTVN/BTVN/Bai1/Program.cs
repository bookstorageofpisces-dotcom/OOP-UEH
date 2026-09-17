using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NgoaiThanh xe1 = new NgoaiThanh("ABC123", "Thành", "XYZ789", "Hà Nội", 5, 1000000);
            NgoaiThanh xe2 = new NgoaiThanh("DEF456", "Danh", "PQR345", "Đà Nẵng", 3, 800000); 
            NoiThanh xe3 = new NoiThanh("GHI789", "Tài", "STU678", 10, 200, 500000);
            NoiThanh xe4 = new NoiThanh("JKL012", "Hậu", "VWX901", 5, 150, 300000);
            int TongDoanhThuTatCa= xe1.XemDoanhThu() + xe2.XemDoanhThu() + xe3.XemDoanhThu() + xe4.XemDoanhThu();
            int TongDoanhThuNgoaiThanh = xe1.XemDoanhThu() + xe2.XemDoanhThu();
            int TongDoanhThuNoiThanh = xe3.XemDoanhThu() + xe4.XemDoanhThu();
            Console.WriteLine("Tổng doanh thu của tất cả các xe: " + TongDoanhThuTatCa);
            Console.WriteLine("Tổng doanh thu của các xe ngoại thành: " + TongDoanhThuNgoaiThanh);
            Console.WriteLine("Tổng doanh thu của các xe nội thành: " + TongDoanhThuNoiThanh);
        }
    }
}
