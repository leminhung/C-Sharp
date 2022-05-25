using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{

    public class NhanVien
    {

        public String maNV { get; set; }
        public String hoTen { get; set; }
        public String gioiTinh { get; set; }
        public DateTime namSinh { get; set; }
        public Int64 soNgayLamViec { get; set; }
        public Int64 tienLuongNgay { get; set; }

        public Int64 luongTong
        {
            get
            {
                if (soNgayLamViec <= 24) return soNgayLamViec * tienLuongNgay;
                return (24 + (soNgayLamViec - 24) * 2) * tienLuongNgay;
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime namSinh, long soNgayLamViec, long tienLuongNgay)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.soNgayLamViec = soNgayLamViec;
            this.tienLuongNgay = tienLuongNgay;
        }

    }
}