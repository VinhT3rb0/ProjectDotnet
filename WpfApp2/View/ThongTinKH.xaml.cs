using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for ThongTinKH.xaml
    /// </summary>
    public partial class ThongTinKH : UserControl
    {
        public ThongTinKH()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()

        {
            try
            {
                string query = "SELECT Id, Ten, SDT, Tuoi FROM KhachHang";
                DataTable dataTable = ConnectData.DataProvider.Instance.ExecuteQuery(query);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    CustomersGrid.Columns.Clear();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        DataGridTextColumn dataGridColumn = new DataGridTextColumn();
                        dataGridColumn.Header = column.ColumnName;
                        dataGridColumn.Binding = new Binding(column.ColumnName);
                        CustomersGrid.Columns.Add(dataGridColumn);
                    }
                    CustomersGrid.ItemsSource = dataTable.DefaultView;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void IconImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            KhachHang newCustomer = new KhachHang();
            SuaTTKH editWindow = new SuaTTKH(newCustomer);
            editWindow.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
