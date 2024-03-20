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

namespace WpfApp2.View
{
    public partial class PhongChieu : UserControl
    {
        public PhongChieu()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT Id, soLuongGhe FROM Phong";
                DataTable dataTable = ConnectData.DataProvider.Instance.ExecuteQuery(query);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    roomDataGrid.Columns.Clear();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        DataGridTextColumn dataGridColumn = new DataGridTextColumn();
                        dataGridColumn.Header = column.ColumnName;
                        dataGridColumn.Binding = new Binding(column.ColumnName);
                        roomDataGrid.Columns.Add(dataGridColumn);
                    }
                    roomDataGrid.ItemsSource = dataTable.DefaultView;
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

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            if (roomDataGrid.SelectedItem is DataRowView selectedRow)
            {
                int roomId = Convert.ToInt32(selectedRow["Id"]);
                var chonGhe = new ChonGhe(roomId);
                chonGhe.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng chiếu trước khi lưu.");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window phongChieu = Window.GetWindow(this);
            if(phongChieu != null) {
                phongChieu.Hide();
                ThongTinPhim thongTin = new ThongTinPhim();
                thongTin.Show();
            }
        }
    }
}
