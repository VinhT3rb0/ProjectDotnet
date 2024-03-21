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
                string query = "SELECT Id, TenPhim, TheLoai, DaoDien, ThoiLuong FROM Phim";
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
            if (movieDataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)movieDataGrid.SelectedItem;
                int movieId = Convert.ToInt32(row["Id"]);

                try
                {
                    string deleteQuery = "DELETE FROM Phim WHERE Id = @Id";
                    int rowsAffected = ConnectData.DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { movieId });
                    if (rowsAffected > 0)
                    {
                        LoadData();
                        MessageBox.Show("Xóa phim thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phim. Vui lòng thử lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa phim: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim để xóa.");
            }
        }




        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (movieDataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)movieDataGrid.SelectedItem;
                Phim selectedMovie = new Phim
                {
                    TenPhim = row["TenPhim"].ToString(),
                    TheLoai = row["TheLoai"].ToString(),
                    DaoDien = row["DaoDien"].ToString(),
                };
                ThemPhim editWindow = new ThemPhim(selectedMovie);
                editWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim để sửa.");
            }
        }

        private void btnBuyTicket_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = (DataRowView)movieDataGrid.SelectedItem;
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
