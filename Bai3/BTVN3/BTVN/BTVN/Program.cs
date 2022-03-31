using System;
using System.IO;
using System.Collections.Generic;

namespace BTVN
{
    public struct Sv
    {
        public int id;
        public string ten;
        public string gioiTinh;
        public int tuoi;
        public float toan;
        public float ly;
        public float hoa;
        public float diemTB;
        public string hocLuc;
    }

    public class SsDiemTB : IComparer<Sv>
    {
        public int Compare(Sv x, Sv y) 
        {
            return x.diemTB.CompareTo(y.diemTB);
        }
    }
    public class SsTenSV : IComparer<Sv>
    {
        public int Compare(Sv x, Sv y)
        {
            return x.ten.CompareTo(y.ten);
        }
    }
    

    class Program
    {
        private static int n;
        private static Sv[] a = new Sv[10];
        private static int nextId = 0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            nhap();
            xuLy();
        }

        private static void xuLy()
        {
            int luaChon;
            do
            {
                Console.WriteLine("==========CHUONG TRINH QUAN LY SINH VIEN=============");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Cap nhat thong tin sinh vien boi ID");
                Console.WriteLine("3. Xoa sinh vien boi ID");
                Console.WriteLine("4. Tim kiem sinh vien theo ten");
                Console.WriteLine("5. Sap xep sinh vien theo diem TB");
                Console.WriteLine("6. Sap xep sinh vien theo ten");
                Console.WriteLine("7. Hien thi danh sach sinh vien");
                Console.WriteLine("8. Ghi danh sach sinh vien vao file");
                Console.WriteLine("9. Thoat chuong trinh :)");
                Console.Write("Nhap lua chon: ");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("===== Nhap thong tin sv can them =======");
                        themSV();
                        break;
                        
                    case 2:
                        Console.WriteLine("===== Cap nhat thong tin sv =======");
                        capNhatSVbyID();
                        break;
                        
                    case 3:
                        Console.WriteLine("===== Xoa thong tin sv =======");
                        xoaSVByID();
                        break;
                        
                    case 4:
                        Console.WriteLine("===== Tim kiem sv bang ten =======");
                        timKiemSv();
                        break;

                    case 5:
                        Console.WriteLine("===== Sap xep sinh vien theo diem TB =======");
                        sapXepByDiemTB();
                        break;

                    case 6:
                        Console.WriteLine("===== Sap xep sinh vien theo ten =======");
                        sapXepByTen();
                        break;

                    case 7:
                        Console.WriteLine("===== Hien thi thong tin sv =======");
                        hienThi();
                        break;

                    case 8:
                        Console.WriteLine("===== Ghi ds thong tin sinh vien vao file  =======");
                        ghiDanhSach();
                        break;

                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :(");
                        break;
                }
            } while (luaChon != 9);
        }

        private static void nhap()
        {
            string[] lines = File.ReadAllLines(@"C:\\Users\\Le Minh Hung\\Desktop\\student.txt");
            n = int.Parse(lines[0]);
            for (int i = 0; i < n; i++)
            {
                a[i].id = int.Parse(lines[i * 9 + 1]);
                a[i].ten = lines[i * 9 + 2];
                a[i].gioiTinh = lines[i * 9 + 3];
                a[i].tuoi = int.Parse(lines[i * 9 + 4]);
                a[i].toan = float.Parse(lines[i * 9 + 5]);
                a[i].ly = float.Parse(lines[i * 9 + 6]);
                a[i].hoa = float.Parse(lines[i * 9 + 7]);
                a[i].diemTB = float.Parse(lines[i * 9 + 8]);
                a[i].hocLuc = lines[i * 9 + 9];

                nextId = Math.Max(nextId, i);

               // Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", a[i].id, a[i].ten, a[i].gioiTinh, a[i].tuoi, a[i].toan, a[i].ly, a[i].hoa, a[i].diemTB, a[i].hocLuc);
            }
        }

        private static float tinhTB(float a, float b, float c)
        {
            return (a + b + c) / 3;
        }

        private static void tinhHocLuc(int i, float dtb)
        {
            if (dtb >= 8) a[i].hocLuc = "Giỏi";
            else if (dtb >= 6.5) a[i].hocLuc = "Khá";
            else if (dtb >= 5) a[i].hocLuc = "Trung Bình";
            else a[i].hocLuc = "Yếu";
        }

        private static void themSV()
        {
            a[n].id = nextId + 2;

            Console.Write("Nhap ten sv: ");
            a[n].ten = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            a[n].gioiTinh = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            a[n].tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap diem Toan: ");
            a[n].toan = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem Ly: ");
            a[n].ly = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem Hoa: ");
            a[n].hoa = float.Parse(Console.ReadLine());

            a[n].diemTB = tinhTB(a[n].toan, a[n].ly, a[n].hoa);

            tinhHocLuc(n, a[n].diemTB);

            n++;
            Console.WriteLine("==========Them sinh vien thanh cong===========");
        }

