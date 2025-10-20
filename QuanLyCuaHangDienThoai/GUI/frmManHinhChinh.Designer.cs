namespace QuanLyCuaHangDienThoai.GUI
{
    partial class frmManHinhChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuanTriTaiKhoan = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnQuanLyNCC = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnQuanLySanPham = new System.Windows.Forms.Button();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Controls.Add(this.btnThoat);
            this.panelHeader.Controls.Add(this.btnDangXuat);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnTheme);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(556, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(148, 20);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "dd/MM/yyyy HH:mm";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1087, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(164)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(971, 15);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(100, 30);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHONE STORE - HỆ THỐNG QUẢN LÝ";
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.Location = new System.Drawing.Point(783, 15);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(123, 30);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.Text = " Chế độ tối";
            this.btnTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSidebar.Controls.Add(this.btnQuanTriTaiKhoan);
            this.panelSidebar.Controls.Add(this.btnBaoCao);
            this.panelSidebar.Controls.Add(this.btnQuanLyNCC);
            this.panelSidebar.Controls.Add(this.btnQuanLyKhachHang);
            this.panelSidebar.Controls.Add(this.btnQuanLyNhanVien);
            this.panelSidebar.Controls.Add(this.btnNhapHang);
            this.panelSidebar.Controls.Add(this.btnBanHang);
            this.panelSidebar.Controls.Add(this.btnQuanLySanPham);
            this.panelSidebar.Controls.Add(this.lblQuyen);
            this.panelSidebar.Controls.Add(this.lblTenDangNhap);
            this.panelSidebar.Controls.Add(this.lblNguoiDung);
            this.panelSidebar.Controls.Add(this.picAvatar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(280, 740);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnQuanTriTaiKhoan
            // 
            this.btnQuanTriTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuanTriTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanTriTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTriTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanTriTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQuanTriTaiKhoan.Location = new System.Drawing.Point(20, 535);
            this.btnQuanTriTaiKhoan.Name = "btnQuanTriTaiKhoan";
            this.btnQuanTriTaiKhoan.Size = new System.Drawing.Size(240, 45);
            this.btnQuanTriTaiKhoan.TabIndex = 11;
            this.btnQuanTriTaiKhoan.Text = "🔐 Quản trị tài khoản";
            this.btnQuanTriTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanTriTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanTriTaiKhoan.Click += new System.EventHandler(this.btnQuanTriTaiKhoan_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(20, 480);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(240, 45);
            this.btnBaoCao.TabIndex = 10;
            this.btnBaoCao.Text = "📊 Báo cáo thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnQuanLyNCC
            // 
            this.btnQuanLyNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuanLyNCC.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyNCC.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNCC.Location = new System.Drawing.Point(20, 425);
            this.btnQuanLyNCC.Name = "btnQuanLyNCC";
            this.btnQuanLyNCC.Size = new System.Drawing.Size(240, 45);
            this.btnQuanLyNCC.TabIndex = 9;
            this.btnQuanLyNCC.Text = "🏢 Nhà cung cấp";
            this.btnQuanLyNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNCC.UseVisualStyleBackColor = false;
            this.btnQuanLyNCC.Click += new System.EventHandler(this.btnQuanLyNCC_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuanLyKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(20, 370);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(240, 45);
            this.btnQuanLyKhachHang.TabIndex = 8;
            this.btnQuanLyKhachHang.Text = "🤝 Quản lý khách hàng";
            this.btnQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = false;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(20, 315);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(240, 45);
            this.btnQuanLyNhanVien.TabIndex = 7;
            this.btnQuanLyNhanVien.Text = "👥 Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(20, 260);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(240, 45);
            this.btnNhapHang.TabIndex = 6;
            this.btnNhapHang.Text = "📦 Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(20, 205);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(240, 45);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "💰 Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuanLySanPham.FlatAppearance.BorderSize = 0;
            this.btnQuanLySanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLySanPham.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySanPham.Location = new System.Drawing.Point(20, 150);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.btnQuanLySanPham.Size = new System.Drawing.Size(240, 45);
            this.btnQuanLySanPham.TabIndex = 4;
            this.btnQuanLySanPham.Text = "📱 Quản lý sản phẩm";
            this.btnQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySanPham.UseVisualStyleBackColor = false;
            this.btnQuanLySanPham.Click += new System.EventHandler(this.btnQuanLySanPham_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblQuyen.Location = new System.Drawing.Point(20, 125);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(104, 23);
            this.lblQuyen.TabIndex = 3;
            this.lblQuyen.Text = "Quyền: N/A";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.lblTenDangNhap.Location = new System.Drawing.Point(20, 100);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(101, 23);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "@username";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNguoiDung.Location = new System.Drawing.Point(20, 70);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(153, 32);
            this.lblNguoiDung.TabIndex = 1;
            this.lblNguoiDung.Text = "Người dùng";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(100, 10);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(80, 80);
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(920, 740);
            this.panelMain.TabIndex = 2;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // frmManHinhChinh
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONE STORE - Hệ thống quản lý cửa hàng điện thoại";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button btnQuanLySanPham;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnQuanLyNCC;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnQuanTriTaiKhoan;
        private System.Windows.Forms.Button btnTheme;
    }
}