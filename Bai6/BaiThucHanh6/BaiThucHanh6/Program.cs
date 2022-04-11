using System;
using System.Collections.Generic;
using System.Text;

namespace LeMinhHung_2019601690_proj62
{

    class SsPrice : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

    class SsYear : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    class Program
    {
        static private List<Vehicles> listVehicle = new List<Vehicles>();

        static void NhapCarsAndTrunks()
        {
            Console.WriteLine("====nhap du lieu cars====".ToUpper());
            for(int i=0; i<1; i++)
            {
                Car car = new Car();
                car.Input();
                listVehicle.Add(car);
            }

            Console.WriteLine("====nhap du lieu trunks====".ToUpper());
            for (int i = 0; i < 1; i++)
            {
                Trunk trunk = new Trunk();
                trunk.Input();
                listVehicle.Add(trunk);
            }
        }

        static void HienThiCarsAndTrunks()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Danh sach Vehicles trong".ToUpper());
            }

            Console.WriteLine("{0,-5} {1,8} {2, 8} {3, 8} {4, 8}", "ID", "Marker", "Model", "Year", "Price");
            foreach(Vehicles vehicle in listVehicle)
            {
                vehicle.Output();
            }

                                                                    /*HỎI THẦY PHẦN NÀY*/


            //for (int i=0; i<1; i++)
            //{
            //    listVehicle[i].Output();
            //}


            //Console.WriteLine("{0,-5} {1,8} {2, 8} {3, 8} {4, 8} {5, 8}", "ID", "Marker", "Model", "Year", "Price", "Trunkload");
            //for (int i=1; i<2; i++)
            //{
            //    listVehicle[i].Output();
            //}
        }

        static void TimKiemVehicleByID()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Danh sach cars trong".ToUpper());
            }

            Console.Write("==Nhap ID can tim ID = ");
            string ID = Console.ReadLine();

            
            Vehicles vehicle = listVehicle.Find(e => e.Id == ID);

            if (vehicle == null)
            {
                Console.WriteLine("Không tìm được xe".ToUpper());
                return;
            }
            else
            {
                Console.WriteLine("===Thông tin xe===".ToUpper());
                Console.WriteLine("{0,-5} {1,8} {2, 8} {3, 8} {4, 8}", "ID", "Marker", "Model", "Year", "Price");
                Console.WriteLine(vehicle);
            }
        }

        static void TimKiemVehicleByMaker()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Danh sach cars trong".ToUpper());
            }

            Console.Write("==Nhap maker can tim Marker = ");
            string ID = Console.ReadLine();


            Vehicles vehicle = listVehicle.Find(e => e.Id == ID);

            if (vehicle == null)
            {
                Console.WriteLine("Không tìm được xe".ToUpper());
                return;
            }
            else
            {
                Console.WriteLine("===Thông tin xe===".ToUpper());
                Console.WriteLine("{0,-5} {1,8} {2, 8} {3, 8} {4, 8}", "ID", "Marker", "Model", "Year", "Price");
                Console.WriteLine(vehicle);
            }
        }

        static void SapXepVehicleByPrice()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Danh sach cars trong".ToUpper());
            }

            SsPrice ss = new SsPrice();
            listVehicle.Sort(ss);
        }

        static void SapXepVehicleByYear()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Danh sach cars trong".ToUpper());
            }

            SsYear ss = new SsYear();
            listVehicle.Sort(ss);
        }


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choose;
            do
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("=====================QUẢN LÝ VẬN TẢI========================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Nhập Dữ Liệu                                           =");
                Console.WriteLine("=2. Hiển Thị Dữ Liệu                                       =");
                Console.WriteLine("=3. Tìm Kiếm Theo ID                                       =");
                Console.WriteLine("=4. Tìm Kiếm Theo Maker                                    =");
                Console.WriteLine("=5. Sắp Xếp Theo Price                                     =");
                Console.WriteLine("=6. Sắp Xếp Theo Year                                      =");
                Console.WriteLine("=7. Kết Thúc                                               =");
                Console.WriteLine("============================================================");
                Console.Write("Mời bạn nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        NhapCarsAndTrunks();
                        break;
                    case 2:
                        HienThiCarsAndTrunks();
                        break;
                    case 3:
                        TimKiemVehicleByID();
                        break;
                    case 4:
                        TimKiemVehicleByMaker();
                        break;
                    case 5:
                        SapXepVehicleByPrice();
                        break;
                    case 6:
                        SapXepVehicleByYear();
                        break;
                    case 7:
                        Console.WriteLine("=======Thoat chuong trinh=======".ToUpper());
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :((");
                        break;
                }

            } while (choose != 7);
        }
    
    }
}
