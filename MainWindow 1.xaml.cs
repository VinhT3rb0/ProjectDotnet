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

namespace WpfApp2
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

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
}
