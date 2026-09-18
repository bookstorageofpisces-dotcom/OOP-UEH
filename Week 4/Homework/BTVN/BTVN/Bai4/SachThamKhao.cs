using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai4
{
    internal class SachThamKhao : Sach
    {
        private double thue;
        public SachThamKhao():base()
        {
            thue = 0;
        }
        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.thue = thue;
        }
        public double getThue()
        {
            return this.thue;
        }
        public void setThue(double thue)
        {
            this.thue = thue;
        }
        public override double getThanhTien()
        {
            return this.donGia * this.soLuong + this.thue;
        }
        public override string ToString()
        {
            return base.ToString() + ", Thue: " + this.thue + ", Thanh Tien: " + this.getThanhTien();
        }
    }
}
