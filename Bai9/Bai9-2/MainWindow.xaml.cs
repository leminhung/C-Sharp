using System.Windows;
using System.Windows.Controls;

namespace Bai9_2
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

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string ketqua = txtHoTen.Text + " - ";
            ketqua += (cbGioiTinh.SelectedItem as ComboBoxItem).Content.ToString() + " - ";
            ketqua += (cbPhongBan.SelectedItem as ComboBoxItem).Content.ToString();

            listboxThongTin.Items.Add(ketqua);
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
