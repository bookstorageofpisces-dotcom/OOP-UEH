using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai2
{
    internal abstract class Sach
    {
        protected string MaSach{ get;}
        protected int NgayNhap{ get;}
        protected int DonGia{ get;}
        protected int SoLuong{get;}
        protected string NXB{get;}
        public Sach(string masach, int ngaynhap, int dongia, int soluong, string nxb)
        {
            this.MaSach = masach;
            this.NgayNhap = ngaynhap;
            this.DonGia = dongia;
            this.SoLuong = soluong;
            this.NXB = nxb;
        }
        public abstract double TinhThanhTien();
        public string GetNXB()
        {
            return this.NXB;
        }
        public string GetInfor()
        {
            return "Mã sách: " + this.MaSach + ", Ngày nhập: " + this.NgayNhap + ", Đơn giá: " + this.DonGia + ", Số lượng: " + this.SoLuong + ", Nhà xuất bản: " + this.NXB;
        }
    }
}
