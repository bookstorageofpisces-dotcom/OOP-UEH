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
                foreach(DanhSachHangHoa var in ListDanhSach)
                {
                    if (danhsach.Equals(var))
                    {
                        return false;
                    }
                    else
                    {
                        ListDanhSach.Add(danhsach);
                        return true;
                    }
                }
            }
            if (obj is HangHoa hanghoa)
            {
                foreach(HangHoa var in ListHangHoa)
                {
                    if(hanghoa.Equals(var))
                    {
                        return false;
                    }
                    else
                    {
                        ListHangHoa.Add(hanghoa);
                        return true;
                    }    
                }
            }
            return false;
        }
    }
}
