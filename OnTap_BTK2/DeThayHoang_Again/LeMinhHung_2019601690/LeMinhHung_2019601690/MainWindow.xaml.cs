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
        List<NhanVien> nhanviens =new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            string manv = txt_manv.Text;
            string hoten = txt_hoten.Text;
            string gioitinh = (bool)rdnam.IsChecked ? "Nam": "Nữ";
            DateTime date = datepicker.SelectedDate.Value;
            float tienluongngay = float.Parse(txt_luongngay.Text);
            int songaylamviec = int.Parse(txt_songaylamviec.Text);

            nhanviens.Add(new NhanVien(manv, hoten, gioitinh, date, tienluongngay, songaylamviec));
            MessageBox.Show("Them thanh cong", "Thong bao");
        }

        private void btn_display(object sender, RoutedEventArgs e)
        {
            foreach(var item in nhanviens)
            {
                list_nv.Items.Add(item);
            }
        }

        private void btn_delete(object sender, RoutedEventArgs e)
        {
            txt_manv.Clear();
            txt_hoten.Clear();
            rdnam.IsChecked = true;
            rd_nu.IsChecked = false;
            txt_manv.Clear();
            datepicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_luongngay.Clear();
            txt_songaylamviec.Clear();
            txt_manv.Focus();
        }

        private void btn_detail_item(object sender, MouseButtonEventArgs e)
        {
            NhanVien nv = list_nv.SelectedItem as NhanVien;
            if(nv == null)
            {
                MessageBox.Show("Khong co nhan vien nao duoc chon", "Thong bao loi");
                return;
            }

            Window1 window1 = new Window1();
            window1.txt_manv.Text = nv.maNV;
            window1.txt_hoten.Text = nv.hoten;
            window1.rdnam.IsChecked = nv.gioiTinh.Equals("Nam") ? true: false;
            window1.rdnu.IsChecked = nv.gioiTinh.Equals("Nam") ? false: true;
            window1.datepicker.Text = nv.ngaySinh.ToString();
            window1.txt_tienluongngay.Text = nv.luongNgay.ToString();
            window1.txt_songaylamviec.Text = nv.soNgayLamViec.ToString();
            window1.txt_tienluong.Text = nv.tienLuong.ToString();

            window1.ShowDialog();
        }
    }
}
