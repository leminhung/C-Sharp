using System.Windows;
using System.Windows.Controls;

namespace Bai9_3
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

        private void setOnClick_btnThem(object sender, RoutedEventArgs e)
        {
            string ThongBao = "Họ Tên: " + txtHoTen.Text + "\n";
            ThongBao += "Giới Tính: ";
            ThongBao += ((bool)rdNam.IsChecked) ? rdNam.Content : rdNu.Content;
            ThongBao += "\nTình Trạng Hôn Nhân: ";
            ThongBao += ((bool)rdChuaKetHon.IsChecked) ? rdChuaKetHon.Content : rdDaKetHon.Content;
            ThongBao += "\nSở Thích: ";

            string soThich = "";

            foreach (var item in new CheckBox[] { chkAmNhac, chkBoiLoi, chkBongDa, chkLeoNui })
            {
                if ((bool)item.IsChecked)
                {
                    soThich += item.Content + ", ";
                }
            }

            soThich = soThich.Remove(soThich.Length - 2);

            ThongBao += soThich;
            txtB_Answer.Text = ThongBao;
        }

        private void setOnClick_btnThoat(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
