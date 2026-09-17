using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN.Bai1
{
    public class NgoaiThanh : Xe
    {
        private string NoiDen;
        private int SoNgayDiDuoc;

        public NgoaiThanh(string msc,string hotentx, string soxe, string noiden, int songaydiduoc, int doanhthu): base(msc, hotentx, soxe, doanhthu)
        {
            this.NoiDen = noiden;
            this.SoNgayDiDuoc = songaydiduoc;
        }
    }
}