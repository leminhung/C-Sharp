using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{
    public class NhanVien
    {
        
        public string maNV { get; set; }
        public string hoten { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public float luongNgay { get; set; }
        public int soNgayLamViec { get; set; }
        public double tienLuong
        {
            get
            {
                if (soNgayLamViec <= 24) return soNgayLamViec * luongNgay;
                return (24 + (soNgayLamViec - 24) * 2) * luongNgay;
            }
        }

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoten, string gioiTinh, DateTime ngaySinh, float luongNgay, int soNgayLamViec)
        {
            this.maNV = maNV;
            this.hoten = hoten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.luongNgay = luongNgay;
            this.soNgayLamViec = soNgayLamViec;
        }
    }
}
