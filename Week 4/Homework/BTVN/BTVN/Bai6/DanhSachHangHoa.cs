using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai6
{
    internal class DanhSachHangHoa
    {
        private HangHoa[] danhsachhanghoa;
        private int count;
        public DanhSachHangHoa(int size)
        {
            danhsachhanghoa = new HangHoa[size];
            count = 0;
        }
        public bool Add(HangHoa hanghoa)
        {
            if (count>danhsachhanghoa.Length)
            {
                Console.WriteLine("Danh sách hàng hóa đã đầy, không thể thêm hàng hóa mới.");
                return false;
            }
            for (int i = 0; i < count; i++)
            {
                if (danhsachhanghoa[i].Equals(hanghoa))
                {
                    Console.WriteLine("Hàng hóa đã tồn tại trong danh sách, không thể thêm hàng hóa mới.");
                    return false;
                }
            }
            danhsachhanghoa[count] = hanghoa;
            count++;
            Console.WriteLine("Thêm hàng hóa thành công.");
            return true;
        }
    }
}
