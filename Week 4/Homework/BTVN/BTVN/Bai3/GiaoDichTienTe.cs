using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai3
{
    internal class GiaoDichTienTe : GiaoDich
    {
        private double TiGia;
        private string LoaiTienTe;  
        private string loaitiente
        {
            get { return this.LoaiTienTe; }
            set
            {
                if (value != null && (value == "VND" || value == "USD" || value=="EUR"))
                {
                    this.LoaiTienTe = value;
                }
                else
                {
                    throw new ArgumentException("Loai tien te phai la 'VND', 'USD' hoac 'EUR'");
                }
            }
        }
        public GiaoDichTienTe(string magiaodich, DateTime ngaygiaodich, double dongia, double soluong, double tiGia, string loaitiente) : base(magiaodich, ngaygiaodich, dongia, soluong)
        {
            this.TiGia = tiGia;
            this.loaitiente = loaitiente;
        }
        public override double ThanhTien()
        {
            if(this.LoaiTienTe == "VND")
            {
                return this.SoLuong * this.DonGia;
            }
            else
            {
                return this.SoLuong * this.DonGia * this.TiGia;
            }
        }
        public override string GetInfor()
        {
            return $"Giao dich tien te - Ma: {this.MaGiaoDich}, Ngay: {this.NgayGiaoDich}, Don gia: {this.DonGia}, So luong: {this.SoLuong}, Ti gia: {this.TiGia}, Loai tien te: {this.LoaiTienTe}";
        }
    }

}
