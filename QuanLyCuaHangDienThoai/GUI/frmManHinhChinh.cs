using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangDienThoai.DTO;
using QuanLyCuaHangDienThoai.BUS;

namespace QuanLyCuaHangDienThoai.GUI
{
    public partial class frmManHinhChinh : Form
    {
        private TaiKhoanDTO taiKhoanHienTai;
        private PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
        private bool isDarkMode = false;

        public frmManHinhChinh(TaiKhoanDTO tk)
        {
            InitializeComponent();
            taiKhoanHienTai = tk;
            KhoiTaoGiaoDien();
            ApplyLightTheme(); // Mặc định theme sáng
            ApplyModernStyle();
            picAvatar.Image = CreateDefaultAvatar();
        }
        private Bitmap CreateDefaultAvatar()
        {
            var bmp = new Bitmap(80, 80);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Vẽ nền tròn
                using (var brush = new SolidBrush(Color.FromArgb(0, 122, 204)))
                {
                    g.FillEllipse(brush, 0, 0, 79, 79);
                }

                // Vẽ icon người
                using (var pen = new Pen(Color.White, 3))
                {
                    // Vẽ đầu
                    g.DrawEllipse(pen, 25, 15, 30, 30);

                    // Vẽ thân
                    g.DrawLine(pen, 40, 45, 40, 65);

                    // Vẽ tay
                    g.DrawLine(pen, 40, 50, 25, 55);
                    g.DrawLine(pen, 40, 50, 55, 55);

                    // Vẽ chân
                    g.DrawLine(pen, 40, 65, 30, 75);
                    g.DrawLine(pen, 40, 65, 50, 75);
                }
            }
            return bmp;
        }
        private void KhoiTaoGiaoDien()
        {
            lblNguoiDung.Text = $"{taiKhoanHienTai.HoTen}";
            lblTenDangNhap.Text = $"@{taiKhoanHienTai.TenDangNhap}";

            string tenQuyen = phanQuyenBUS.LayTenQuyen(taiKhoanHienTai.MaQuyen) ?? "N/A";
            lblQuyen.Text = tenQuyen;

            // Mặc định disable tất cả, sau đó enable theo quyền
            DisableAllMenuItems();

            if (taiKhoanHienTai.MaQuyen == Quyen.Admin)
            {
                // Admin: toàn quyền
                EnableAllMenuItems();
            }
            else if (taiKhoanHienTai.MaQuyen == Quyen.NhanVien)
            {
                // Nhân viên: bán hàng, quản lý sản phẩm, khách hàng
                btnQuanLySanPham.Enabled = true;
                btnBanHang.Enabled = true;
                btnNhapHang.Enabled = true;
                btnQuanLyKhachHang.Enabled = true;
                btnBaoCao.Enabled = true;
            }
            else if (taiKhoanHienTai.MaQuyen == Quyen.KhachHang)
            {
                // Khách hàng: chỉ xem sản phẩm
                btnQuanLySanPham.Enabled = true;
            }
        }

        private void DisableAllMenuItems()
        {
            btnQuanLySanPham.Enabled = false;
            btnBanHang.Enabled = false;
            btnNhapHang.Enabled = false;
            btnQuanLyNhanVien.Enabled = false;
            btnQuanLyKhachHang.Enabled = false;
            btnQuanLyNCC.Enabled = false;
            btnBaoCao.Enabled = false;
            btnQuanTriTaiKhoan.Enabled = false;
        }

        private void EnableAllMenuItems()
        {
            btnQuanLySanPham.Enabled = true;
            btnBanHang.Enabled = true;
            btnNhapHang.Enabled = true;
            btnQuanLyNhanVien.Enabled = true;
            btnQuanLyKhachHang.Enabled = true;
            btnQuanLyNCC.Enabled = true;
            btnBaoCao.Enabled = true;
            btnQuanTriTaiKhoan.Enabled = true;
        }

        private void ApplyModernStyle()
        {
            // Hiệu ứng hover cho các nút chức năng
            SetupButtonHoverEffects();
        }

        private void SetupButtonHoverEffects()
        {
            var buttons = new[] { btnQuanLySanPham, btnBanHang, btnNhapHang, btnQuanLyNhanVien,
                                btnQuanLyKhachHang, btnQuanLyNCC, btnBaoCao, btnQuanTriTaiKhoan };

            foreach (var button in buttons)
            {
                button.MouseEnter += (s, e) =>
                {
                    button.BackColor = Color.FromArgb(0, 96, 164);
                    button.Size = new Size(button.Width + 4, button.Height + 4);
                    button.Location = new Point(button.Location.X - 2, button.Location.Y - 2);
                };

                button.MouseLeave += (s, e) =>
                {
                    if (button.Enabled)
                    {
                        button.BackColor = Color.FromArgb(0, 122, 204);
                        button.Size = new Size(button.Width - 4, button.Height - 4);
                        button.Location = new Point(button.Location.X + 2, button.Location.Y + 2);
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(200, 200, 200);
                    }
                };
            }
        }

