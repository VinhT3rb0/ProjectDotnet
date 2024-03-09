using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT TenPhim, TheLoai, DaoDien, ThoiLuong, HinhAnh FROM Phim";
                DataTable dataTable = ConnectData.DataProvider.Instance.ExecuteQuery(query);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    movieDataGrid.Columns.Clear();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        DataGridTextColumn dataGridColumn = new DataGridTextColumn();
                        dataGridColumn.Header = column.ColumnName;
                        dataGridColumn.Binding = new Binding(column.ColumnName);
                        movieDataGrid.Columns.Add(dataGridColumn);
                    }
                    movieDataGrid.ItemsSource = dataTable.DefaultView;
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
        private void btnAddFirm_Click(object sender, RoutedEventArgs e)
        {
            Window mainView = Application.Current.MainWindow;
            mainView.Hide();
            Window childForm = Window.GetWindow(this);
            childForm.Hide();
            ThemPhim themPhimWindow = new ThemPhim();
            themPhimWindow.Closed += (s, args) =>
            {
                mainView.Show();
                childForm.Show();
            };
            themPhimWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuyTicket_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = (DataRowView)movieDataGrid.SelectedItem;

            // Kiểm tra xem selectedRow có tồn tại không
            if (selectedRow != null)
            {
                // Trích xuất DataRow từ DataRowView
                DataRow row = selectedRow.Row;
                Phim selectedMovie = new Phim
                {
                    TenPhim = row["TenPhim"].ToString(),
                    DaoDien = row["Daodien"].ToString(),
                    TheLoai = row["TheLoai"].ToString(),
                    ThoiLuong = Convert.ToInt32(row["ThoiLuong"]),
                    QuocGia = row.Table.Columns.Contains("QuocGia") ? row["QuocGia"].ToString() : "",
                    MoTa = row.Table.Columns.Contains("MoTa") ? row["MoTa"].ToString() : ""
                };

                ThongTinPhim thongTinPhimScreen = new ThongTinPhim(selectedMovie);
                thongTinPhimScreen.ShowDialog();
            }
        }
        

    }
}
