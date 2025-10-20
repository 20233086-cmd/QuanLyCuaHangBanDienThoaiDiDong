using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai.GUI
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.linkDangNhap = new System.Windows.Forms.LinkLabel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.picPhone = new FontAwesome.Sharp.IconPictureBox();
            this.picEmail = new FontAwesome.Sharp.IconPictureBox();
            this.picPerson = new FontAwesome.Sharp.IconPictureBox();
            this.picPassword = new FontAwesome.Sharp.IconPictureBox();
            this.picUser = new FontAwesome.Sharp.IconPictureBox();
            this.panelDienThoai = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelHoTen = new System.Windows.Forms.Panel();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.panelTenDangNhap = new System.Windows.Forms.Panel();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(50, 50);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(220, 25);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(50, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(190, 25);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoTen.Location = new System.Drawing.Point(50, 170);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 25);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(50, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDienThoai.Location = new System.Drawing.Point(50, 290);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(270, 25);
            this.txtDienThoai.TabIndex = 4;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(50, 340);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(270, 36);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnDangKy.MouseEnter += new System.EventHandler(this.btnDangKy_MouseEnter);
            this.btnDangKy.MouseLeave += new System.EventHandler(this.btnDangKy_MouseLeave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnTheme);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 40);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(720, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "–";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.Location = new System.Drawing.Point(499, 5);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(114, 30);
            this.btnTheme.TabIndex = 10;
            this.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLeft.Controls.Add(this.lblDescription);
            this.panelLeft.Controls.Add(this.lblAppName);
            this.panelLeft.Controls.Add(this.lblWelcome);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 510);
            this.panelLeft.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(50, 350);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(300, 82);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Tham gia cùng chúng tôi để trải nghiệm hệ thống quản lý cửa hàng điện thoại chuyê" +
    "n nghiệp";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(95, 300);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(223, 41);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "PHONE STORE";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(97, 250);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(217, 54);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.logo_mobile_phone_store;
            this.picLogo.Location = new System.Drawing.Point(100, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.linkDangNhap);
            this.panelRight.Controls.Add(this.btnShowPassword);
            this.panelRight.Controls.Add(this.picPhone);
            this.panelRight.Controls.Add(this.picEmail);
            this.panelRight.Controls.Add(this.picPerson);
            this.panelRight.Controls.Add(this.picPassword);
            this.panelRight.Controls.Add(this.picUser);
            this.panelRight.Controls.Add(this.panelDienThoai);
            this.panelRight.Controls.Add(this.panelEmail);
            this.panelRight.Controls.Add(this.panelHoTen);
            this.panelRight.Controls.Add(this.panelMatKhau);
            this.panelRight.Controls.Add(this.panelTenDangNhap);
            this.panelRight.Controls.Add(this.lblDienThoai);
            this.panelRight.Controls.Add(this.lblEmail);
            this.panelRight.Controls.Add(this.lblHoTen);
            this.panelRight.Controls.Add(this.lblMatKhau);
            this.panelRight.Controls.Add(this.lblTenDangNhap);
            this.panelRight.Controls.Add(this.txtTenDangNhap);
            this.panelRight.Controls.Add(this.txtMatKhau);
            this.panelRight.Controls.Add(this.txtHoTen);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.txtDienThoai);
            this.panelRight.Controls.Add(this.btnDangKy);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 40);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 510);
            this.panelRight.TabIndex = 8;
            // 
            // linkDangNhap
            // 
            this.linkDangNhap.AutoSize = true;
            this.linkDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkDangNhap.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkDangNhap.Location = new System.Drawing.Point(150, 390);
            this.linkDangNhap.Name = "linkDangNhap";
            this.linkDangNhap.Size = new System.Drawing.Size(120, 20);
            this.linkDangNhap.TabIndex = 22;
            this.linkDangNhap.TabStop = true;
            this.linkDangNhap.Text = "Đã có tài khoản?";
            this.linkDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangNhap_LinkClicked);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnShowPassword.Location = new System.Drawing.Point(250, 107);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(70, 25);
            this.btnShowPassword.TabIndex = 21;
            this.btnShowPassword.Text = "Hiện";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // picPhone
            // 
            this.picPhone.BackColor = System.Drawing.Color.White;
            this.picPhone.ForeColor = System.Drawing.Color.Gray;
            this.picPhone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.picPhone.IconColor = System.Drawing.Color.Gray;
            this.picPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPhone.IconSize = 20;
            this.picPhone.Location = new System.Drawing.Point(20, 290);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(20, 20);
            this.picPhone.TabIndex = 20;
            this.picPhone.TabStop = false;
            // 
            // picEmail
            // 
            this.picEmail.BackColor = System.Drawing.Color.White;
            this.picEmail.ForeColor = System.Drawing.Color.Gray;
            this.picEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.picEmail.IconColor = System.Drawing.Color.Gray;
            this.picEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picEmail.IconSize = 20;
            this.picEmail.Location = new System.Drawing.Point(20, 230);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(20, 20);
            this.picEmail.TabIndex = 19;
            this.picEmail.TabStop = false;
            // 
            // picPerson
            // 
            this.picPerson.BackColor = System.Drawing.Color.White;
            this.picPerson.ForeColor = System.Drawing.Color.Gray;
            this.picPerson.IconChar = FontAwesome.Sharp.IconChar.User;
            this.picPerson.IconColor = System.Drawing.Color.Gray;
            this.picPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPerson.IconSize = 20;
            this.picPerson.Location = new System.Drawing.Point(20, 170);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(20, 20);
            this.picPerson.TabIndex = 18;
            this.picPerson.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.White;
            this.picPassword.ForeColor = System.Drawing.Color.Gray;
            this.picPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.picPassword.IconColor = System.Drawing.Color.Gray;
            this.picPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPassword.IconSize = 20;
            this.picPassword.Location = new System.Drawing.Point(20, 110);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(20, 20);
            this.picPassword.TabIndex = 17;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.White;
            this.picUser.ForeColor = System.Drawing.Color.Gray;
            this.picUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.picUser.IconColor = System.Drawing.Color.Gray;
            this.picUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picUser.IconSize = 20;
            this.picUser.Location = new System.Drawing.Point(20, 50);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(20, 20);
            this.picUser.TabIndex = 16;
            this.picUser.TabStop = false;
            // 
            // panelDienThoai
            // 
            this.panelDienThoai.BackColor = System.Drawing.Color.Silver;
            this.panelDienThoai.Location = new System.Drawing.Point(50, 313);
            this.panelDienThoai.Name = "panelDienThoai";
            this.panelDienThoai.Size = new System.Drawing.Size(270, 1);
            this.panelDienThoai.TabIndex = 15;
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.Color.Silver;
            this.panelEmail.Location = new System.Drawing.Point(50, 253);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(270, 1);
            this.panelEmail.TabIndex = 14;
            // 
            // panelHoTen
            // 
            this.panelHoTen.BackColor = System.Drawing.Color.Silver;
            this.panelHoTen.Location = new System.Drawing.Point(50, 193);
            this.panelHoTen.Name = "panelHoTen";
            this.panelHoTen.Size = new System.Drawing.Size(270, 1);
            this.panelHoTen.TabIndex = 13;
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.BackColor = System.Drawing.Color.Silver;
            this.panelMatKhau.Location = new System.Drawing.Point(50, 133);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(270, 1);
            this.panelMatKhau.TabIndex = 12;
            // 
            // panelTenDangNhap
            // 
            this.panelTenDangNhap.BackColor = System.Drawing.Color.Silver;
            this.panelTenDangNhap.Location = new System.Drawing.Point(50, 73);
            this.panelTenDangNhap.Name = "panelTenDangNhap";
            this.panelTenDangNhap.Size = new System.Drawing.Size(270, 1);
            this.panelTenDangNhap.TabIndex = 11;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.lblDienThoai.Location = new System.Drawing.Point(50, 265);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(78, 20);
            this.lblDienThoai.TabIndex = 10;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(50, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Gray;
            this.lblHoTen.Location = new System.Drawing.Point(50, 145);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 20);
            this.lblHoTen.TabIndex = 8;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.lblMatKhau.Location = new System.Drawing.Point(50, 85);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 20);
            this.lblMatKhau.TabIndex = 7;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.lblTenDangNhap.Location = new System.Drawing.Point(50, 25);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(107, 20);
            this.lblTenDangNhap.TabIndex = 6;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // frmDangKy
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Panel panelTenDangNhap;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.Panel panelHoTen;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelDienThoai;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private FontAwesome.Sharp.IconPictureBox picPassword;
        private FontAwesome.Sharp.IconPictureBox picPerson;
        private FontAwesome.Sharp.IconPictureBox picEmail;
        private FontAwesome.Sharp.IconPictureBox picPhone;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.LinkLabel linkDangNhap;
    }
}