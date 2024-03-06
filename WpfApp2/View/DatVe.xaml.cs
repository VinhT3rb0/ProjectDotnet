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
using WpfApp2.Database;
using WpfApp2.Models;
using static WpfApp2.Database.ConnectData;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for DatVe.xaml
    /// </summary>
    public partial class DatVe : UserControl
    {
        public DatVe()
        {
            InitializeComponent();
            Ve _ve = new Ve();
            LoadData();
        }
        private void LoadData()
        {
            
        }
        private void btnAddFirm_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
