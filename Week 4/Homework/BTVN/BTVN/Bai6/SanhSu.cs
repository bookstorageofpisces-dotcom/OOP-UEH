using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    public class SanhSu : HangHoa
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
            ListQuanLy.Instance.Add(this);
        }
        public override string mucdobanbuon()
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
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Nhà sản xuất: {this._nhasanxuat}");
            Console.WriteLine($"Ngày nhập kho: {this.Ngaynhapkho.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mức độ bán buôn: {this.mucdobanbuon()}");
            Console.WriteLine($"VAT: {this.VAT()*100}%");
        }
    }
}
