using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal abstract class HangHoa
    {
        protected string _maHang;
        protected string Mahang
        {
            get { return _maHang; }
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã hàng không được để trống.");
                }
                this._maHang = value;
            }
        }
        protected string _tenHang;
        protected string Tenhang
        {
            get { return _tenHang; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this._tenHang = "xxx";
                }
                this._tenHang = value;
            }
        }
        protected double _donGia;
        protected double Dongia
        {
            get { return _donGia; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Đơn giá không được âm.");
                }
                this._donGia = value;
            }
        }
        protected double _soLuongTon;
        protected double Soluongton
        {
            get { return _soLuongTon; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Số lượng tồn không được âm.");
                }
                this._soLuongTon = value;
            }
        }
        protected HangHoa(string mahang, string tenhang, double dongia, double soluongton)
        {
            this.Mahang = mahang;
            this.Tenhang = tenhang;
            this.Dongia = dongia;
            this.Soluongton = soluongton;
        }
        protected abstract string mucdobanbuon();
        protected abstract double VAT();
        public override bool Equals(object obj)
        {
            if (obj is HangHoa other)
            {
                return this.Mahang == other.Mahang;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Mahang.GetHashCode();
        }
    }
}
