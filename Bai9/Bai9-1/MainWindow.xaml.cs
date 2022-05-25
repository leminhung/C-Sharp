using System.Collections.Generic;
using System.Windows;

namespace Bai9_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_chon1_Click(object sender, RoutedEventArgs e)
        {
            string chuoi1 = danhsach.SelectedItem.ToString();
            string chuoi = chuoi1.Substring(37);
            danhsachchon.Items.Add(chuoi);
        }

        private void btn_chontatca_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in danhsach.Items)
            {
                string chuoi = item.ToString().Substring(37);
                danhsachchon.Items.Add(chuoi);
            }
        }

        private void btn_bo1_Click(object sender, RoutedEventArgs e)
        {
            danhsachchon.Items.Remove(danhsachchon.SelectedItem.ToString());
        }

        private void btn_botatca_Click(object sender, RoutedEventArgs e)
        {
            danhsachchon.Items.Clear();
        }

        private void btn_Thoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
