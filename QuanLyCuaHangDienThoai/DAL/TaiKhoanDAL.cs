using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangDienThoai.DTO;
using QuanLyCuaHangDienThoai.Interface;

namespace QuanLyCuaHangDienThoai.DAL
{
    public class TaiKhoanDAL : ITaiKhoanService
    {
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@ten AND MatKhauHash=@mk AND TrangThai=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", tenDangNhap);
                cmd.Parameters.AddWithValue("@mk", matKhau);
                int kq = (int)cmd.ExecuteScalar();
                return kq > 0;
            }
        }

        public bool DangKyTaiKhoan(TaiKhoanDTO tk)
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "INSERT INTO TaiKhoan(TenDangNhap, MatKhauHash, HoTen, Email, DienThoai, MaQuyen, Is2FAEnabled) " +
                             "VALUES(@ten, @mk, @hoten, @email, @dt, @quyen, @is2fa)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@mk", tk.MatKhauHash);
                cmd.Parameters.AddWithValue("@hoten", tk.HoTen);
                cmd.Parameters.AddWithValue("@email", tk.Email);
                cmd.Parameters.AddWithValue("@dt", tk.DienThoai);
                cmd.Parameters.AddWithValue("@quyen", tk.MaQuyen);
                cmd.Parameters.AddWithValue("@is2fa", tk.Is2FAEnabled);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public TaiKhoanDTO LayTaiKhoanTheoTen(string tenDangNhap)
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@ten";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", tenDangNhap);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return new TaiKhoanDTO
                    {
                        MaTK = Convert.ToInt32(rd["MaTK"]),
                        TenDangNhap = rd["TenDangNhap"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        Email = rd["Email"].ToString(),
                        DienThoai = rd["DienThoai"].ToString(),
                        MaQuyen = Convert.ToInt32(rd["MaQuyen"]),
                        Is2FAEnabled = Convert.ToBoolean(rd["Is2FAEnabled"]),
                        TrangThai = Convert.ToBoolean(rd["TrangThai"])
                    };
                }
                return null;
            }
        }

        public DataTable LayTatCaTaiKhoan()
        {
            using (SqlConnection conn = DatabaseHelper.MoKetNoi())
            {
                string sql = "SELECT * FROM TaiKhoan";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
