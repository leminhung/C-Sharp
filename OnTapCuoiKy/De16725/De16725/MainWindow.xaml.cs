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
using De16725.Models;

namespace De16725
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        QLBenhNhanContext qlbn = new QLBenhNhanContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            LoadCombox();
        }

        private void LoadItems()
        {
            var query = from bn in qlbn.BenhNhans
                        where bn.SongayNv <= 20
                        orderby bn.SongayNv descending
                        select new
                        {
                            bn.Mabn,
                            bn.Hoten,
                            bn.Makhoa,
                            bn.Diachi,
                            bn.SongayNv,
                            Vienphi = bn.SongayNv * 60000
                        };
            dsBenhNhan.ItemsSource = query.ToList();
        }

        private void LoadCombox()
        {
            var query = from kh in qlbn.KhoaKhams
                        select kh.Tenkhoa;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.SelectedIndex = 0;
        }

        private bool check()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtMaBenhNhan.Text) || string.IsNullOrEmpty(txtSoNgayNamVien.Text))
                return false;
            return true;
        }

        private void Clear()
        {
            txtMaBenhNhan.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayNamVien.Clear();
            cbKhoaKham.SelectedItem = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check()) throw new Exception("Khong duoc bo trong cac truong du lieu");
                if (!Regex.IsMatch(txtSoNgayNamVien.Text, @"\d+")) throw new Exception("So ngay nam vien phai la so nguyen");
                if (int.Parse(txtSoNgayNamVien.Text) < 0) throw new Exception("So ngay nam vien phai > 0");

                var maBN = (from bnhan in qlbn.BenhNhans
                            where bnhan.Mabn == txtMaBenhNhan.Text
                            select bnhan.Mabn).SingleOrDefault();
                if (maBN != null) throw new Exception("Ma benh nhan khong duoc trung");

                var maKhoa = (from kh in qlbn.KhoaKhams
                             where kh.Tenkhoa == cbKhoaKham.Text
                             select kh.Makhoa).Single();

                BenhNhan bn = new BenhNhan();
                bn.Makhoa = maKhoa.ToString();
                bn.Mabn = txtMaBenhNhan.Text;
                bn.Hoten = txtHoTen.Text;
                bn.Diachi = txtDiaChi.Text;
                bn.SongayNv = int.Parse(txtSoNgayNamVien.Text);

                qlbn.BenhNhans.Add(bn);
                qlbn.SaveChanges();
                LoadItems();

                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!check()) throw new Exception("Khong duoc bo trong cac truong du lieu");
                if (!Regex.IsMatch(txtSoNgayNamVien.Text, @"\d+")) throw new Exception("So ngay nam vien phai la so nguyen");
                if (int.Parse(txtSoNgayNamVien.Text) < 0) throw new Exception("So ngay nam vien phai > 0");

                var bn = (from bnhan in qlbn.BenhNhans
                            where bnhan.Mabn == txtMaBenhNhan.Text
                            select bnhan).SingleOrDefault();
                if (bn == null) throw new Exception("Hay chon benh nhan de chinh sua");

                var maKhoa = (from kh in qlbn.KhoaKhams
                             where kh.Tenkhoa == cbKhoaKham.Text
                             select kh.Makhoa).Single();

                bn.Makhoa = maKhoa.ToString();
                bn.Mabn = txtMaBenhNhan.Text;
                bn.Hoten = txtHoTen.Text;
                bn.Diachi = txtDiaChi.Text;
                bn.SongayNv = int.Parse(txtSoNgayNamVien.Text);

                qlbn.SaveChanges();
                LoadItems();

                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var bn = (from bnhan in qlbn.BenhNhans
                      where bnhan.Mabn == txtMaBenhNhan.Text
                      select bnhan).SingleOrDefault();
            try
            {
                if (bn == null) throw new Exception("Hay chon benh nhan de chinh xoa");

                var confirm = MessageBox.Show("Ban co chac chan muon xoa?","", MessageBoxButton.YesNo);
                if(confirm == MessageBoxResult.Yes)
                {
                    qlbn.BenhNhans.Remove(bn);
                    qlbn.SaveChanges();
                    LoadItems();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void bnSelected_Change(object sender, SelectionChangedEventArgs e)
        {
            var benhnhan = dsBenhNhan.SelectedItem;
            if(benhnhan != null)
            {
                var maKhoaChon = (dsBenhNhan.SelectedCells[2].Column.GetCellContent(benhnhan) as TextBlock).Text;

                var tenKhoa = (from kh in qlbn.KhoaKhams
                               where kh.Makhoa == maKhoaChon
                               select kh.Tenkhoa).SingleOrDefault();

                cbKhoaKham.SelectedItem = tenKhoa!.ToString();
            }
        }
    }
}
