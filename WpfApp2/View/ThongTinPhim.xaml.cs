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
using WpfApp2.Models;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for ThongTinPhim.xaml
    /// </summary>
    public partial class ThongTinPhim : Window
    {
        public ThongTinPhim()
        {
            InitializeComponent();
        }
        public ThongTinPhim(Phim selectedMovie) : this()
        {
            txtTenPhim.Content = selectedMovie.TenPhim;
            txtTheLoai.Content = selectedMovie.TheLoai;
            txtDaoDien.Content = selectedMovie.DaoDien;
            txtThoiLuong.Content = selectedMovie.ThoiLuong.ToString();
            txtQuocGia.Content = selectedMovie.QuocGia;
            txtMoTa.Content = selectedMovie.MoTa;
            string imagePath = selectedMovie.HinhAnh;
            if (!string.IsNullOrEmpty(imagePath))
            {
                imgPoster.Source = new BitmapImage(new Uri(imagePath));
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainView mainView = new MainView();
            this.Hide();
            mainView.Show();

        }
    }
}
