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

        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            LoadCombobox();
        }

        private void LoadItems()
        {
            var query = from bn in ql.BenhNhans
                        orderby bn.SoNgayNamVien descending
                        select bn;

            listBN.ItemsSource = query.ToList();
        }

        private void LoadCombobox()
        {
            var query = from kh in ql.Khoas
                        select kh.TenKhoa;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.SelectedIndex = 0;
        }

        private bool check()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSoNgayNamVien.Text) || string.IsNullOrEmpty(txtMaBN.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtHoTen.Clear();
            txtMaBN.Clear();
            txtSoNgayNamVien.Clear();
            cbKhoaKham.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check())
                    throw new Exception("Khong duoc bo trong truong du lieu");
                if(!Regex.IsMatch(txtMaBN.Text, @"\d+"))
                    throw new Exception("Ma benh nhan khong dung kieu du lieu");
                if (!Regex.IsMatch(txtSoNgayNamVien.Text, @"\d+"))
                    throw new Exception("So ngay nam vien khong dung kieu du lieu");
                if (int.Parse(txtSoNgayNamVien.Text) < 1)
                    throw new Exception("So ngay nam vien phai >= 1");

                var bnhan = (from bn in ql.BenhNhans
                             where bn.MaBn == Int32.Parse(txtMaBN.Text)
                             select bn).SingleOrDefault();

                if(bnhan != null)
                    throw new Exception("Ma benh nhan da ton tai");

                var maKhoa = (from kh in ql.Khoas
                              where kh.TenKhoa == cbKhoaKham.Text
                              select kh.MaKhoa).SingleOrDefault();

                BenhNhan benhnhan = new BenhNhan();
                benhnhan.MaBn = Int32.Parse(txtMaBN.Text);
                benhnhan.MaKhoa = Convert.ToInt32(maKhoa);
                benhnhan.HoTen = txtHoTen.Text;
                benhnhan.SoNgayNamVien = Int32.Parse(txtSoNgayNamVien.Text);
                benhnhan.VienPhi = Int32.Parse(txtSoNgayNamVien.Text) * 200000;

                ql.BenhNhans.Add(benhnhan);
                ql.SaveChanges();

                LoadItems();
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

        private void btSua_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Handle_Selection_Change(object sender, SelectionChangedEventArgs e)
        {
            var benhnhan = listBN.SelectedItem;
            if (benhnhan != null)
            {
                var maKhoa = (listBN.SelectedCells[2].Column.GetCellContent(benhnhan) as TextBlock).Text;

                var tenKhoa = (from kh in ql.Khoas
                             where kh.MaKhoa.ToString() == maKhoa
                             select kh.TenKhoa).Single();

                cbKhoaKham.SelectedItem = tenKhoa.ToString();
            }
        }
    }
}
