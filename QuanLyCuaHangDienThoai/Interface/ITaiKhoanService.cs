using System.Data;
using QuanLyCuaHangDienThoai.DTO;

namespace QuanLyCuaHangDienThoai.Interface
{
    public interface ITaiKhoanService
    {
        bool KiemTraDangNhap(string tenDangNhap, string matKhau);
        bool DangKyTaiKhoan(TaiKhoanDTO tk);
        TaiKhoanDTO LayTaiKhoanTheoTen(string tenDangNhap);
        DataTable LayTatCaTaiKhoan();
    }
}
