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
using De16725_Again.Models;

namespace De16725_Again
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBenhNhanContext ql = new QLBenhNhanContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            LoadCombobox();
        }



        private void LoadItems()
        {
            var query = from bn in ql.BenhNhans
                        where bn.SongayNv <= 20
                        orderby bn.SongayNv descending
                        select new
                        {
                            bn.Mabn,
                            bn.Hoten,
                            bn.Makhoa,
                            bn.Diachi,
                            bn.SongayNv,
                            VienPhi = bn.SongayNv * 60000
                        };

            listBN.ItemsSource = query.ToList();
        }

        private void LoadCombobox()
        {
            var query = from kh in ql.KhoaKhams
                        select kh.Tenkhoa;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.SelectedIndex = 0;
        }

        private bool check()
        {
            if (string.IsNullOrEmpty(txtMaBN.Text) || string.IsNullOrEmpty(txtTenBN.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoNgayNV.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtDiaChi.Clear();
            txtMaBN.Clear();
            txtSoNgayNV.Clear();
            txtTenBN.Clear();
            cbKhoaKham.SelectedIndex = 0;
        }


        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong du lieu");

                int soNgayNV;
                bool check1 = Int32.TryParse(txtSoNgayNV.Text, out soNgayNV);

                if (!check1)
                    throw new Exception("So ngay nam vien khong dung kieu du lieu");

                if (int.Parse(txtSoNgayNV.Text) < 0)
                    throw new Exception("So ngay nam vien phai >= 0");

                var bnhan = (from sp in ql.BenhNhans
                             where sp.Mabn == txtMaBN.Text
                             select sp).SingleOrDefault();
                if (bnhan != null)
                    throw new Exception("Ma san pham khong duoc trung");

                var maKhoa = (from nh in ql.KhoaKhams
                            where nh.Tenkhoa == cbKhoaKham.Text
                            select nh.Makhoa).SingleOrDefault();

                BenhNhan s = new BenhNhan();
                s.Mabn = txtMaBN.Text;
                s.Hoten = txtTenBN.Text;
                s.Makhoa = maKhoa!.ToString();
                s.Diachi = txtDiaChi.Text;
                s.SongayNv = soNgayNV;

                ql.BenhNhans.Add(s);
                ql.SaveChanges();
                LoadItems();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong du lieu");

                int soNgayNV;
                bool check1 = Int32.TryParse(txtSoNgayNV.Text, out soNgayNV);

                if (!check1)
                    throw new Exception("So ngay nam vien khong dung kieu du lieu");

                if (int.Parse(txtSoNgayNV.Text) < 0)
                    throw new Exception("So ngay nam vien phai >= 0");

                var bnhan = (from bn in ql.BenhNhans
                             where bn.Mabn == txtMaBN.Text
                             select bn).SingleOrDefault();
                if (bnhan == null) throw new Exception("Khong co benh nhan de sua");

                var maKhoa = (from nh in ql.KhoaKhams
                              where nh.Tenkhoa == cbKhoaKham.Text
                              select nh.Makhoa).SingleOrDefault();

                bnhan.Hoten = txtTenBN.Text;
                bnhan.Makhoa = maKhoa!.ToString();
                bnhan.Diachi = txtDiaChi.Text;
                bnhan.SongayNv = soNgayNV;

                ql.SaveChanges();
                LoadItems();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var bn = (from bnhan in ql.BenhNhans
                      where bnhan.Mabn == txtMaBN.Text
                      select bnhan).SingleOrDefault();
            try
            {
                if (bn == null) throw new Exception("Hay chon benh nhan de chinh xoa");

                var confirm = MessageBox.Show("Ban co chac chan muon xoa?", "", MessageBoxButton.YesNo);
                if (confirm == MessageBoxResult.Yes)
                {
                    ql.BenhNhans.Remove(bn);
                    ql.SaveChanges();
                    LoadItems();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
