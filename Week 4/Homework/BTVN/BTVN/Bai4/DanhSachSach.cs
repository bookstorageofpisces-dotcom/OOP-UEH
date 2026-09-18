using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai4
{
    internal class DanhSachSach
    {
        private Sach[] danhSach;
        private int count;
        public DanhSachSach(int size)
        {
            this.danhSach = new Sach[size];
            this.count = 0;
        }
        public bool them(Sach sach)
        {
            if (count < danhSach.Length)
            {
                danhSach[count] = sach;
                count++;
                return true;
            }
            return false;
        }
        public string toString()
        {
            string kq = "";
            foreach (Sach sach in danhSach)
            {
                if (sach != null)
                {
                    kq += sach.ToString() + "\n";
                }
            }
            return kq;
        }
        public double tinhTongThanhTienSGK()
        {
            double tong = 0;
            foreach (Sach sach in danhSach)
            {
                if (sach is SachGiaoKhoa)
                {
                    tong += sach.getThanhTien();
                }
            }
            return tong;
        }
        public double tinhTongThanhTienSTK()
        {
            double tong = 0;
            foreach (Sach sach in danhSach)
            {
                if (sach is SachThamKhao)
                {
                    tong += sach.getThanhTien();
                }
            }
            return tong;
        }
        public List<Sach> timSGKTheoNXB(string nxb)
        {
            List<Sach> kq = new List<Sach>();
            foreach (Sach sach in danhSach)
            {
                if (sach is SachGiaoKhoa && sach.getNhaXuatBan() == nxb)
                {
                    kq.Add(sach);
                }
            }
            return kq;
        }
        public double timThanhTienCaoNhat()
        {
            double max = 0;
            for (int i=0; i<count; i++)
            {
                if (danhSach[i].getThanhTien() > max)
                {
                    max = danhSach[i].getThanhTien();
                }
            }
            return max;
        }
    }
}
