using System.Data;
using QuanLyCuaHangDienThoai.DTO;
using QuanLyCuaHangDienThoai.DAL;

namespace QuanLyCuaHangDienThoai.BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public bool DangNhap(string ten, string mk)
        {
            return dal.KiemTraDangNhap(ten, mk);
        }

        public bool DangKy(TaiKhoanDTO tk)
        {
            return dal.DangKyTaiKhoan(tk);
        }

        public TaiKhoanDTO LayTheoTen(string ten)
        {
            return dal.LayTaiKhoanTheoTen(ten);
        }

        public DataTable LayTatCa()
        {
            return dal.LayTatCaTaiKhoan();
        }
    }
}
