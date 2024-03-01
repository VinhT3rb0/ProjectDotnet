using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp2.Database.ConnectData;

namespace WpfApp2.Database
{
    class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account()
        { }

        public bool Login(string username, string password)
        {
            string query = "select * from TaiKhoan1 where TenDangNhap = @username and MatKhau = @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;

        }
    }
}
