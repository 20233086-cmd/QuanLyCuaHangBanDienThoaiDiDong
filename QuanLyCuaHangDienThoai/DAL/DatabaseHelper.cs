using System.Data.SqlClient;
using System.Data;

namespace QuanLyCuaHangDienThoai.DAL
{
    public class DatabaseHelper
    {
        private static string chuoiKetNoi =
            @"Data Source=HAZY\SQLEXPRESS;Initial Catalog=QuanLyCuaHangDT;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public static void DongKetNoi(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
