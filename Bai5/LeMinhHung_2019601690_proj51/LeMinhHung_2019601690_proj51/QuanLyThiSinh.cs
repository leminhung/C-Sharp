using System;
using System.Collections.Generic;

namespace LeMinhHung_2019601690_proj51
{
    class QuanLyThiSinh
    {
        private List<ThiSinh> listTS = new List<ThiSinh>();
        int generateNumber = 0;

        /*
         * Nhập thông tin một sinh viên
         */
        public void NhapThongTinThiSinh()
        {
            ThiSinh ts;
            ts = new ThiSinh();
            ts.SoBaoDanh = ++generateNumber;

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
            double T = double.Parse(Console.ReadLine());

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
            int SBD = int.Parse(Console.ReadLine());

            
            var list = listTS.Find(ts => ts.SoBaoDanh == SBD);

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
