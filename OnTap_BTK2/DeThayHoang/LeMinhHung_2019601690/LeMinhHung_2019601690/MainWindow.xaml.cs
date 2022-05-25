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
        public List<NhanVien> nhanviens = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_them(object sender, RoutedEventArgs e)
        {
            string manv = txt_manv.Text;
            string hoten = txt_hoten.Text;
            string gioitinh = (bool)rdnam.IsChecked ? "Nam" : "Nữ";
            DateTime timepicker = datepicker.DisplayDate;
            Int64 tienLuongNgay = Int64.Parse(txt_tienluongngay.Text);
            Int64 soNgayLamViec = Int64.Parse(txt_songaylamviec.Text);

            nhanviens.Add(new NhanVien(manv, hoten, gioitinh, timepicker, tienLuongNgay, soNgayLamViec));
            MessageBox.Show("Them nhan vien thanh cong!");
        }

        private void btn_hienthi(object sender, RoutedEventArgs e)
        {
            foreach (var item in nhanviens)
            {
                list_nv.Items.Add(item);
            }
        }


        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_songaylamviec.Clear();
            txt_tienluongngay.Clear();
            rdnam.IsChecked = true;
            txt_manv.Focus();
            datepicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn_item_detail(object sender, MouseButtonEventArgs e)
        {
            NhanVien nv = list_nv.SelectedItem as NhanVien;
            if (nv == null)
            {
                MessageBox.Show("Ban chua chon nhan vien nao :((", "Thong bao loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Window2 window2 = new Window2();
            window2.txt_manv.Text = nv.maNV;
            window2.txt_hoten.Text = nv.hoTen;
            window2.rdnam.IsChecked = nv.gioiTinh.Equals("Nam") ? true : false;
            window2.rdnu.IsChecked = nv.gioiTinh.Equals("Nam") ? false : true;
            window2.txt_tienluong.Text = nv.tienLuongNgay.ToString();
            window2.txt_songaylamviec.Text = nv.soNgayLamViec.ToString();
            window2.txt_tongluong.Text = nv.luongTong.ToString();

            window2.Show();
        }
    }
}
