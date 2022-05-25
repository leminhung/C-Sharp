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
                if (soNgayLamViec <= 24)
                {
                    return soNgayLamViec * tienLuongNgay;
                }
                return (24 + (soNgayLamViec - 24) * 2) * tienLuongNgay;
            }
        }

        public NhanVien()
        {
            this.maNV = "";
            this.hoTen = "";
            this.gioiTinh = "";
            this.namSinh = DateTime.ParseExact("02/01/2001", "dd/mm/yy", null);
            this.tienLuongNgay = 0;
            this.soNgayLamViec = 0;
        }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime namSinh, long tienLuong, long soNgay)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.tienLuongNgay = tienLuong;
            this.soNgayLamViec = soNgay;
        }
        

    }
}
