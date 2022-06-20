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
using De02.Models;

namespace De02
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
            LoadItem();
            LoadCombobox();
        }

        private void LoadItem()
        {
            var query = from sp in ql.SanPhams
                        orderby sp.SoLuongBan descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            sp.MaNhomHang,
                            TienBan = sp.SoLuongBan * sp.DonGia,
                        };
            listSP.ItemsSource = query.ToList();
        }

        private void LoadCombobox()
        {
            var query = from hh in ql.NhomHangs
                        select hh.TenNhomHang;

            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private bool check()
        {
            if (string.IsNullOrEmpty(txtMaSp.Text) || string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtSoLuongBan.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtDonGia.Clear();
            txtSoLuongBan.Clear();
            txtMaSp.Clear();
            txtTenSP.Clear();
            cbNhomHang.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong cac truong du lieu");

                var spham = (from sp in ql.SanPhams
                             where sp.MaSp == int.Parse(txtMaSp.Text)
                             select sp).SingleOrDefault();
                if (spham != null)
                    throw new Exception("Ma san pham khong duoc trung");

                if (!Regex.IsMatch(txtMaSp.Text, @"\d+") || !Regex.IsMatch(txtSoLuongBan.Text, @"\d+"))
                    throw new Exception("Ma san pham hoac so luong ban phai la kieu nguyen");
                if(int.Parse(txtSoLuongBan.Text) < 1)
                    throw new Exception("So luong ban phai lon hon 1");
                if (!Regex.IsMatch(txtDonGia.Text, @"\d+.\d+"))
                    throw new Exception("Don gia khong dung kieu du lieu");

                var maNH = (from hh in ql.NhomHangs
                           where hh.TenNhomHang == cbNhomHang.Text
                            select hh.MaNhomHang).Single();

                SanPham s = new SanPham();
                s.MaSp = Convert.ToInt32(txtMaSp.Text);
                s.TenSanPham = txtTenSP.Text;
                s.DonGia = Convert.ToDouble(txtDonGia.Text);
                s.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                s.MaNhomHang = Convert.ToInt32(maNH);
                s.TienBan = Convert.ToDouble(txtDonGia.Text) * Convert.ToInt32(txtSoLuongBan.Text);

                ql.SanPhams.Add(s);
                ql.SaveChanges();

                LoadItem();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void HandleChangeValue(object sender, SelectionChangedEventArgs e)
        {
            var item = listSP.SelectedItem;

            if(item != null)
            {
                var maNH = (listSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;

                var tenNH = (from nh in ql.NhomHangs
                             where int.Parse(maNH) == nh.MaNhomHang
                             select nh.TenNhomHang).Single();

                cbNhomHang.SelectedItem = tenNH;
            }
        }
    }
}
