using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai4
{
    internal class SachGiaoKhoa : Sach
    {
        private bool tinhTrang;
        public SachGiaoKhoa() : base()
        {
            this.tinhTrang = true;
        }
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, Boolean tinhTrang) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }
        public bool getTinhTrang()
        {
            return this.tinhTrang;
        }
        public void setTinhTrang(bool tinhTrang)
        {
            this.tinhTrang = tinhTrang;
        }
        public override double getThanhTien()
        {
           if (this.tinhTrang)
            {
                return this.donGia * this.soLuong;
            }
            else
            {
                return this.donGia * this.soLuong * 0.5;
            }
        }
        public override string ToString()
        {
            return base.ToString() + ", Tinh Trang: " + (this.tinhTrang ? "Moi" : "Cu") + ", Thanh Tien: " + this.getThanhTien();
        }
    }
}
