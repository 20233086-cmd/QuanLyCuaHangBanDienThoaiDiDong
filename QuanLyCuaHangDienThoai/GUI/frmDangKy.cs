using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangDienThoai.BUS;
using QuanLyCuaHangDienThoai.DTO;

namespace QuanLyCuaHangDienThoai.GUI
{
    public partial class frmDangKy : Form
    {
        private TaiKhoanBUS bus = new TaiKhoanBUS();
        private bool isDarkMode = false;

        public frmDangKy()
        {
            InitializeComponent();
            //LoadLogo();
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

            // Hiệu ứng focus cho textbox
            SetupTextBoxFocusEffects();

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
            lblHoTen.ForeColor = Color.Gray;
            lblEmail.ForeColor = Color.Gray;
            lblDienThoai.ForeColor = Color.Gray;

            // Textbox colors
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.ForeColor = Color.Black;
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.ForeColor = Color.Black;
            txtHoTen.BackColor = Color.White;
            txtHoTen.ForeColor = Color.Black;
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
            txtDienThoai.BackColor = Color.White;
            txtDienThoai.ForeColor = Color.Black;

            // Panel underline
            panelTenDangNhap.BackColor = Color.Silver;
            panelMatKhau.BackColor = Color.Silver;
            panelHoTen.BackColor = Color.Silver;
            panelEmail.BackColor = Color.Silver;
            panelDienThoai.BackColor = Color.Silver;

            // Icon colors
            picUser.IconColor = Color.Gray;
            picPassword.IconColor = Color.Gray;
            picPerson.IconColor = Color.Gray;
            picEmail.IconColor = Color.Gray;
            picPhone.IconColor = Color.Gray;

            // Button colors
            btnDangKy.BackColor = Color.FromArgb(0, 122, 204);
            btnDangKy.ForeColor = Color.White;

            // Link colors
            linkDangNhap.LinkColor = Color.FromArgb(0, 122, 204);

            // Theme button
            btnTheme.Image = CreateMoonIcon();
            btnTheme.Text = "Chế độ sáng";
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
            lblHoTen.ForeColor = Color.LightGray;
            lblEmail.ForeColor = Color.LightGray;
            lblDienThoai.ForeColor = Color.LightGray;

            // Textbox colors
            txtTenDangNhap.BackColor = Color.FromArgb(60, 60, 60);
            txtTenDangNhap.ForeColor = Color.White;
            txtMatKhau.BackColor = Color.FromArgb(60, 60, 60);
            txtMatKhau.ForeColor = Color.White;
            txtHoTen.BackColor = Color.FromArgb(60, 60, 60);
            txtHoTen.ForeColor = Color.White;
            txtEmail.BackColor = Color.FromArgb(60, 60, 60);
            txtEmail.ForeColor = Color.White;
            txtDienThoai.BackColor = Color.FromArgb(60, 60, 60);
            txtDienThoai.ForeColor = Color.White;

            // Panel underline
            panelTenDangNhap.BackColor = Color.FromArgb(100, 100, 100);
            panelMatKhau.BackColor = Color.FromArgb(100, 100, 100);
            panelHoTen.BackColor = Color.FromArgb(100, 100, 100);
            panelEmail.BackColor = Color.FromArgb(100, 100, 100);
            panelDienThoai.BackColor = Color.FromArgb(100, 100, 100);

            // Icon colors
            picUser.IconColor = Color.LightGray;
            picPassword.IconColor = Color.LightGray;
            picPerson.IconColor = Color.LightGray;
            picEmail.IconColor = Color.LightGray;
            picPhone.IconColor = Color.LightGray;

            // Button colors
            btnDangKy.BackColor = Color.FromArgb(0, 96, 164);
            btnDangKy.ForeColor = Color.White;

            // Link colors
            linkDangNhap.LinkColor = Color.FromArgb(100, 180, 255);

            // Theme button
            btnTheme.Image = CreateSunIcon();
            btnTheme.Text = "Chế độ tối";
            btnTheme.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
                ApplyLightTheme();
            else
                ApplyDarkTheme();
        }

        // Các phương thức CreateMoonIcon và CreateSunIcon (giống như form đăng nhập)
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

        private void SetupTextBoxFocusEffects()
        {
            // Tạo dictionary để map textbox với panel underline tương ứng
            var textBoxPanelMap = new System.Collections.Generic.Dictionary<TextBox, Panel>
            {
                { txtTenDangNhap, panelTenDangNhap },
                { txtMatKhau, panelMatKhau },
                { txtHoTen, panelHoTen },
                { txtEmail, panelEmail },
                { txtDienThoai, panelDienThoai }
            };

            foreach (var kvp in textBoxPanelMap)
            {
                var textBox = kvp.Key;
                var panel = kvp.Value;

                textBox.Enter += (s, e) =>
                {
                    panel.BackColor = Color.FromArgb(0, 122, 204);
                };

                textBox.Leave += (s, e) =>
                {
                    panel.BackColor = Color.Silver;
                };
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            TaiKhoanDTO tk = new TaiKhoanDTO
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhauHash = txtMatKhau.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                MaQuyen = 2,
                Is2FAEnabled = false
            };

            // Hiệu ứng loading
            btnDangKy.Text = "ĐANG ĐĂNG KÝ...";
            btnDangKy.Enabled = false;
            Application.DoEvents();

            if (bus.DangKy(tk))
            {
                // Hiệu ứng thành công
                btnDangKy.BackColor = Color.FromArgb(76, 175, 80);
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiệu ứng fade out
                for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
                {
                    this.Opacity = opacity;
                    System.Threading.Thread.Sleep(50);
                }
                this.Close();
            }
            else
            {
                // Hiệu ứng lỗi
                btnDangKy.BackColor = Color.FromArgb(244, 67, 54);
                ShakeForm();
                MessageBox.Show("Đăng ký thất bại! Tên đăng nhập có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Khôi phục button
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.Enabled = true;
            btnDangKy.BackColor = Color.FromArgb(0, 122, 204);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Hiệu ứng rung form khi đăng ký thất bại
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

        // Hiệu ứng hover cho button đăng ký
        private void btnDangKy_MouseEnter(object sender, EventArgs e)
        {
            btnDangKy.BackColor = Color.FromArgb(0, 96, 164);
            btnDangKy.Size = new Size(280, 40);
            btnDangKy.Location = new Point(btnDangKy.Location.X - 5, btnDangKy.Location.Y - 2);
        }

        private void btnDangKy_MouseLeave(object sender, EventArgs e)
        {
            btnDangKy.BackColor = Color.FromArgb(0, 122, 204);
            btnDangKy.Size = new Size(270, 36);
            btnDangKy.Location = new Point(btnDangKy.Location.X + 5, btnDangKy.Location.Y + 2);
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

        // Hiển thị/ẩn mật khẩu
        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '\0';
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
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

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
