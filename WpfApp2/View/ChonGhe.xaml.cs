using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using WpfApp2.Database;
using WpfApp2.Models;

namespace WpfApp2.View
{
    public partial class ChonGhe : Window
    {
        private int _roomId;
        private int _currentPrice = 0;
        private DispatcherTimer timer;
        public ChonGhe(int roomId, string tenPhim)
        {
            InitializeComponent();
            _roomId=roomId;
            filmName.Text = tenPhim;
            SuatChieu.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            _currentPrice = 70000;
            GiaVe.Content = _currentPrice.ToString("N0") + " VND";
            SetupDateTimeDisplay();
        }
        private void SetupDateTimeDisplay()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window chonGhe = Window.GetWindow(this);
            if(chonGhe != null) {
                chonGhe.Hide();
            }
        }
        private Dictionary<string, SeatStatus> seatStatuses = new Dictionary<string, SeatStatus>();
        public enum SeatStatus
        {
            Available, 
            Selected, 
            Occupied 
        }
        private List<string> selectedSeats = new List<string>();
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null || button.Tag == null) return;

            var seatId = button.Tag.ToString();
            if (!seatStatuses.ContainsKey(seatId))
            {
                seatStatuses[seatId] = SeatStatus.Available;
            }
            switch (seatStatuses[seatId])
            {
                case SeatStatus.Available:
                    button.Background = Brushes.Yellow;
                    seatStatuses[seatId] = SeatStatus.Selected;
                    _currentPrice += 70000;
                    selectedSeats.Add(seatId);
                    UpdatePriceDisplay();
                    break;
                case SeatStatus.Selected:
                    button.Background = Brushes.Red; 
                    seatStatuses[seatId] = SeatStatus.Occupied;
                    selectedSeats.Remove(seatId);
                    break;
                case SeatStatus.Occupied:
                    break;
            }
            UpdateOtherButtons();
            UpdateSelectedSeatsDisplay();
        }
        private void UpdatePriceDisplay()
        {
            GiaVe.Content = "70.000" + " VND";
            TotalPrice.Content = _currentPrice.ToString("N0") + "VND";
        }
        private void UpdateSelectedSeatsDisplay()
        {
            select_Seats.Content = string.Join(", ", selectedSeats);
        }
        private void UpdateOtherButtons()
        {
            foreach (var child in SeatsGrid.Children)
            {
                if (child is Button button && button.Tag != null)
                {
                    var seatId = button.Tag.ToString();

                    if (seatStatuses.ContainsKey(seatId))
                    {
                        switch (seatStatuses[seatId])
                        {
                            case SeatStatus.Available:
                                button.Background = Brushes.White;
                                break;
                            case SeatStatus.Selected:
                                button.Background = Brushes.Yellow;
                                break;
                            case SeatStatus.Occupied:
                                button.Background = Brushes.Red;
                                break;
                        }
                    }
                }
            }
        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
            string tenPhim = filmName.Text;
            string ngayChieu = SuatChieu.Text;
            string phongChieu = _roomId.ToString();
            int giaVe = _currentPrice;
            string selectedSeatsStr = string.Join(", ", selectedSeats);
            ThanhToan thanhToanWindow = new ThanhToan(tenPhim, ngayChieu, _roomId.ToString(), giaVe, selectedSeatsStr);
            thanhToanWindow.Show();
        }
    }
}
