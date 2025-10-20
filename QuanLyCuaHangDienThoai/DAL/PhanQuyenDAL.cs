using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using QuanLyCuaHangDienThoai.DTO;

namespace QuanLyCuaHangDienThoai.DAL
{
    public class PhanQuyenDAL
    {
        public DataTable LayTatCaPhanQuyen()
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "SELECT MaQuyen, TenQuyen FROM PhanQuyen";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string LayTenQuyenTheoMa(int maQuyen)
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "SELECT TenQuyen FROM PhanQuyen WHERE MaQuyen=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maQuyen);
                object o = cmd.ExecuteScalar();
                return o == null ? null : o.ToString();
            }
        }
    }
}
