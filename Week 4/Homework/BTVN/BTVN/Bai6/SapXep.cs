using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    //Viết phương thức sắp xếp hàng hóa theo tên hàng tăng dần.
    public class SapXepTheoTen : ICompare
    {
            public int Compare(HangHoa hh1, HangHoa hh2)
        {
            if (ReferenceEquals(hh1, hh2)) return 0;
            if (hh1 == null) return 1;  
            if (hh2 == null) return -1; 
            return string.Compare(hh1.GetTenhang(), hh2.GetTenhang());
        }
    }
    //Viết phương thức sắp xếp hàng hóa theo số lượng tồn giảm dần.
    public class SapXepTheoSoLuongTon : ICompare
    {
        public int Compare(HangHoa hh1, HangHoa hh2)
        {
            if (hh1 == null && hh2 == null) return 0;
            if (hh1 == null) return 1;
            if (hh2 == null) return -1;
            if (hh1.GetHangTon() > hh2.GetHangTon()) return -1;
            if (hh1.GetHangTon() < hh2.GetHangTon()) return 1;
            return 0;
        }
    }
}
