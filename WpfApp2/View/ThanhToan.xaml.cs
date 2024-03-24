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
using System.Windows.Shapes;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for ThanhToan.xaml
    /// </summary>
    public partial class ThanhToan : Window
    {
        public ThanhToan(string tenPhim, string ngayChieu, string phongChieu, int giaVe, string selectedSeatsStr)
        {
            InitializeComponent();
            _moviename.Content = tenPhim;
            Time_Date.Content = ngayChieu;
            Room.Content = phongChieu;
            _totalticket.Content = $"{giaVe:N0} VND";
            Seats.Content = selectedSeatsStr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đặt vé thành công");
        }
    }
}
