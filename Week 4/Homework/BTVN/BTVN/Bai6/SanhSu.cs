using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class SanhSu : HangHoa
    {
        private string _nhasanxuat;
        private DateTime _ngaynhapkho;
        private DateTime Ngaynhapkho
        {
            get { return _ngaynhapkho; }
            set
            {
                DateTime val = value;
                if (val == default(DateTime))
                {
                    val = DateTime.Now;
                }
                if (val > DateTime.Now)
                {
                    throw new ArgumentException("Ngày nhập kho không được lớn hơn ngày hiện tại.");
                }
                this._ngaynhapkho = val;
            }
        }
        public SanhSu(string mahang, string tenhang, double dongia, double soluongton, string nhasanxuat, DateTime ngaynhapkho)
            : base(mahang, tenhang, dongia, soluongton)
        {
            this._nhasanxuat = nhasanxuat;
            this.Ngaynhapkho = ngaynhapkho;
        }
        protected override string mucdobanbuon()
        {
            if (this.Soluongton>50 && this.Ngaynhapkho.AddDays(10)<DateTime.Now)
            {
                return "bán chậm";
            }
            else
            {
                return "không đánh giá";
            }
        }
        protected override double VAT()
        {
            return 0.1;
        }
    }
}
