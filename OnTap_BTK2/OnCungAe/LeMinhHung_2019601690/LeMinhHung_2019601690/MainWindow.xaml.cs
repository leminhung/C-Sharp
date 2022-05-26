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
        List<NhanVien> nhanviens = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_them(object sender, RoutedEventArgs e)
        {
            string manv = txt_manv.Text;
            string hoten = txt_hoten.Text;
            Int64 songaylamviec = Int64.Parse(txt_songaylamviec.Text);
            Int64 tienluongngay = Int64.Parse(txt_tienluongngay.Text);
            string gioitinh = (bool)rdnam.IsChecked ? "Nam" : "Nữ";
            DateTime datee = DateTime.ParseExact(datepicker.Text, "M/dd/yyyy", null);

            nhanviens.Add(new NhanVien(manv, hoten, gioitinh, datee, songaylamviec, tienluongngay));
            MessageBox.Show("Da them thanh cong", "Thong bao thanh cong");
        }

        private void btn_hienthi(object sender, RoutedEventArgs e)
        {
            list_nv.Items.Clear();

            foreach(var item in nhanviens)
            {
                list_nv.Items.Add(item);
            }
        }

        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            txt_hoten.Clear();
            txt_manv.Clear();
            txt_songaylamviec.Clear();
            txt_tienluongngay.Clear();
            rdnam.IsChecked = true;
            datepicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_manv.Focus();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_item_detail(object sender, MouseButtonEventArgs e)
        {
            NhanVien nv = list_nv.SelectedItem as NhanVien;

            if(nv == null)
            {
                MessageBox.Show("Ban chua chon nhan vien nao", "Thong bao loi");
                return;
            }

            Window2 window2 = new Window2();
            window2.txt_manv.Text = nv.MaNV;
            window2.txt_hoten.Text = nv.HoTen;
            window2.txt_songaylamviec.Text = nv.SoNgayLamViec.ToString();
            window2.datepicker.Text = nv.NamSinh.ToString();
            window2.rdnam.IsChecked = nv.GioiTinh.Equals("Nam") ? true : false;
            window2.rdnu.IsChecked = nv.GioiTinh.Equals("Nam") ? false : true;
            window2.txt_tienluong.Text = nv.TienLuongNgay.ToString();
            window2.txt_tongluong.Text = nv.luongTong.ToString();

            window2.ShowDialog();
        }
    }
}
