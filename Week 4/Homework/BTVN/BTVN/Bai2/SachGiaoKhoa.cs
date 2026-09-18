using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai2
{
    internal class SachGiaoKhoa : Sach
    {
        private string TinhTrang;
        private string tinhtrang
        {   get {return this.TinhTrang; }
            set
            {
                if (value!= null && (value== "moi" || value == "cu"))
                {
                    this.TinhTrang = value;
                }
                else
                {
                    throw new Exception("Tinh trang phai la 'moi' hoac 'cu'");
                }
            }
        }
        public SachGiaoKhoa(string masach, int ngaynhap, int dongia, int soluong, string nxb, string tinhtrang) : base(masach, ngaynhap, dongia, soluong, nxb)
        {
            this.tinhtrang = tinhtrang;
        }
        public override double TinhThanhTien()
        {
            if (TinhTrang == "moi")
            {
                return SoLuong * DonGia;
            }
            else
            {
                return SoLuong * DonGia * 0.5;
            }
        }

    }
}