        private static void capNhatSVbyID()
        {
            int ID;
            Console.Write("==Nhap ID sinh vien can cap nhat ID = ");
            ID = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                if(a[i].id == ID)
                {
                    Console.WriteLine("Ten cu: " + a[ID].ten);
                    Console.Write("Ten moi: ");
                    a[ID].ten = Console.ReadLine();

                    Console.WriteLine("Gioi tinh cu: " + a[ID].gioiTinh);
                    Console.Write("Gioi tinh moi: ");
                    a[ID].gioiTinh = Console.ReadLine();

                    Console.WriteLine("Tuoi cu: " + a[ID].tuoi);
                    Console.Write("Tuoi moi: ");
                    a[ID].tuoi = int.Parse(Console.ReadLine());

                    Console.WriteLine("Diem toan cu: " + a[ID].toan);
                    Console.Write("Diem toan moi: ");
                    a[ID].toan = float.Parse(Console.ReadLine());

                    Console.WriteLine("Diem ly cu: " + a[ID].ly);
                    Console.Write("Diem ly moi: ");
                    a[ID].ly = float.Parse(Console.ReadLine());

                    Console.WriteLine("Diem hoa cu: " + a[ID].hoa);
                    Console.Write("Diem hoa moi: ");
                    a[ID].hoa = float.Parse(Console.ReadLine());

                    tinhTB(a[ID].toan, a[ID].ly, a[ID].hoa);
                    tinhHocLuc(ID, a[ID].diemTB);

                    Console.WriteLine("=======Cap nhat thanh cong========");
                }
            }

            
        }

        private static void xoa(int k)
        {
            for(int i=k; i<n-1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
        }
        private static void xoaSVByID()
        {
            int ID;
            Console.Write("==Nhap ID sinh vien can xoa ID = ");
            ID = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                if(a[i].id == ID)
                {
                    xoa(i);
                }
            }
            Console.WriteLine("====Xoa sinh vien thanh cong======");

        }
        private static void timKiemSv()
        {
            string tenSv;
            Console.Write("==Nhap ten Sv can tim TenSV = ");
            tenSv = Console.ReadLine();

            for(int i=0; i<n; i++)
            {
                if(a[i].ten.Equals(tenSv))
                {
                    Console.WriteLine("ID:          " + a[i].id);
                    Console.WriteLine("Tên:         " + a[i].ten);
                    Console.WriteLine("Giới tính:   " + a[i].gioiTinh);
                    Console.WriteLine("Tuổi:        " + a[i].tuoi);
                    Console.WriteLine("Điểm toán:   " + a[i].toan);
                    Console.WriteLine("Điểm lý:     " + a[i].ly);
                    Console.WriteLine("Điểm hóa:    " + a[i].hoa);
                    Console.WriteLine("Trung bình:  " + a[i].diemTB);
                    Console.WriteLine("Học lực:     " + a[i].hocLuc);
                    Console.Write("\n");
                }
            }
        }

        private static void sapXepByDiemTB()
        {
            Array.Sort(a, 0, n, new SsDiemTB());
        }
      
        private static void sapXepByTen()
        {
            Array.Sort(a, 0, n, new SsTenSV());
        }
        private static void hienThi()
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("ID:          " + a[i].id);
                Console.WriteLine("Tên:         " + a[i].ten);
                Console.WriteLine("Giới tính:   " + a[i].gioiTinh);
                Console.WriteLine("Tuổi:        " + a[i].tuoi);
                Console.WriteLine("Điểm toán:   " + a[i].toan);
                Console.WriteLine("Điểm lý:     " + a[i].ly);
                Console.WriteLine("Điểm hóa:    " + a[i].hoa);
                Console.WriteLine("Trung bình:  " + a[i].diemTB);
                Console.WriteLine("Học lực:     " + a[i].hocLuc);
                Console.Write("\n");
            }
        }

        private static void ghiDanhSach()
        {
            string line = "";
            line += n;
            for(int i=0; i<n; i++)
            {
                line += ("\n" + a[i].id);
                line += ("\n" + a[i].ten);
                line += ("\n" + a[i].gioiTinh);
                line += ("\n" + a[i].tuoi);
                line += ("\n" + a[i].toan);
                line += ("\n" + a[i].ly);
                line += ("\n" + a[i].hoa);
                line += ("\n" + a[i].diemTB);
                line += ("\n" + a[i].hocLuc);
            }
            File.WriteAllText(@"C:\\Users\\Le Minh Hung\\Desktop\\student.txt", line);
            Console.WriteLine("========Ghi danh sach sinh vien vao file thanh cong=========");
        }
    }
}
