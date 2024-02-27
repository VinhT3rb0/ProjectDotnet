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
using System.Data.SqlClient;
using System.Data;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Principal;

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
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True;Encrypt=True;");
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
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM User WHERE User='"+txtUser.Text+"' AND Password='"+txtPass.Password+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count>0)
            {
                this.Hide();
                MainView mainView = new MainView();
                mainView.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            /*try
            {
                conn.Open();
                string username = txtUser.Text;
                string password = txtPass.Password;
                string sql = "select * from User where Username='"+username+"' and Password='"+password+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()==true) {
                    MainView mainView = new MainView();
                    mainView.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }*/
        }
    }
}
