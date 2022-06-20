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
using De16.Models;

namespace De16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBHContext ql = new QLBHContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadComboBox();
            LoadItem();
        }

        private void LoadComboBox()
        {
            var query = from nh in ql.NhomHangs
                        select nh.TenNhomHang;

            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private void LoadItem()
        {
            var query = from sp in ql.SanPhams
                        where sp.SoLuongBan > 0
                        orderby sp.DonGia descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            sp.MaNhomHang,
                            TienBan = string.Format("{0:N0}", sp.DonGia * sp.SoLuongBan) 
                        };
            listSP.ItemsSource = query.ToList();

        }

        private bool check()
        {
            if (string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtSoLuongBan.Text) || string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtMaSP.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtDonGia.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuongBan.Clear();
            cbNhomHang.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong truong du lieu");

                var spham = (from sp in ql.SanPhams
                             where sp.MaSp == int.Parse(txtMaSP.Text)
                             select sp).SingleOrDefault();
                if(spham != null)
                    throw new Exception("Ma khong duoc trung");
                if (!Regex.IsMatch(txtMaSP.Text, @"\d+") || !Regex.IsMatch(txtSoLuongBan.Text, @"\d+"))
                    throw new Exception("So luong ban hoac ma san pham la so nguyen");
                if (int.Parse(txtSoLuongBan.Text) < 0)
                    throw new Exception("So luong ban phai lon hon 0");

                var maNH = (from nh in ql.NhomHangs
                           where nh.TenNhomHang == cbNhomHang.Text
                           select nh.MaNhomHang).SingleOrDefault();

                SanPham sanpham = new SanPham();
                sanpham.MaSp = int.Parse(txtMaSP.Text);
                sanpham.TenSanPham = txtTenSP.Text;
                sanpham.DonGia = int.Parse(txtDonGia.Text);
                sanpham.SoLuongBan = int.Parse(txtSoLuongBan.Text);
                sanpham.MaNhomHang = Convert.ToInt32(maNH);

                ql.SanPhams.Add(sanpham);
                ql.SaveChanges();
                LoadItem();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var spham = (from sp in ql.SanPhams
                         where sp.MaSp == int.Parse(txtMaSP.Text)
                         select sp).SingleOrDefault();


            var maNH = (from nh in ql.NhomHangs
                        where nh.TenNhomHang == cbNhomHang.Text
                        select nh.MaNhomHang).SingleOrDefault();


            spham.TenSanPham = txtTenSP.Text;
            spham.DonGia = int.Parse(txtDonGia.Text);
            spham.SoLuongBan = int.Parse(txtSoLuongBan.Text);
            spham.MaNhomHang = Convert.ToInt32(maNH);

            ql.SaveChanges();
            LoadItem();

            Clear();
        }

        private void Handle_Change(object sender, SelectionChangedEventArgs e)
        {
            var item = listSP.SelectedItem;
            if (item != null)
            {
                var maNH = (listSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                var tenMH = (from nh in ql.NhomHangs
                             where nh.MaNhomHang == int.Parse(maNH)
                             select nh.TenNhomHang).Single();

                cbNhomHang.SelectedItem = tenMH.ToString();
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

            var item = listSP.SelectedItem;
            try
            {
                if (item == null)
                    throw new Exception("Ban chua chon san pham nao de xoa");

                MessageBoxButton buttons = MessageBoxButton.YesNo;
                MessageBoxResult result = MessageBox.Show("Ban co muon xoa san pham hay k?", "Xac nhan", buttons);

                if (result == MessageBoxResult.Yes)
                {
                    var spham = (from sp in ql.SanPhams
                                 where sp.MaSp == int.Parse(txtMaSP.Text)
                                 select sp).SingleOrDefault();

                    ql.SanPhams.Remove(spham);
                    ql.SaveChanges();

                    LoadItem();
                    Clear();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }

        }
    }
}
