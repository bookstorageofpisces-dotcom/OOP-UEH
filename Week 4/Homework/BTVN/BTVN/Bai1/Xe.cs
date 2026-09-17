using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN.Bai1
{
    public abstract class Xe
    {
        protected string MSC;
        protected string HoTenTX;
        protected string SoXe;
        protected int DoanhThu;
        public Xe(string msc, string hotentx, string soxe, int doanhthu)
        {
            this.MSC = msc;
            this.HoTenTX = hotentx;
            this.SoXe = soxe;
            this.DoanhThu = doanhthu;
        }
        public int XemDoanhThu()
        {
            return this.DoanhThu;
        }
    }
}