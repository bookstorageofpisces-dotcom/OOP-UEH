using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    public class ThucPham : HangHoa
    {
        private string NhaCungCap;
        private DateTime _ngaySanXuat;
        private DateTime Ngaysanxuat
        {
            get { return _ngaySanXuat; }
            set
            {
                DateTime val = value;
                if (val == default(DateTime))
                {
                    val = DateTime.Now;
                }
                if (val > DateTime.Now)
                {
                    throw new ArgumentException("Ngày sản xuất không được lớn hơn ngày hiện tại.");
                }

                this._ngaySanXuat = val;
            }
        }
        private DateTime _ngayHetHan;
        private DateTime Ngayhethan
        {
            get { return _ngayHetHan; }
            set
            {
                DateTime val = value;
                if (val == default(DateTime))
                {
                    val = Ngaysanxuat;
                }
                if (val < Ngaysanxuat)
                {
                    throw new ArgumentException("Ngày hết hạn không được nhỏ hơn ngày sản xuất.");
                }
                this._ngayHetHan = val;
            }
        }
        public ThucPham(string mahang, string tenhang, double dongia, double soluongton, string nhacungcap, DateTime ngaysanxuat, DateTime ngayhethan)
            : base(mahang, tenhang, dongia, soluongton)
        {
            this.NhaCungCap = nhacungcap;
            this.Ngaysanxuat = ngaysanxuat;
            this.Ngayhethan = ngayhethan;
            ListQuanLy.Instance.Add(this);
        }
        public override string mucdobanbuon()
        {
            if (this.Soluongton > 0 && this.Ngayhethan < DateTime.Now)
            {
                return "khó bán";
            }
            else
            {
                return "không đánh giá";
            }
        }
        protected override double VAT()
        {
            return 0.05;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Nhà cung cấp: {this.NhaCungCap}");
            Console.WriteLine($"Ngày sản xuất: {this.Ngaysanxuat.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Ngày hết hạn: {this.Ngayhethan.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mức độ bán buôn: {this.mucdobanbuon()}");
            Console.WriteLine($"VAT: {this.VAT() * 100}%");
        }
    }
}
