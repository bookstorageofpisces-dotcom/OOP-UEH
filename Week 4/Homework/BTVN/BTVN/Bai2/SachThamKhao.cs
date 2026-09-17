using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai2
{
    internal class SachThamKhao : Sach
    {
        private int Thue;
        public SachThamKhao(string masach, int ngaynhap, int dongia, int soluong, string nxb, int thue) : base(masach, ngaynhap, dongia, soluong, nxb)
        {
            this.Thue = thue;
        }
        public override double TinhThanhTien()
        {
            return DonGia * SoLuong + Thue;
        }
    }
}
