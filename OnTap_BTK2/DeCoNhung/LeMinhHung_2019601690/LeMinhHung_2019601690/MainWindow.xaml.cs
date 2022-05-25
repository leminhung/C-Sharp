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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_nhap(object sender, RoutedEventArgs e)
        {

        }

        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            txt_hoten.Clear();
            txt_tienbanhang.Clear();
            datepicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
            opt_loainv.SelectedItem = null;
        }

        private void btn_chitiet(object sender, RoutedEventArgs e)
        {

        }
    }
}
