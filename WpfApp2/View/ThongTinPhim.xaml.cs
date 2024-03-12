using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp2.Database;
using WpfApp2.Models;
using System.Data.SqlClient;

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
            txtMoTa.Text = selectedMovie.MoTa;
            string query = "SELECT * FROM Phim";
            DataTable dataTable = ConnectData.DataProvider.Instance.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                // Gán thông tin QuocGia cho điều khiển tương ứng trên màn hình ThongTinPhim
                txtQuocGia.Content = row["QuocGia"].ToString();
                txtMoTa.Text = row["MoTa"].ToString();
            }
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
