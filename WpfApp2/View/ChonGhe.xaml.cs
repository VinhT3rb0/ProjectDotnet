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
        private DispatcherTimer timer;
        public ChonGhe(int roomId)
        {
            _roomId=roomId;
            InitializeComponent();
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
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var seatId = button.Tag.ToString();

            // Khởi tạo trạng thái ghế nếu chưa có
            if (!seatStatuses.ContainsKey(seatId))
            {
                seatStatuses[seatId] = SeatStatus.Available;
            }
            switch (seatStatuses[seatId])
            {
                case SeatStatus.Available:
                    button.Background = Brushes.Yellow;
                    seatStatuses[seatId] = SeatStatus.Selected;
                    break;
                case SeatStatus.Selected:
                    button.Background = Brushes.Red; // Đã chọn
                    seatStatuses[seatId] = SeatStatus.Occupied;
                    break;
                case SeatStatus.Occupied:
                    break;
            }
            UpdateOtherButtons();
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
    }
}
