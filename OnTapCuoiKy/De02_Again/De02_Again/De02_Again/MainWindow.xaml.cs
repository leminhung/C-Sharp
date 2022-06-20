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
using De02_Again.Models;

namespace De02_Again
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadCombox();
            LoadItem();
        }

        private void LoadCombox()
        {
            var query = from nh in ql.NhomHangs
                        select nh.TenNhomHang;
            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private void LoadItem() {
            var query = from sp in ql.SanPhams
                        orderby sp.SoLuongBan descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            sp.MaNhomHang,
                            //TienBan = string.Format("{}")
                            TienBan = sp.SoLuongBan * sp.DonGia
                        };
            listSP.ItemsSource = query.ToList();
        }
        private bool check()
        {
            if (string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtMaSp.Text) || string.IsNullOrEmpty(txtSoLuongBan.Text) || string.IsNullOrEmpty(txtTenSP.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtDonGia.Clear();
            txtMaSp.Clear();
            txtSoLuongBan.Clear();
            txtTenSP.Clear();
            cbNhomHang.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong du lieu");
                if(!Regex.IsMatch(txtSoLuongBan.Text, @"\d+") || !Regex.IsMatch(txtMaSp.Text, @"\d+"))
                    throw new Exception("So luong ban hoac ma san pham phai nguyen");
                if(int.Parse(txtSoLuongBan.Text) < 1)
                    throw new Exception("So luong ban phai >= 1");

                var spham = (from sp in ql.SanPhams
                             where sp.MaSp == int.Parse(txtMaSp.Text)
                             select sp).SingleOrDefault();
                if (spham != null)
                    throw new Exception("Ma san pham khong duoc trung");

                var maNH = (from nh in ql.NhomHangs
                            where nh.TenNhomHang == cbNhomHang.Text
                            select nh.MaNhomHang).SingleOrDefault();

                SanPham s = new SanPham();
                s.MaSp = int.Parse(txtMaSp.Text);
                s.TenSanPham = txtTenSP.Text;
                s.DonGia = int.Parse(txtDonGia.Text);
                s.SoLuongBan = int.Parse(txtSoLuongBan.Text);
                s.MaNhomHang = Convert.ToInt32(maNH);
                s.TienBan = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongBan.Text);

                ql.SanPhams.Add(s);
                ql.SaveChanges();
                LoadItem();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void Handle_Change(object sender, SelectionChangedEventArgs e)
        {
            var item = listSP.SelectedItem;
            if(item != null)
            {
                var maNH = (listSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                var tenNH = (from nh in ql.NhomHangs
                             where nh.MaNhomHang == int.Parse(maNH)
                             select nh.TenNhomHang).SingleOrDefault();
                cbNhomHang.SelectedItem = tenNH.ToString();
            }
        }
    }
}
