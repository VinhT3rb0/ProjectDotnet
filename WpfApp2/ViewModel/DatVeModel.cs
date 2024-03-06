using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp2.Database.ConnectData;
using System.Data.SqlClient;
using System.Data;
namespace WpfApp2.ViewModel
{
    class DatVeModel
    {
        DataTable result = DataProvider.Instance.ExecuteQuery("SELECT Phim.TenPhim, ShowTime.GioChieu, Id.Phong, ThoiLuong.Phim, Price.Ve" +
            "FROM Ve " +
            "JOIN Phim ON Ve.PhimId = Phim.Id " +
            "JOIN ShowTime ON Ve.ShowTimeId = ShowTime.Id" +
            "JOIN Phong ON Ve.");
    }
}
