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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for DoanhThu.xaml
    /// </summary>
    public partial class DoanhThu : Window
    {
        private DispatcherTimer timer;
        public DoanhThu()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            List<DoanhThuItem> doanhThuItems = new List<DoanhThuItem>
            {
                new DoanhThuItem { STT = 1, TenPhim = "Avengers: Cuộc Chiến Vô Cực", NgayChieu = DateTime.Now.Date, GioChieu = "18:00", SoVeBan = 100, TongTienVe = 5000000 },
            };
            movieSelectionGrid.ItemsSource = doanhThuItems;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
