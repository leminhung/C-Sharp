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

namespace Bai9_5
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

        private void setOnClick_btnChonNY(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();

            foreach (StackPanel stackPanel in lbItem.Children)
            {
                CheckBox checkBox = stackPanel.Children.OfType<CheckBox>().FirstOrDefault();

                if (checkBox.IsChecked == false)
                    continue;

                var ketqua = stackPanel.Children.OfType<Label>().FirstOrDefault().Content.ToString();
                list.Add(ketqua);
            }

            string kq = "";
            foreach (var ls in list)
            {
                kq += ls + ", ";
            }
            kq = kq.Remove(kq.Length - 2);
            MessageBox.Show("Bạn đã chọn: " + kq, "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