        private void ApplyLightTheme()
        {
            isDarkMode = false;

            // Header
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            lblTitle.ForeColor = Color.White;
            lblDateTime.ForeColor = Color.White;

            // Sidebar
            panelSidebar.BackColor = Color.FromArgb(240, 240, 240);
            lblNguoiDung.ForeColor = Color.FromArgb(0, 122, 204);
            lblTenDangNhap.ForeColor = Color.Gray;
            lblQuyen.ForeColor = Color.FromArgb(0, 122, 204);

            // Main content
            panelMain.BackColor = Color.White;
            this.BackColor = Color.White;

            // Buttons
            UpdateButtonsTheme();

            // Theme toggle button
            btnTheme.Image = CreateMoonIcon();
            btnTheme.Text = "Chế độ tối";
            btnTheme.BackColor = Color.FromArgb(0, 122, 204);
            btnTheme.ForeColor = Color.White;
        }

        private void ApplyDarkTheme()
        {
            isDarkMode = true;

            // Header
            panelHeader.BackColor = Color.FromArgb(45, 45, 45);
            lblTitle.ForeColor = Color.White;
            lblDateTime.ForeColor = Color.White;

            // Sidebar
            panelSidebar.BackColor = Color.FromArgb(60, 60, 60);
            lblNguoiDung.ForeColor = Color.FromArgb(100, 180, 255);
            lblTenDangNhap.ForeColor = Color.LightGray;
            lblQuyen.ForeColor = Color.FromArgb(100, 180, 255);

            // Main content
            panelMain.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(30, 30, 30);

            // Buttons
            UpdateButtonsTheme();

            // Theme toggle button
            btnTheme.Image = CreateSunIcon();
            btnTheme.Text = "Chế độ sáng";
            btnTheme.BackColor = Color.FromArgb(80, 80, 80);
            btnTheme.ForeColor = Color.White;
        }

        // Tạo icon mặt trăng cho chế độ tối
        private Bitmap CreateMoonIcon()
        {
            var bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Vẽ mặt trăng
                using (var brush = new SolidBrush(Color.White))
                {
                    g.FillEllipse(brush, 2, 2, 12, 12);

                    // Tạo hiệu ứng khuyết (mặt trăng)
                    using (var darkBrush = new SolidBrush(Color.FromArgb(0, 122, 204)))
                    {
                        g.FillEllipse(darkBrush, 0, 0, 10, 10);
                    }
                }

                // Thêm các ngôi sao nhỏ
                using (var starBrush = new SolidBrush(Color.White))
                {
                    // Sao 1
                    g.FillEllipse(starBrush, 12, 4, 2, 2);
                    // Sao 2
                    g.FillEllipse(starBrush, 14, 8, 1, 1);
                    // Sao 3
                    g.FillEllipse(starBrush, 11, 12, 1, 1);
                }
            }
            return bmp;
        }

        // Tạo icon mặt trời cho chế độ sáng
        private Bitmap CreateSunIcon()
        {
            var bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Vẽ mặt trời (vàng)
                using (var sunBrush = new SolidBrush(Color.FromArgb(255, 215, 0))) // Màu vàng
                {
                    g.FillEllipse(sunBrush, 4, 4, 8, 8);
                }

                // Vẽ tia nắng
                using (var rayPen = new Pen(Color.FromArgb(255, 215, 0), 1))
                {
                    // Tia trên
                    g.DrawLine(rayPen, 8, 2, 8, 0);
                    // Tia dưới
                    g.DrawLine(rayPen, 8, 14, 8, 16);
                    // Tia trái
                    g.DrawLine(rayPen, 2, 8, 0, 8);
                    // Tia phải
                    g.DrawLine(rayPen, 14, 8, 16, 8);
                    // Tia chéo
                    g.DrawLine(rayPen, 4, 4, 2, 2);
                    g.DrawLine(rayPen, 12, 4, 14, 2);
                    g.DrawLine(rayPen, 4, 12, 2, 14);
                    g.DrawLine(rayPen, 12, 12, 14, 14);
                }

                // Thêm hiệu ứng ánh sáng
                using (var glowBrush = new SolidBrush(Color.FromArgb(255, 255, 150, 50)))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        g.FillEllipse(glowBrush, 3 - i, 3 - i, 10 + i * 2, 10 + i * 2);
                    }
                }
            }
            return bmp;
        }

        private void UpdateButtonsTheme()
        {
            var buttons = new[] { btnQuanLySanPham, btnBanHang, btnNhapHang, btnQuanLyNhanVien,
                                btnQuanLyKhachHang, btnQuanLyNCC, btnBaoCao, btnQuanTriTaiKhoan };

            foreach (var button in buttons)
            {
                if (button.Enabled)
                {
                    if (isDarkMode)
                    {
                        button.BackColor = Color.FromArgb(45, 45, 45);
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(0, 122, 204);
                        button.ForeColor = Color.White;
                    }
                }
                else
                {
                    if (isDarkMode)
                    {
                        button.BackColor = Color.FromArgb(80, 80, 80);
                        button.ForeColor = Color.Gray;
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(200, 200, 200);
                        button.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
                ApplyLightTheme();
            else
                ApplyDarkTheme();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Quản lý sản phẩm");
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Bán hàng");
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Nhập hàng");
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Quản lý nhân viên");
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Quản lý khách hàng");
        }

        private void btnQuanLyNCC_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Quản lý nhà cung cấp");
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Báo cáo thống kê");
        }

        private void btnQuanTriTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowFeatureMessage("Quản trị tài khoản");
        }

        private void ShowFeatureMessage(string featureName)
        {
            MessageBox.Show($"Mở module: {featureName}\n(Chức năng đang được phát triển)",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Hiệu ứng fade out
                for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
                {
                    this.Opacity = opacity;
                    System.Threading.Thread.Sleep(30);
                }

                this.Hide();
                new frmDangNhap().Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}