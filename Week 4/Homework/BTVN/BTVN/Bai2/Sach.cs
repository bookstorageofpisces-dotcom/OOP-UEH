using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai2
{
    internal abstract class Sach
    {
        public string MaSach{ get;}
        public int NgayNhap{ get;}
        public int DonGia{ get;}
        public int SoLuong{get;}
        public string NXB{get;}
        public Sach(string masach, int ngaynhap, int dongia, int soluong, string nxb)
        {
            this.MaSach = masach;
            this.NgayNhap = ngaynhap;
            this.DonGia = dongia;
            this.SoLuong = soluong;
            this.NXB = nxb;
        }
        public abstract double TinhThanhTien();
    }
}
