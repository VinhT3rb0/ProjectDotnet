using Microsoft.VisualBasic.Devices;
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
using WpfApp2.Models;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for SuaTTKH.xaml
    /// </summary>
    public partial class SuaTTKH : Window
    {
        private KhachHang editedCustomer;
        public SuaTTKH(KhachHang customer)
        {
            InitializeComponent();
            this.editedCustomer = customer;
            _FullName.Text = customer.Ten;
            _Phone.Text = customer.Sdt;
            _Age.Text = customer.Tuoi.ToString();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainView mainView = new MainView();
            this.Hide();
            mainView.Show();
        }
    }
}
