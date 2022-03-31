using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690_proj51
{
    class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemUuTien { get; set; }
        public double TongDiem { get; set; }

        public ThiSinh()
        {
            SoBaoDanh = "";
            HoTen = "";
            DiaChi = "";
            DiemToan = 0;
            DiemLy = 0;
            DiemHoa = 0;
            DiemUuTien = 0;
            TongDiem = 0;
        }

        public ThiSinh(string SoBaoDanh)
        {
            this.SoBaoDanh = SoBaoDanh;
            HoTen = "";
            DiaChi = "";
            DiemToan = 0;
            DiemLy = 0;
            DiemHoa = 0;
            DiemUuTien = 0;
            TongDiem = 0;
        }


        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, double diemToan, double diemLy, double diemHoa, double diemUuTien)
        {
            SoBaoDanh = soBaoDanh;
            HoTen = hoTen;
            DiaChi = diaChi;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DiemUuTien = diemUuTien;
            TongDiem = diemToan + diemLy + diemHoa + diemUuTien;
        }


        public void nhap()
        {
            Console.Write("Nhập Số Báo Danh: ");
            SoBaoDanh = Console.ReadLine().Trim();
            Console.Write("Nhập Họ Tên: ");
            HoTen = Console.ReadLine().Trim();
            Console.Write("Nhập Địa Chỉ: ");
            DiaChi = Console.ReadLine().Trim();
            Console.Write("Nhập Điểm Toán: ");
            DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý: ");
            DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Hóa: ");
            DiemHoa = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Ưu Tiên: ");
            DiemUuTien = double.Parse(Console.ReadLine());

            TongDiem = DiemHoa + DiemToan + DiemLy + DiemUuTien;
        }

        public override string ToString()
        {
            return
                $"\nSBD: {SoBaoDanh}" +
                $"\nHọ Tên: {HoTen}" +
                $"\nĐịa Chỉ: {DiaChi}" +
                $"\nĐiểm Toán: {DiemToan}" +
                $"\nĐiểm Lý: {DiemLy}" +
                $"\nĐiểm Hóa: {DiemHoa}" +
                $"\nĐiểm Ưu Tiên: {DiemUuTien}" +
                $"\nTổng Điểm: {TongDiem}";
        }

        public void xuat()
        {
            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", SoBaoDanh, HoTen, DiaChi, DiemToan, DiemLy, DiemHoa, DiemUuTien, TongDiem);
        }
    }
}
