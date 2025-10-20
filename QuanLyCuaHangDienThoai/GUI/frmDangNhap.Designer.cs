using System.Drawing;
using System.Windows.Forms;
using System;

namespace QuanLyCuaHangDienThoai.GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.linkDangKy = new System.Windows.Forms.LinkLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panelTenDangNhap = new System.Windows.Forms.Panel();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.picPassword = new FontAwesome.Sharp.IconPictureBox();
            this.picUser = new FontAwesome.Sharp.IconPictureBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(50, 95);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(220, 25);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(50, 165);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(190, 25);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(50, 246);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(270, 36);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.MouseEnter += new System.EventHandler(this.btnDangNhap_MouseEnter);
            this.btnDangNhap.MouseLeave += new System.EventHandler(this.btnDangNhap_MouseLeave);
            // 
            // linkDangKy
            // 
            this.linkDangKy.AutoSize = true;
            this.linkDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkDangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkDangKy.Location = new System.Drawing.Point(91, 382);
            this.linkDangKy.Name = "linkDangKy";
            this.linkDangKy.Size = new System.Drawing.Size(229, 20);
            this.linkDangKy.TabIndex = 3;
            this.linkDangKy.TabStop = true;
            this.linkDangKy.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.linkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangKy_LinkClicked);
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
            this.panelHeader.TabIndex = 4;
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
            this.lblTitle.Size = new System.Drawing.Size(244, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
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
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.Location = new System.Drawing.Point(526, 4);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(114, 30);
            this.btnTheme.TabIndex = 10;
            this.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.lblTenDangNhap.Location = new System.Drawing.Point(50, 70);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(107, 20);
            this.lblTenDangNhap.TabIndex = 5;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.lblMatKhau.Location = new System.Drawing.Point(50, 140);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 20);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // panelTenDangNhap
            // 
            this.panelTenDangNhap.BackColor = System.Drawing.Color.Silver;
            this.panelTenDangNhap.Location = new System.Drawing.Point(50, 118);
            this.panelTenDangNhap.Name = "panelTenDangNhap";
            this.panelTenDangNhap.Size = new System.Drawing.Size(270, 1);
            this.panelTenDangNhap.TabIndex = 7;
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.BackColor = System.Drawing.Color.Silver;
            this.panelMatKhau.Location = new System.Drawing.Point(50, 188);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(270, 1);
            this.panelMatKhau.TabIndex = 8;
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.AutoSize = true;
            this.linkQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkQuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkQuenMatKhau.Location = new System.Drawing.Point(204, 209);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(116, 20);
            this.linkQuenMatKhau.TabIndex = 9;
            this.linkQuenMatKhau.TabStop = true;
            this.linkQuenMatKhau.Text = "Quên mật khẩu?";
            this.linkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenMatKhau_LinkClicked);
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
            this.panelLeft.Size = new System.Drawing.Size(400, 460);
            this.panelLeft.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(56, 300);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(300, 85);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Hệ thống quản lý cửa hàng điện thoại chuyên nghiệp với đầy đủ tính năng hiện đại";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(99, 250);
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
            this.lblWelcome.Location = new System.Drawing.Point(100, 200);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(217, 54);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(100, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnShowPassword);
            this.panelRight.Controls.Add(this.picPassword);
            this.panelRight.Controls.Add(this.picUser);
            this.panelRight.Controls.Add(this.lblOr);
            this.panelRight.Controls.Add(this.btnTwitter);
            this.panelRight.Controls.Add(this.btnFacebook);
            this.panelRight.Controls.Add(this.btnGoogle);
            this.panelRight.Controls.Add(this.txtTenDangNhap);
            this.panelRight.Controls.Add(this.linkQuenMatKhau);
            this.panelRight.Controls.Add(this.txtMatKhau);
            this.panelRight.Controls.Add(this.panelMatKhau);
            this.panelRight.Controls.Add(this.btnDangNhap);
            this.panelRight.Controls.Add(this.panelTenDangNhap);
            this.panelRight.Controls.Add(this.linkDangKy);
            this.panelRight.Controls.Add(this.lblMatKhau);
            this.panelRight.Controls.Add(this.lblTenDangNhap);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 40);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 460);
            this.panelRight.TabIndex = 11;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnShowPassword.Location = new System.Drawing.Point(250, 163);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(70, 25);
            this.btnShowPassword.TabIndex = 16;
            this.btnShowPassword.Text = "Hiện";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.White;
            this.picPassword.ForeColor = System.Drawing.Color.Gray;
            this.picPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.picPassword.IconColor = System.Drawing.Color.Gray;
            this.picPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPassword.IconSize = 20;
            this.picPassword.Location = new System.Drawing.Point(20, 165);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(20, 20);
            this.picPassword.TabIndex = 15;
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
            this.picUser.Location = new System.Drawing.Point(20, 95);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(20, 20);
            this.picUser.TabIndex = 14;
            this.picUser.TabStop = false;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOr.ForeColor = System.Drawing.Color.Gray;
            this.lblOr.Location = new System.Drawing.Point(175, 296);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(68, 20);
            this.lblOr.TabIndex = 13;
            this.lblOr.Text = "Hoặc với";
            // 
            // btnTwitter
            // 
            this.btnTwitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnTwitter.FlatAppearance.BorderSize = 2;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTwitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnTwitter.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.ic_twitter;
            this.btnTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwitter.Location = new System.Drawing.Point(276, 326);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(103, 35);
            this.btnTwitter.TabIndex = 12;
            this.btnTwitter.Text = "Twitter";
            this.btnTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnFacebook.FlatAppearance.BorderSize = 2;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnFacebook.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.ic_facebook;
            this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacebook.Location = new System.Drawing.Point(149, 326);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(121, 35);
            this.btnFacebook.TabIndex = 11;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.btnGoogle.FlatAppearance.BorderSize = 2;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGoogle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.btnGoogle.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.ic_google;
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogle.Location = new System.Drawing.Point(34, 326);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(109, 35);
            this.btnGoogle.TabIndex = 10;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // frmDangNhap
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel linkDangKy;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Panel panelTenDangNhap;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Label lblOr;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private FontAwesome.Sharp.IconPictureBox picPassword;
        private System.Windows.Forms.Button btnShowPassword;

    }
}