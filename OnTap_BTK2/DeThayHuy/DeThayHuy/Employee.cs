using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690
{
    internal class Employee
    {
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public Int64 SoNgayCong { get; set; }
        public Int64 Luong { get; set; }
        public Int64 Thuong { 
            get
            {
                if(SoNgayCong >= 27)
                {
                    return (Luong * 10) / 100;
                }
                return 0;
            }
         }

        public Employee()
        {
            HoTen = "";
            GioiTinh = false;
            SoNgayCong = 0;
            Luong = 0;
        }

        public Employee(string hoTen, bool gioiTinh, long soNgayCong, long luong)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            SoNgayCong = soNgayCong;
            Luong = luong;
        }

        public override string ToString()
        {
            return $"{HoTen} - {(GioiTinh ? "Nam" : "Nu")} - {SoNgayCong} - {Luong} - {Thuong}";
        }
    }
}
