using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeMinhHung_2019601690
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_nhap(object sender, RoutedEventArgs e)
        {
            string errValue = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txt_hoten.Text) || string.IsNullOrWhiteSpace(txt_tienbanhang.Text) || string.IsNullOrWhiteSpace(datepicker.Text) || opt_loainv.SelectedItem == null)
                {
                    errValue += "Ban khong duoc bo trong mot trong cac thuoc tinh \n";
                }

                if (!string.IsNullOrWhiteSpace(errValue))
                {
                    throw new Exception(errValue);
                }

                if (!Regex.IsMatch(txt_hoten.Text, @"^[a-zA-Z\s]+$")) //Chỉ nhận chữ và khoảng trắng
                {
                    throw new Exception("Họ Tên Chỉ Được Chứa Chữ Và Khoảng Trắng (Độ dài 6-35 kí tự)!!");
                }

                if (!Regex.IsMatch(txt_tienbanhang.Text, @"(\d+)?.(\d+)?") ||  //số thực double
                   !Regex.IsMatch(txt_tienbanhang.Text, @"\d+")) //số nguyên
                {
                    throw new Exception("Số Tiền Bán Hàng Phải Là Số");
                }

                string hoten = txt_hoten.Text;
                float tienbh = float.Parse(txt_tienbanhang.Text);
                DateTime dtime = datepicker.SelectedDate.Value;
                string loainv = (opt_loainv.SelectedItem as ComboBoxItem).Content.ToString();

                TimeSpan timeSpan = DateTime.Now - dtime;
                int tuoi = Convert.ToInt32(timeSpan.TotalDays / 365.25);
                if (tuoi < 18 || tuoi > 60)
                {
                    throw new Exception("Tuoi phai nam trong khoang [18, 60]");
                }

                list_nv.Items.Add(new NhanVien(hoten, loainv, dtime, tienbh));
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            txt_hoten.Clear();
            txt_tienbanhang.Clear();
            datepicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            opt_loainv.SelectedItem = null;
        }

        private void btn_chitiet(object sender, RoutedEventArgs e)
        {
            NhanVien nv = (list_nv.SelectedItem as NhanVien);

            if (nv == null)
            {
                MessageBox.Show("Ban chua chon nhan vien nao");
            }

            Window2 window2 = new Window2();
            window2.txt_hoten.Text = nv.hoTen;
            window2.txt_tienbanhang.Text = nv.soTienBan.ToString();
            window2.datepicker.Text = nv.ngaysinh.ToString();
            window2.opt_loainv.SelectedItem = nv.loaiNv.ToString();

            window2.ShowDialog();
        }
    }
}
