using System;

namespace QuanLyCuaHangDienThoai.DTO
{
    public class TaiKhoanDTO
    {
        public int MaTK { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhauHash { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public int MaQuyen { get; set; }
        public bool Is2FAEnabled { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
    }
}
