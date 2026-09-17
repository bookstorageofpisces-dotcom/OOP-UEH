using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN.Bai1
{
    public class NoiThanh : Xe
    {
        private int SoTuyen;
        private int SoKMDiDuoc;

        public NoiThanh(string msc, string hotentx, string soxe, int sotuyen, int sokmdiduoc, int doanhthu):base(msc, hotentx, soxe, doanhthu)
        {
            this.SoTuyen = sotuyen;
            this.SoKMDiDuoc = sokmdiduoc;
        }
    }
}