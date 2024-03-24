using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows.Forms;
using Application = System.Windows.Application;
using System.ComponentModel;
using System.Windows.Threading;


namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public MainView()
        {
            InitializeComponent();
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private System.Windows.Controls.UserControl currentFormChild;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Close();
            loginView.Show();
        }
        private void OpenChildForm(System.Windows.Controls.UserControl childControl)
        {
            if (currentFormChild != null && currentFormChild.Parent is ContentControl parentContentControl)
            {
                parentContentControl.Content = null;
            }
            currentFormChild = childControl;
            childContentControl.Content = childControl;
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            OpenChildForm(new DatVe());
            
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            OpenChildForm(new ThongTinKH());
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
