using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("--------------------MENU-------------------");
                Console.WriteLine("0.Khởi tạo hàng hoá");
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
                    case "0":
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }
            while (true);
        }
    }
}
