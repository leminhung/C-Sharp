using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690_proj51
{
    class QuanLyThiSinh
    {
        private List<ThiSinh> listTS = new List<ThiSinh>();

        /*
         * Nhập thông tin một sinh viên
         */
        public void NhapThongTinThiSinh()
        {
            ThiSinh ts = new ThiSinh();
            ts.nhap();
            listTS.Add(ts);
        }

        public void HienThiDanhSach()
        {
            if(listTS.Count == 0)
            {
                Console.WriteLine("====Danh sach khong duoc de rong====".ToUpper());
                return;
            }

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", "SBD", "Ho Ten", "Dia Chi", "Toan", "Ly", "Hoa", "UuTien", "TongDiem");

            foreach (ThiSinh ts in listTS)
            {
                ts.xuat();
            }
        }

        public void HienThiDanhSachTheoTongDiem()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("====Danh sach khong duoc de rong====".ToUpper());
                return;
            }

            Console.Write("Nhap vao tong diem T = ");
            int T = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", "SBD", "Ho Ten", "Dia Chi", "Toan", "Ly", "Hoa", "UuTien", "TongDiem");
            foreach (ThiSinh ts in listTS)
            {
                if (ts.TongDiem >= T)
                {
                    ts.xuat();
                }
            }
        }

        public void HienThiDanhSachTheoDiaChi()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("====Danh sach khong duoc de rong====".ToUpper());
                return;
            }

            Console.Write("Nhap vao dia chi D:  ");
            string D = Console.ReadLine();

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", "SBD", "Ho Ten", "Dia Chi", "Toan", "Ly", "Hoa", "UuTien", "TongDiem");
            foreach (ThiSinh ts in listTS)
            {
                if (ts.DiaChi.ToUpper().Contains(D.ToUpper()))
                {
                    ts.xuat();
                }
            }
        }

        public void HienThiThongTinTSTheoSBD()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("====Danh sach khong duoc de rong====".ToUpper());
                return;
            }

            Console.Write("Nhap vao SBD:  ");
            string SBD = Console.ReadLine();

            
            var list = listTS.Find(ts => ts.SoBaoDanh.ToLower() == SBD.ToLower());

            if(list == null)
            {
                Console.WriteLine($"=====Khong co TS nao co SBD: {SBD}======".ToUpper());
                return;
            }

            Console.WriteLine("======Hien thi thong tin TS=======".ToUpper());
            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", "SBD", "Ho Ten", "Dia Chi", "Toan", "Ly", "Hoa", "UuTien", "TongDiem");
            list.xuat();
        }
    }
}
