using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{
    public class NhanVien
    {
        
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }
        public int soNgayCong { get; set; }
        public float luong { get; set; }
        public double thuong { 
            get
            {
                if (soNgayCong >= 27) return 0.1 * luong;
                return 0;
            }
        }

        public NhanVien()
        {
        }

        public NhanVien(string hoTen, bool gioiTinh, int soNgayCong, float luong)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.soNgayCong = soNgayCong;
            this.luong = luong;
        }

        public override string? ToString()
        {
            return $"{hoTen} - {(gioiTinh ? "Nam" : "Nữ")} - {soNgayCong} - {luong} - {thuong}";
        }
    }
}
