using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{

    public class NhanVien
    {

        private String maNV;
        private String hoTen;
        private String gioiTinh;
        private DateTime namSinh;
        private Int64 soNgayLamViec;
        private Int64 tienLuongNgay;

        public String MaNV { get => maNV; set => maNV = value; }
        public String HoTen { get => hoTen; set => hoTen = value; }
        public String GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public Int64 SoNgayLamViec { get => soNgayLamViec; set => soNgayLamViec = value; }
        public Int64 TienLuongNgay { get => tienLuongNgay; set => tienLuongNgay = value; }

        public Int64 luongTong
        {
            get
            {
                if (SoNgayLamViec <= 24) return SoNgayLamViec * TienLuongNgay;
                return (24 + (SoNgayLamViec - 24) * 2) * TienLuongNgay;
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime namSinh, long soNgayLamViec, long tienLuongNgay)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            SoNgayLamViec = soNgayLamViec;
            TienLuongNgay = tienLuongNgay;
        }

    }
}