using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class Program
    {
        private void TaoHangDienMay(string mahang, string tenhang, double dongia, double soluongton, double tgbh, double congsuat)
        {
            //public DienMay(string mahang, string tenhang, double dongia, double soluongton, double tgbh, double congsuat)
            new DienMay(mahang, tenhang, dongia, soluongton, tgbh, congsuat);
        }
        private void TaoHangSanhSu(string mahang, string tenhang, double dongia, double soluongton, string nhasanxuat, DateTime ngaynhapkho)
        {
            //public SanhSu(string mahang, string tenhang, double dongia, double soluongton, string nhasanxuat, DateTime ngaynhapkho)
            new SanhSu(mahang, tenhang, dongia, soluongton, nhasanxuat, ngaynhapkho);
        }
        private void TaoHangThucPham(string mahang, string tenhang, double dongia, double soluongton, string nhacungcap, DateTime ngaysanxuat, DateTime ngayhethan)
        {
            //ThucPham(string mahang, string tenhang, double dongia, double soluongton, string nhacungcap, DateTime ngaysanxuat, DateTime ngayhethan)
            new ThucPham(mahang, tenhang, dongia, soluongton, nhacungcap,ngaysanxuat,ngayhethan);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Hàng hoá mẫu
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
            nhapluachon:
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                
                switch (Console.ReadLine())
                {
                    default:
                        Console.WriteLine("Vui lòng nhập đúng");
                        goto nhapluachon;
                    case "11":
                        return;
                    case "0":
                    taohanghoa:
                        Console.WriteLine("Chọn loại hàng hoá bạn muốn tạo[1.Thực phẩm/2.Sành sứ/3.Điện máy]:");
                        string choice = Console.ReadLine();
                        Console.WriteLine("Nhập mã hàng:");
                        string nhapmahang = Console.ReadLine();
                        Console.WriteLine("Nhập tên hàng:");
                        string nhaptenhang = Console.ReadLine();
                        Console.WriteLine("Nhập đơn giá:");
                        
                        Console.WriteLine("Nhập số lượng tồn:");

                        switch (choice)
                        {
                            case "1":
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Vui lòng chọn lại:");
                                goto taohanghoa;
                        }
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
