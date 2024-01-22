using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2
{
    public partial class MovieView : Window
    {
        List<Movie> movies = new List<Movie>();

        public MovieView()
        {
            InitializeComponent();
            movies.Add(new Movie { TenPhim = "Avengers: Cuộc Chiến Vô Cực", GioChieu = "18:00", TinhTrang = "65/100", GiaVe = 100000, DanhGia = 4 });
            movieSelectionGrid.ItemsSource = movies;
            movies.Add(new Movie { TenPhim = "Avengers: Cuộc Chiến Vô Cực", GioChieu = "19:00", TinhTrang = "27/100", GiaVe = 100000, DanhGia = 4 });
            movieSelectionGrid.ItemsSource = movies;
        }
    }
}
