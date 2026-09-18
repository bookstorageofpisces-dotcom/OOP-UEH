using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>()
            {
                new GiaoDichTienTe("GD001", new DateTime(2024, 1, 15), 23000, 1000, 1, "USD"),
                new GiaoDichTienTe("GD002", new DateTime(2024, 1, 20), 25000, 500, 1, "EUR"),
                new GiaoDichTienTe("GD003", new DateTime(2024, 1, 25), 22000, 2000, 1, "VND"),
                new GiaoDichVang("GD004", new DateTime(2024, 1, 30), 60000000, 10, "24K"),
                new GiaoDichVang("GD005", new DateTime(2024, 2, 5), 58000000, 5, "18K"),
                new GiaoDichVang("GD006", new DateTime(2024, 2, 10), 62000000, 8, "24K")
            };
            //Tính tổng số lượng cho từng loại.
            Double TongSoLuongTienTe = 0;
            Double TongSoLuongVang = 0;
            foreach (var giaoDich in danhSachGiaoDich)
            {
                if (giaoDich is GiaoDichTienTe)
                {
                    TongSoLuongTienTe += giaoDich.GetSoLuong();
                }
                else if (giaoDich is GiaoDichVang)
                {
                    TongSoLuongVang += giaoDich.GetSoLuong();
                }
            }
            Console.WriteLine($"Tổng số lượng giao dịch tiền tệ: {TongSoLuongTienTe}");
            Console.WriteLine($"Tổng số lượng giao dịch vàng: {TongSoLuongVang}");
            //Tính trung bình thành tiền của giao dịch tiền tệ.
            double TongThanhTienTienTe = 0;
            double SoGiaoDichTienTe = 0;
            foreach (var giaoDich in danhSachGiaoDich)
            {
                if (giaoDich is GiaoDichTienTe)
                {
                    TongThanhTienTienTe += giaoDich.ThanhTien();
                    SoGiaoDichTienTe++;
                }
            }
            if (SoGiaoDichTienTe > 0)
            {
                double TrungBinhThanhTien = TongThanhTienTienTe / SoGiaoDichTienTe;
                Console.WriteLine($"Trung bình thành tiền của giao dịch tiền tệ: {TrungBinhThanhTien}");
            }
            //Xuất ra các giao dịch có đơn giá > 1 tỷ. 
            int SoluongGiaoDichLonHon1Ty = 0;
            Console.WriteLine("Các giao dịch có đơn giá > 1 tỷ:");
            foreach (var giaoDich in danhSachGiaoDich)
            {
                if (giaoDich.GetDonGia() > 1000000000)
                {
                    SoluongGiaoDichLonHon1Ty++;
                    Console.WriteLine(giaoDich.GetInfor());
                }
            }
            if (SoluongGiaoDichLonHon1Ty == 0)
            {
                Console.WriteLine("Không có giao dịch nào có đơn giá > 1 tỷ.");
            }
        }
    }
}
