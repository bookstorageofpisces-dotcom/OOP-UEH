using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class DienMay : HangHoa
    {
        private double _tgbh;
        private double Tgbh
        {
            get { return _tgbh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Thời gian bảo hành không được âm.");
                }
                this._tgbh = value;
            }
        }
        private double _congsuat;
        private double Congsuat
        {
            get { return _congsuat; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Công suất không được âm.");
                }
                this._congsuat = value;
            }
        }
        public DienMay(string mahang, string tenhang, double dongia, double soluongton, double tgbh, double congsuat)
            : base(mahang, tenhang, dongia, soluongton)
        {
            this.Tgbh = tgbh;
            this.Congsuat = congsuat;
        }
        protected override string mucdobanbuon()
        {
            if (this.Soluongton < 3)
            {
                return "bán được";
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
