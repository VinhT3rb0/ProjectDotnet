using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using WpfApp2.Database;
namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Password;

            if (Login(username, password))
            {
                MainView mainView = new MainView();
                this.Hide();
                mainView.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            txtUser.Text = "";
            txtPass.Password = "";
        }
        private bool Login(string username, string password)
        {
            return Account.Instance.Login(username, password);
        }
    }
}
