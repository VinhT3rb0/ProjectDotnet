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
using WpfApp2.Database;
using WpfApp2.Models;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for ThemPhim.xaml
    /// </summary>
    public partial class ThemPhim : Window
    {
        private Phim editedMovie;

        // Constructor nhận tham số kiểu Phim
        public ThemPhim(Phim movie)
        {
            InitializeComponent();
            // Lưu đối tượng Phim được truyền vào cho việc chỉnh sửa
            this.editedMovie = movie;
            movieName.Text = movie.TenPhim;
            movieGender.Text = movie.TheLoai;
            movieDirector.Text = movie.DaoDien;
        }
        public ThemPhim()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainView mainView = new MainView();
            this.Hide();
            mainView.Show();

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                string query = "SELECT MAX(Id) FROM Phim";
                object result = ConnectData.DataProvider.Instance.ExecuteScalar(query);

                // Kiểm tra nếu kết quả trả về là null hoặc không phải là một số nguyên dương
                if (result != null && int.TryParse(result.ToString(), out int maxId))
                {
                    // Tăng giá trị lấy được lên một đơn vị để sử dụng làm Id cho bản ghi mới
                    int newId = maxId + 1;
                    string tenPhim = movieName.Text;
                    string daoDien = movieDirector.Text;
                    string theLoai = movieGender.Text;
                    string quocGia = movieCountry.Text;
                    string moTa = movieDescription.Text;
                    string hinhAnh = "C:\\Users\\aduyn\\OneDrive\\Desktop\\projectdotnet\\WpfApp2\\Images\\Dat-Rung-Phuong-Nam-.jpeg";
                    int thoiLuong = Convert.ToInt32(movieDuration.Text);
                // Thực hiện lưu dữ liệu vào cơ sở dữ liệu
                bool success = ConnectData.DataProvider.Instance.InsertMovie(newId, tenPhim, daoDien, theLoai, quocGia, moTa, hinhAnh, thoiLuong);

                if (success)
                {
                    MessageBox.Show("Thêm phim thành công!");

                }
                else
                {
                    MessageBox.Show("Thêm phim không thành công!");
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public void SetMovieInfo(Phim movie)
        {
            movieName.Text = movie.TenPhim;
            movieGender.Text = movie.TheLoai;
            movieDirector.Text = movie.DaoDien;
            movieCountry.Text = movie.QuocGia;
            movieDescription.Text = movie.MoTa;
            movieDuration.Text = movie.ThoiLuong.ToString();
        }

    }
}
