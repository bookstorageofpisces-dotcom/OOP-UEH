using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dữ liệu hàng hoá mẫu:
            ThucPham tp1 = new ThucPham("TP0001", "Thịt heo", 100000, 50, "DoMiXi", DateTime.Now, new DateTime(2026,10,20));
            ThucPham tp2 = new ThucPham("TP0002", "Thịt bò", 200000, 30, "DoMiXi", DateTime.Now, new DateTime(2026, 10, 20));
            ThucPham tp3 = new ThucPham("TP0003", "Thịt gà", 150000, 20, "DoMiXi", DateTime.Now, new DateTime(2026, 10, 20));
            SanhSu ss1= new SanhSu("SS0001", "Bình Hoa",2500000, 10, "LGBT", DateTime.Now);
            SanhSu ss2 = new SanhSu("SS0002", "Bát Gốm", 250000, 5, "LGBT", DateTime.Now);
            SanhSu ss3 = new SanhSu("SS0003", "Đĩa Gốm", 150000, 15, "LGBT", DateTime.Now);
            DienMay dd1 = new DienMay("DM0001", "Tivi", 10000000, 5, 24, 100);
            DienMay dd2 = new DienMay("DM0002", "Tủ Lạnh", 15000000, 3, 36, 200);
            DienMay dd3 = new DienMay("DM0003", "Máy Giặt", 12000000, 2, 12, 150);
            DanhSachHangHoa danhSachHangHoa = null;
            do
            {
                Console.WriteLine("--------------------MENU-------------------");
                Console.WriteLine("1.Khởi tạo danh sách hàng hóa");
                Console.WriteLine("2.Thêm hàng hóa vào danh sách");
                Console.WriteLine("3.Hiển thị thông tin tất cả hàng hóa");
                Console.WriteLine("4.Hiển thị thông tin hàng hóa theo loại");
                Console.WriteLine("5.Tìm kiếm hàng hoá theo mã hàng");
                Console.WriteLine("6.Sắp xếp hàng hóa theo tên hàng tăng dần");
                Console.WriteLine("7.Sắp xếp hàng hóa theo số lượng tồn giảm dần");
                Console.WriteLine("8.Lấy thông tin hàng thực phẩm khó bán");
                Console.WriteLine("9.Xóa hàng hóa theo mã hàng");
                Console.WriteLine("10.Sửa đơn giá theo mã hàng");
                Console.WriteLine("11.Thoát");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                switch (Console.ReadLine())
                {
                    case "11":
                        return;
                    case "1":
                        Console.WriteLine("Nhập số lượng hàng hóa tối đa: ");
                        int size = int.Parse(Console.ReadLine());
                        danhSachHangHoa = new DanhSachHangHoa(size);
                        break;
                    case "2":
                        break;
                    case "3":
                        danhSachHangHoa.DisplayAllProductInfo();
                        break;
                }
            }
            while (true);
        }
    }
}
