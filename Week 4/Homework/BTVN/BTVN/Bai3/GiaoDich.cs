using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai3
{
    internal abstract class GiaoDich
    {
        protected string MaGiaoDich;
        protected DateTime NgayGiaoDich;
        protected double DonGia;
        protected double SoLuong;
        public GiaoDich(string magiaodich, DateTime ngaygiaodich, double dongia, double soluong)
        {
            this.MaGiaoDich = magiaodich;
            this.NgayGiaoDich = ngaygiaodich;
            this.DonGia = dongia;
            this.SoLuong = soluong;
        }
        public abstract double ThanhTien();
        public abstract string GetInfor();
        public double GetDonGia()
        {
            return this.DonGia;
        }
        public double GetSoLuong()
        {
            return this.SoLuong;
        }

    }
}
