using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai4
{
    internal class Sach
    {
        protected string maSach;
        protected DateTime ngayNhap;
        protected double donGia;
        protected int soLuong;
        protected string nhaXuatBan;
        public Sach()
        {
            this.maSach = "";
            this.ngayNhap = DateTime.Now;
            this.donGia = 0;
            this.soLuong = 0;
            this.nhaXuatBan = "";
        }
        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }
        public string getMaSach()
        {
            return this.maSach;
        }
        public void setMaSach(string maSach)
        {
            this.maSach = maSach;
        }
        public DateTime getNgayNhap()
        {
            return this.ngayNhap;
        }
        public void setNgayNhap(DateTime ngayNhap)
        {
            this.ngayNhap = ngayNhap;
        }
        public double getDonGia()
        {
            return this.donGia;
        }
        public void setDonGia(double donGia)
        {
            this.donGia = donGia;
        }
        public int getSoLuong()
        {
            return this.soLuong;
        }
        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }
        public string getNhaXuatBan()
        {
            return this.nhaXuatBan;
        }
        public void setNhaXuatBan(string nhaXuatBan)
        {
            this.nhaXuatBan = nhaXuatBan;
        }
        public virtual double getThanhTien()
        {
            return this.donGia * this.soLuong;
        }
        public virtual string toString()
        {
            return "Ma sach: " + this.maSach + ", Ngay nhap: " + this.ngayNhap.ToString("dd/MM/yyyy") + ", Don gia: " + this.donGia + ", So luong: " + this.soLuong + ", Nha xuat ban: " + this.nhaXuatBan;
        }
    }
}
