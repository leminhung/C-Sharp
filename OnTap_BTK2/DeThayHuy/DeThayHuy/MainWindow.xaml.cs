using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private void btnXoa_onClick(object sender, RoutedEventArgs e)
        {
            txt_hoten.Clear();
            txt_songaycong.Clear();
            txt_luong.Clear();
            rdnam.IsChecked = true;
            txt_hoten.Focus();
        }

        private void btn_xemchitiet(object sender, RoutedEventArgs e)
        {
            Employee employee = list_nv.SelectedItem as Employee;

            if(employee == null)
            {
                MessageBox.Show("Ban hay chon nhan vien de xem chi tiet", "Thong bao loi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Window2 window2 = new Window2();
            window2.txt_hoten.Text = employee.HoTen;
            window2.txt_luong.Text = employee.Luong.ToString();
            window2.txt_songaycong.Text = employee.SoNgayCong.ToString();
            window2.txt_thuong.Text = employee.Thuong.ToString();
            window2.rdnam.IsChecked = employee.GioiTinh;

            window2.Show();
            Close();
        }

        private void btn_themnv(object sender, RoutedEventArgs e)
        {
            string whiteSpace = "";
            try
            {
                if(string.IsNullOrWhiteSpace(txt_hoten.Text) || string.IsNullOrWhiteSpace(txt_luong.Text) || string.IsNullOrWhiteSpace(txt_songaycong.Text))
                {
                    whiteSpace += "Khong duoc de trong mot trong cac truong du lieu!\n";
                }

                if(!string.IsNullOrWhiteSpace(whiteSpace))
                {
                    throw new Exception(whiteSpace);
                }

                string HoTen = txt_hoten.Text;
                bool GioiTinh = (bool)rdnam.IsChecked;
                Int64 SoNgayCong = Int64.Parse(txt_songaycong.Text);
                Int64 Luong = Int64.Parse(txt_luong.Text);

                string errValue = "";
                if(SoNgayCong < 20 || SoNgayCong > 30)
                {
                    errValue += "So ngay cong phai nam trong khoang [20, 30] \n";
                }

                if (Luong < 3000 || Luong > 5000)
                {
                    errValue += "Luong phai nam trong khoang [3000, 5000]";
                }

                if (!string.IsNullOrWhiteSpace(errValue))
                {
                    throw new Exception(errValue);
                }

                list_nv.Items.Add(new Employee(HoTen, GioiTinh, SoNgayCong, Luong));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_dong_window(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
