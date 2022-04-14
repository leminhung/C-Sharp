using System;
using System.Collections.Generic;
using System.Text;

namespace DeCa1
{
    class SsTongDiem : IComparer<ThiSinhUT>
    {
        public int Compare(ThiSinhUT x, ThiSinhUT y)
        {
            return x.TongDiem().CompareTo(y.TongDiem());
        }
    }

    class Program
    {
        static private List<ThiSinhUT> thisinhs = new List<ThiSinhUT>();



        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choose;
            do
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("===================QUẢN LÝ SINH VIÊN========================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Thêm Sinh Viên                                         =");
                Console.WriteLine("=2. Hiển Thị Danh Sách Sinh Viên                           =");
                Console.WriteLine("=3. Hiển Thị Danh Sách Sinh Viên SS theo Tong diem thi     =");
                Console.WriteLine("=4. In ra DS SV Thi Đỗ                                     =");
                Console.WriteLine("=5. In ra DS SV có cùng khu vực                            =");
                Console.WriteLine("=6. Tìm kiếm Sv và hiển thị theo SBD                            =");
                Console.WriteLine("=7. Xóa Sv theo SBD                            =");
                Console.WriteLine("=8. Kết Thúc Chương Trình                                  =");
                Console.WriteLine("============================================================");
                Console.Write("Mời bạn nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhap();
                        break;
                    case 2:
                        HienThiDS();
                        break;
                    case 3:
                        sapXepTongDiemThi();
                        break;
                    case 4:
                        hienThiTSTheoDiemSan();
                        break;
                    case 5:
                        HienThiTSTheoKhuVuc();
                        break;
                    case 6:
                        HienThiTSTheoSBD();
                        break;
                    case 7:
                        XoaTSTheoSBD();
                        break;
                    case 8:
                        Console.WriteLine("=======Thoat chuong trinh=======".ToUpper());
                        return;
                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :((");
                        break;
                }

            } while (choose != 8);
        }

        static bool checkMSV(string maSV)
        {
            ThiSinhUT sv = thisinhs.Find(s => s.SBD == maSV);
            if (sv != null) return false;
            return true;
        }
        static void nhap()
        {
            ThiSinhUT ts = new ThiSinhUT();
            bool check;
            do
            {
                check = true;
                Console.Write("Nhap MSV: ");
                ts.SBD = Console.ReadLine();

                check = checkMSV(ts.SBD);
                if (!check)
                {
                    Console.WriteLine("Ma SV da ton tai, moi nhap lai :((");
                }
            } while (!check);

            ts.NhapThongTin();
            thisinhs.Add(ts);
        }

        static void InTieuDe()
        {
            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10}", "SBD", "HoTen", "Diem Toan", "Diem Ly", "Diem Hoa", "Khu Vuc", "Diem UT", "Tong Diem");
        }

        static void HienThiDS()
        {
            if (thisinhs.Count == 0)
            {
                Console.WriteLine("Danh sach trong".ToUpper());
                return;
            }

            Console.WriteLine("========hien thi ds thi sinh==========".ToUpper());

            InTieuDe();
            foreach (ThiSinhUT sv in thisinhs)
            {
                sv.HienThi();
            }
        }

        static void sapXepTongDiemThi()
        {
            SsTongDiem td = new SsTongDiem();
            thisinhs.Sort(td);
            HienThiDS();
        }

        static void hienThiTSTheoDiemSan()
        {
            Console.Write("Nhap diem san: ");
            float dsan = float.Parse(Console.ReadLine());

            InTieuDe();
            foreach(ThiSinhUT ts in thisinhs)
            {
                if(ts.TongDiem() >= dsan)
                {
                    ts.HienThi();
                }
            }
        }

        static void HienThiTSTheoKhuVuc()
        {
            Console.Write("Nhap khu vuc: ");
            int khuvuc = int.Parse(Console.ReadLine());

            InTieuDe();
            foreach (ThiSinhUT ts in thisinhs)
            {
                if (ts.KhuVuc == khuvuc)
                {
                    ts.HienThi();
                }
            }
        }

        static void HienThiTSTheoSBD()
        {
            Console.Write("Nhap SBD: ");
            string sbd = Console.ReadLine();

            InTieuDe();
            foreach (ThiSinhUT ts in thisinhs)
            {
                if (ts.SBD == sbd)
                {
                    ts.HienThi();
                    break;
                }
            }
        }

        static void XoaTSTheoSBD()
        {
            Console.Write("Nhap SBD: ");
            string sbd = Console.ReadLine();

            InTieuDe();
            foreach (ThiSinhUT ts in thisinhs)
            {
                if (ts.SBD == sbd)
                {
                    thisinhs.Remove(ts);
                    Console.WriteLine("======xoa thanh cong=====".ToUpper());
                    break;
                }
            }
        }
    }
}
