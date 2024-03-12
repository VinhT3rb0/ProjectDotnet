using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Database
{
    class ConnectData
    {
        public class DataProvider : IDisposable
        {
            private static DataProvider instance;

            public static DataProvider Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DataProvider();
                    return DataProvider.instance;
                }
                private set { DataProvider.instance = value; }
            }

            public static string ConnectionString { get; internal set; }

            public string connectionSTR = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True;Encrypt=False";

            public SqlConnection connection;
            public DataProvider()
            {
                connection = new SqlConnection(connectionSTR);
                connection.Open();
            }

            public void Dispose()
            {
                if (connection != null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }
            public DataTable ExecuteQuery(string query, object[] paramater = null)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (paramater != null)
                    {
                        string[] lisrPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in lisrPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                return data;
            }


            public int ExecuteNonQuery(string query, object[] paramater = null)
            {
                int data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (paramater != null)
                    {
                        string[] lisrPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in lisrPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
                return data;
            }
            public bool InsertMovie(int IdPhim, string tenPhim, string daoDien, string theLoai, string quocGia, string moTa, string hinhAnh, int thoiLuong)
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    string query = "INSERT INTO Phim (Id,TenPhim, DaoDien, TheLoai, QuocGia, MoTa, HinhAnh, ThoiLuong) " +
                                   "VALUES (@Id, @TenPhim, @DaoDien, @TheLoai, @QuocGia, @MoTa, @HinhAnh, @ThoiLuong)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", IdPhim);
                    command.Parameters.AddWithValue("@TenPhim", tenPhim);
                    command.Parameters.AddWithValue("@DaoDien", daoDien);
                    command.Parameters.AddWithValue("@TheLoai", theLoai);
                    command.Parameters.AddWithValue("@QuocGia", quocGia);
                    command.Parameters.AddWithValue("@MoTa", moTa);
                    command.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                    command.Parameters.AddWithValue("@ThoiLuong", thoiLuong);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            public object ExecuteScalar(string query, object[] paramater = null)
            {
                object data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (paramater != null)
                    {
                        string[] lisrPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in lisrPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();
                    connection.Close();
                }
                return data;
            }
        }
    }
}
