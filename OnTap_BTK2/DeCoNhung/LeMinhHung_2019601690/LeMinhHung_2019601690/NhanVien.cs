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
        public string loaiNv { get; set; }
        public DateTime ngaysinh { get; set; }
        public float soTienBan { get; set; }

        public double hoaHong { 
            get
            {
                if(soTienBan < 1000)
                {
                    return 0;
                }
                else if(soTienBan >= 1000 && soTienBan <= 5000)
                {
                    return 0.1 * soTienBan;
                }
                return 0.2 * soTienBan;
            } 
        }

        public NhanVien()
        {
        }

        public NhanVien(string hoTen, string loaiNv, DateTime ngaysinh, float soTienBan)
        {
            this.hoTen = hoTen;
            this.loaiNv = loaiNv;
            this.ngaysinh = ngaysinh;
            this.soTienBan = soTienBan;
        }

        public override string ToString()
        {
            return $"{hoTen} - {loaiNv} - {ngaysinh} - Tiền bán hàng: {soTienBan} - Hoa hồng: {hoaHong}";
        }
    }
}
