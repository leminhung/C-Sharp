using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhHung_2019601690_proj51
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyThiSinh q = new QuanLyThiSinh();

            int luaChon;

            do
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("===================QUẢN LÝ THÍ SINH==================");
                Console.WriteLine("=====================================================");
                Console.WriteLine("=1. Nhập Thông Tin Sinh Viên                        =");
                Console.WriteLine("=2. Hiển Thị Danh Sách Thí Sinh                     =");
                Console.WriteLine("=3. Hiển Thị Các Sinh Viên Theo Tổng Điểm           =");
                Console.WriteLine("=4. Hiển Thị Sinh Viên Theo Địa Chỉ                 =");
                Console.WriteLine("=5. Tìm Kiếm Theo Số Báo Danh                       =");
                Console.WriteLine("=6. Thoát Chương Trình                              =");
                Console.WriteLine("=====================================================");
                Console.Write("Nhập lựa chọn: ");
                luaChon = int.Parse(Console.ReadLine());
                Console.WriteLine("=====================================================");
                switch (luaChon)
                {
                    case 1:
                        q.NhapThongTinThiSinh();
                        break;
                    case 2:
                        q.HienThiDanhSach();
                        break;
                    case 3:
                        q.HienThiDanhSachTheoTongDiem();
                        break; 
                    case 4:
                        q.HienThiDanhSachTheoDiaChi();
                        break; 
                    case 5:
                        q.HienThiThongTinTSTheoSBD();
                        break;
                    case 6:
                        Console.WriteLine("=======Thoat chuong trinh=======".ToUpper());
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :((");
                        break;
                }
            } while (luaChon != 6);
            
        }
    }
}
