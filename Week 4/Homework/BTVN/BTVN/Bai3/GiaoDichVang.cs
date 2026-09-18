using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai3
{
    internal class GiaoDichVang : GiaoDich
    {
       private string LoaiVang;
       public GiaoDichVang(string magiaodich, DateTime ngaygiaodich, double dongia, double soluong, string loaivang) : base(magiaodich, ngaygiaodich, dongia, soluong)
       {
            this.LoaiVang = loaivang;
       }
       public override double ThanhTien()
        {
            return this.SoLuong * this.DonGia;
        }
        public override string GetInfor()
        {
            return $"Giao dich vang - Ma: {this.MaGiaoDich}, Ngay: {this.NgayGiaoDich}, Don gia: {this.DonGia}, So luong: {this.SoLuong}, Loai vang: {this.LoaiVang}";
        }
    }
}
