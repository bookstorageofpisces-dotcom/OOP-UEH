using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class ListQuanLy
    {
        public static readonly ListQuanLy Instance = new ListQuanLy();
        private List<DanhSachHangHoa> ListDanhSach;
        private List<HangHoa> ListHangHoa;
        private ListQuanLy()
        {
            ListDanhSach = new List<DanhSachHangHoa>();
            ListHangHoa = new List<HangHoa>();
        }
        public bool Add(object obj)
        {
            if (obj is DanhSachHangHoa danhsach)
            {
                ListDanhSach.Add(danhsach);
                return true;
            }
            if (obj is HangHoa hanghoa)
            {
                ListHangHoa.Add(hanghoa);
                return true;
            }
            return false;
        }
    }
}
