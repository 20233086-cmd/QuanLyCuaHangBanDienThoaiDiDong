using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangDienThoai.BUS;
using QuanLyCuaHangDienThoai.DTO;

namespace QuanLyCuaHangDienThoai.GUI
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoanBUS bus = new TaiKhoanBUS();
        private bool isDarkMode = false;

        public frmDangNhap()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetupEventHandlers();
            ApplyLightTheme(); // Mặc định theme sáng
        }

        private void SetupEventHandlers()
        {
            // Hiệu ứng hover cho nút đóng
            this.btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.Red; };
            this.btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.Transparent; };

            // Hiệu ứng hover cho nút thu nhỏ
            this.btnMinimize.MouseEnter += (s, e) => { btnMinimize.BackColor = Color.FromArgb(50, 50, 50); };
            this.btnMinimize.MouseLeave += (s, e) => { btnMinimize.BackColor = Color.Transparent; };

            // Hiệu ứng hover cho các nút mạng xã hội
            SetupSocialButtonHover(btnGoogle, Color.FromArgb(234, 67, 53));
            SetupSocialButtonHover(btnFacebook, Color.FromArgb(59, 89, 152));
            SetupSocialButtonHover(btnTwitter, Color.FromArgb(29, 161, 242));

            // Hiệu ứng hover cho nút theme
            btnTheme.MouseEnter += (s, e) =>
            {
                if (isDarkMode)
                    btnTheme.BackColor = Color.FromArgb(80, 80, 80);
                else
                    btnTheme.BackColor = Color.FromArgb(0, 96, 164);
            };
            btnTheme.MouseLeave += (s, e) =>
            {
                if (isDarkMode)
                    btnTheme.BackColor = Color.FromArgb(60, 60, 60);
                else
                    btnTheme.BackColor = Color.FromArgb(0, 122, 204);
            };
        }

        private void SetupSocialButtonHover(Button button, Color hoverColor)
        {
            var originalColor = button.BackColor;
            var originalBorder = button.FlatAppearance.BorderColor;
            var originalForeColor = button.ForeColor;

            button.MouseEnter += (s, e) =>
            {
                button.BackColor = hoverColor;
                button.FlatAppearance.BorderColor = hoverColor;
                button.ForeColor = Color.White; // Chữ màu trắng khi hover
            };

            button.MouseLeave += (s, e) =>
            {
                if (isDarkMode)
                {
                    button.BackColor = Color.FromArgb(60, 60, 60);
                    button.FlatAppearance.BorderColor = hoverColor;
                    button.ForeColor = hoverColor;
                }
                else
                {
                    button.BackColor = Color.White;
                    button.FlatAppearance.BorderColor = hoverColor;
                    button.ForeColor = hoverColor;
                }
            };

            button.MouseLeave += (s, e) =>
            {
                button.BackColor = originalColor;
                button.FlatAppearance.BorderColor = originalBorder;
                button.ForeColor = originalForeColor; // Khôi phục màu chữ ban đầu
            };
        }

        private void ApplyLightTheme()
        {
            isDarkMode = false;

            // Background
            this.BackColor = Color.White;
            panelLeft.BackColor = Color.FromArgb(0, 122, 204);
            panelRight.BackColor = Color.White;
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);

            // Text colors
            lblTitle.ForeColor = Color.White;
            lblWelcome.ForeColor = Color.White;
            lblAppName.ForeColor = Color.White;
            lblDescription.ForeColor = Color.White;
            lblTenDangNhap.ForeColor = Color.Gray;
            lblMatKhau.ForeColor = Color.Gray;
            lblOr.ForeColor = Color.Gray;

            // Textbox colors
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.ForeColor = Color.Black;
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.ForeColor = Color.Black;

            // Panel underline
            panelTenDangNhap.BackColor = Color.Silver;
            panelMatKhau.BackColor = Color.Silver;

            // Icon colors
            picUser.IconColor = Color.Gray;
            picPassword.IconColor = Color.Gray;

            // Button colors
            btnDangNhap.BackColor = Color.FromArgb(0, 122, 204);
            btnDangNhap.ForeColor = Color.White;

            // Link colors
            linkDangKy.LinkColor = Color.FromArgb(0, 122, 204);
            linkQuenMatKhau.LinkColor = Color.FromArgb(0, 122, 204);

            // Social buttons
            UpdateSocialButtonsTheme();

            // Theme button
            btnTheme.Image = CreateMoonIcon();
            btnTheme.Text = "Chế độ tối";
            btnTheme.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void ApplyDarkTheme()
        {
            isDarkMode = true;

            // Background
            this.BackColor = Color.FromArgb(30, 30, 30);
            panelLeft.BackColor = Color.FromArgb(45, 45, 45);
            panelRight.BackColor = Color.FromArgb(40, 40, 40);
            panelHeader.BackColor = Color.FromArgb(45, 45, 45);

            // Text colors
            lblTitle.ForeColor = Color.White;
            lblWelcome.ForeColor = Color.White;
            lblAppName.ForeColor = Color.White;
            lblDescription.ForeColor = Color.LightGray;
            lblTenDangNhap.ForeColor = Color.LightGray;
            lblMatKhau.ForeColor = Color.LightGray;
            lblOr.ForeColor = Color.LightGray;

            // Textbox colors
            txtTenDangNhap.BackColor = Color.FromArgb(60, 60, 60);
            txtTenDangNhap.ForeColor = Color.White;
            txtMatKhau.BackColor = Color.FromArgb(60, 60, 60);
            txtMatKhau.ForeColor = Color.White;

            // Panel underline
            panelTenDangNhap.BackColor = Color.FromArgb(100, 100, 100);
            panelMatKhau.BackColor = Color.FromArgb(100, 100, 100);

            // Icon colors
            picUser.IconColor = Color.LightGray;
            picPassword.IconColor = Color.LightGray;

            // Button colors
            btnDangNhap.BackColor = Color.FromArgb(0, 96, 164);
            btnDangNhap.ForeColor = Color.White;

            // Link colors
            linkDangKy.LinkColor = Color.FromArgb(100, 180, 255);
            linkQuenMatKhau.LinkColor = Color.FromArgb(100, 180, 255);

            // Social buttons
            UpdateSocialButtonsTheme();

            // Theme button
            btnTheme.Image = CreateSunIcon();
            btnTheme.Text = "Chế độ sáng";
            btnTheme.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void UpdateSocialButtonsTheme()
        {
            var socialButtons = new[] { btnGoogle, btnFacebook, btnTwitter };
            var colors = new[] { Color.FromArgb(234, 67, 53), Color.FromArgb(59, 89, 152), Color.FromArgb(29, 161, 242) };

            for (int i = 0; i < socialButtons.Length; i++)
            {
                var button = socialButtons[i];
                var color = colors[i];

                if (isDarkMode)
                {
                    button.BackColor = Color.FromArgb(60, 60, 60);
                    button.FlatAppearance.BorderColor = color;
                    button.ForeColor = color;
                }
                else
                {
                    button.BackColor = Color.White;
                    button.FlatAppearance.BorderColor = color;
                    button.ForeColor = color;
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

        // Các phương thức CreateMoonIcon và CreateSunIcon (giống như trong form chính)
        private Bitmap CreateMoonIcon()
        {
            var bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                using (var brush = new SolidBrush(Color.White))
                {
                    g.FillEllipse(brush, 2, 2, 12, 12);
                    using (var darkBrush = new SolidBrush(Color.FromArgb(0, 122, 204)))
                    {
                        g.FillEllipse(darkBrush, 0, 0, 10, 10);
                    }
                }
            }
            return bmp;
        }

        private Bitmap CreateSunIcon()
        {
            var bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                using (var brush = new SolidBrush(Color.FromArgb(255, 215, 0)))
                {
                    g.FillEllipse(brush, 3, 3, 10, 10);
                }

                using (var pen = new Pen(Color.FromArgb(255, 215, 0), 2))
                {
                    g.DrawLine(pen, 8, 0, 8, 3);
                    g.DrawLine(pen, 8, 13, 8, 16);
                    g.DrawLine(pen, 0, 8, 3, 8);
                    g.DrawLine(pen, 13, 8, 16, 8);
                }
            }
            return bmp;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            TaiKhoanDTO tk = new TaiKhoanDTO();
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiệu ứng loading
            btnDangNhap.Text = "ĐANG ĐĂNG NHẬP...";
            btnDangNhap.Enabled = false;
            Application.DoEvents();

            if (bus.DangNhap(ten, mk))
            {
                // Hiệu ứng thành công
                btnDangNhap.BackColor = Color.FromArgb(76, 175, 80);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiệu ứng fade out
                for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
                {
                    this.Opacity = opacity;
                    System.Threading.Thread.Sleep(50);
                }

                this.Hide();
                // Mở form chính tại đây
                var fManHinhChinh = new frmManHinhChinh(tk);
                fManHinhChinh.ShowDialog();
            }
            else
            {
                // Hiệu ứng lỗi
                btnDangNhap.BackColor = Color.FromArgb(244, 67, 54);
                ShakeForm();
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Khôi phục button
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.Enabled = true;
            btnDangNhap.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy fDangKy = new frmDangKy();
            fDangKy.ShowDialog();
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tính năng quên mật khẩu đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hiệu ứng rung form khi đăng nhập thất bại
        private void ShakeForm()
        {
            var original = this.Location;
            var rnd = new Random();
            const int shake = 10;

            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(original.X + rnd.Next(-shake, shake),
                                         original.Y + rnd.Next(-shake, shake));
                System.Threading.Thread.Sleep(20);
            }
            this.Location = original;
        }

        // Hiệu ứng hover cho button đăng nhập
        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.FromArgb(0, 96, 164);
            btnDangNhap.Size = new Size(280, 40);
            btnDangNhap.Location = new Point(btnDangNhap.Location.X - 5, btnDangNhap.Location.Y - 2);
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.FromArgb(0, 122, 204);
            btnDangNhap.Size = new Size(270, 36);
            btnDangNhap.Location = new Point(btnDangNhap.Location.X + 5, btnDangNhap.Location.Y + 2);
        }

        // Hiệu ứng focus cho textbox
        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            panelTenDangNhap.BackColor = Color.FromArgb(0, 122, 204);
            lblTenDangNhap.ForeColor = Color.FromArgb(0, 122, 204);
            picUser.IconColor = Color.FromArgb(0, 122, 204);
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            panelTenDangNhap.BackColor = Color.Silver;
            lblTenDangNhap.ForeColor = Color.Gray;
            picUser.IconColor = Color.Gray;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            panelMatKhau.BackColor = Color.FromArgb(0, 122, 204);
            lblMatKhau.ForeColor = Color.FromArgb(0, 122, 204);
            picPassword.IconColor = Color.FromArgb(0, 122, 204);
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            panelMatKhau.BackColor = Color.Silver;
            lblMatKhau.ForeColor = Color.Gray;
            picPassword.IconColor = Color.Gray;
        }

        // Xử lý nút đóng và thu nhỏ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Xử lý đăng nhập bằng mạng xã hội
        private void btnGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đăng nhập bằng Google đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đăng nhập bằng Facebook đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đăng nhập bằng Twitter đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cho phép di chuyển form bằng panel header
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '\0';
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
        }
    }
}