using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{
    public class NhanVien
    {
        private string hoTen;
        private string loaiNv;
        private DateTime ngaysinh;
        private float soTienBan;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string LoaiNv { get => loaiNv; set => loaiNv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public float SoTienBan { get => soTienBan; set => soTienBan = value; }

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
            HoTen = hoTen;
            LoaiNv = loaiNv;
            Ngaysinh = ngaysinh;
            SoTienBan = soTienBan;
        }

        public override string ToString()
        {
            return $"{HoTen} - {LoaiNv} - {Ngaysinh} - Tiền bán hàng: {SoTienBan} - Hoa hồng: {hoaHong}";
        }
    }
}
