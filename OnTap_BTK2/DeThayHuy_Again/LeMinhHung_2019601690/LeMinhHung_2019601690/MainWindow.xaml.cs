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

        private void btn_delete(object sender, RoutedEventArgs e)
        {
            txt_ten.Clear();
            txt_luong.Clear();
            txt_songaycong.Clear();
            rdnam.IsChecked = true;
            txt_ten.Focus();
        }

        private void btn_detail(object sender, RoutedEventArgs e)
        {
            NhanVien nv = list_nv.SelectedItem as NhanVien;


            if (nv == null)
            {
                MessageBox.Show("Ban hay chon nhan vien de xem chi tiet", "Thong bao loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            Window2 window = new Window2();
            window.txt_ten.Text = nv.hoTen;
            window.txt_luong.Text = nv.luong.ToString();
            window.txt_thuong.Text = nv.thuong.ToString();
            window.txt_songaycong.Text = nv.soNgayCong.ToString();
            window.rdnam.IsChecked = nv.gioiTinh ? true : false;
            window.rd_nu.IsChecked = nv.gioiTinh ? false : true;

            window.ShowDialog();

        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            string errValue = "";
            try
            {
                if(string.IsNullOrWhiteSpace(txt_luong.Text) || string.IsNullOrWhiteSpace(txt_ten.Text) || string.IsNullOrWhiteSpace(txt_songaycong.Text) || (rdnam.IsChecked == false && rd_nu.IsChecked == false))
                {
                    errValue += "Khong duoc bo trong truong du lieu \n";
                }
                if(!string.IsNullOrWhiteSpace(errValue))
                {
                    throw new Exception(errValue);
                }

                string hoten = txt_ten.Text;
                float luong = float.Parse(txt_luong.Text);
                int songaycong = int.Parse(txt_songaycong.Text);
                bool gioiTinh = (bool)rdnam.IsChecked;

                string invalValue = "";
                if(songaycong < 20 || songaycong > 30)
                {
                    invalValue += "So ngay cong phai nam trong khoang [20, 30] \n";
                }
                if (luong < 3000 || luong > 5000)
                {
                    invalValue += "Luong phai nam trong khoang [3000, 5000] \n";
                }

                if (!string.IsNullOrWhiteSpace(invalValue))
                {
                    throw new Exception(invalValue);
                }

                list_nv.Items.Add(new NhanVien(hoten, gioiTinh, songaycong, luong));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
