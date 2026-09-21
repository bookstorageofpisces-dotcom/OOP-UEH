using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    public class DanhSachHangHoa
    {
        private HangHoa[] danhsachhanghoa;
        private string tenDanhSach;
        private int count;
        public DanhSachHangHoa(string TenDanhSach, int size)
        {
            this.tenDanhSach = TenDanhSach;
            danhsachhanghoa = new HangHoa[size];
            this.count = 0;
            ListQuanLy.Instance.Add(this);
        }
        public bool Add(HangHoa hanghoa)
        {
            if (count > danhsachhanghoa.Length)
            {
                Console.WriteLine("Danh sách hàng hóa đã đầy, không thể thêm hàng hóa mới.");
                return false;
            }
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i].Equals(hanghoa))
                {
                    Console.WriteLine("Hàng hóa đã tồn tại trong danh sách, không thể thêm hàng hóa mới.");
                    return false;
                }
            }
            danhsachhanghoa[count] = hanghoa;
            count++;
            Console.WriteLine("Thêm hàng hóa thành công.");
            return true;
        }
        public void DisplayAllProductInfo()
        {
            Console.WriteLine("Danh sách hàng hóa:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Hàng hóa thứ {i + 1}:");
                danhsachhanghoa[i].DisplayInfo();
                Console.WriteLine();
            }
        }
        public void DisplayInforByType()
        {
        nhaplai:
            Console.WriteLine("Nhập loại hàng hoá theo yêu cầu:");
            Console.WriteLine("[1] Thực phẩm");
            Console.WriteLine("[2] Điện máy");
            Console.WriteLine("[3] Sành sứ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    goto nhaplai;
                case 1:
                    Console.WriteLine("Danh sách hàng hóa thực phẩm:");
                    for (int i = 0; i < count; i++)
                    {
                        if (danhsachhanghoa[i] is ThucPham)
                        {
                            danhsachhanghoa[i].DisplayInfo();
                            Console.WriteLine();
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Danh sách hàng hóa điện máy:");
                    for (int i = 0; i < count; i++)
                    {
                        if (danhsachhanghoa[i] is DienMay)
                        {
                            danhsachhanghoa[i].DisplayInfo();
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Danh sách hàng hóa sành sứ:");
                    for (int i = 0; i < count; i++)
                    {
                        if (danhsachhanghoa[i] is SanhSu)
                        {
                            danhsachhanghoa[i].DisplayInfo();
                            Console.WriteLine();
                        }
                    }
                    break;
            }
        }
        public void TimKiemTheoMahang()
        {
            Console.WriteLine("Nhập mã hàng cần tìm kiếm:");
            string mahang = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i].GetMahang() == mahang)
                {
                    Console.WriteLine("Thông tin hàng hóa tìm thấy:");
                    danhsachhanghoa[i].DisplayInfo();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy hàng hóa với mã hàng đã nhập.");
        }
        private void SapXep(ICompare bososanh)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (bososanh.Compare(danhsachhanghoa[i], danhsachhanghoa[j]) > 0)
                    {
                        HangHoa temp = danhsachhanghoa[i];
                        danhsachhanghoa[i] = danhsachhanghoa[j];
                        danhsachhanghoa[j] = temp;
                    }
                }
            }
        }
        public void SapXepTheoTen()
        {
            SapXep(new SapXepTheoTen());
        }
        public void SapXepTheoSoLuongTon()
        {
            SapXep(new SapXepTheoSoLuongTon());
        }
        //Viết phương thức lấy thông tin các hàng thực phẩm khó bán.
        public void LayThongTinHangThucPhamKhoBan()
        {
            Console.WriteLine("Danh sách hàng thực phẩm khó bán:");
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i] is ThucPham thucpham && thucpham.mucdobanbuon() == "khó bán")
                {
                    thucpham.DisplayInfo();
                    Console.WriteLine();
                }
            }
        }
        //Viết các phương thức xóa hàng hóa khi biết mã hàng.
        public void XoaHangHoaTheoMaHang()
        {
            Console.WriteLine("Nhập mã hàng cần xóa:");
            string mahang = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i].GetMahang() == mahang)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        danhsachhanghoa[j] = danhsachhanghoa[j + 1];
                    }
                    danhsachhanghoa[count - 1] = null;
                    count--;
                    Console.WriteLine("Xóa hàng hóa thành công.");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy hàng hóa với mã hàng đã nhập.");
        }
        //Viết các phương thức sửa thông tin đơn giá của hàng hóa khi biết mã hàng.
        public void SuaDonGiaTheoMaHang()
        {
            Console.WriteLine("Nhập mã hàng cần sửa đơn giá:");
            string mahang = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i].GetMahang() == mahang)
                {
                    Console.WriteLine("Nhập đơn giá mới:");
                    double dongia = double.Parse(Console.ReadLine());
                    danhsachhanghoa[i].SetDongia(dongia);
                    Console.WriteLine("Sửa đơn giá thành công.");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy hàng hóa với mã hàng đã nhập.");
        }
    }
}
