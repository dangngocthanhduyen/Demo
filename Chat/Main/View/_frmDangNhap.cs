using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Main.View
{
    public partial class _frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private Label _lblDangNhap;
        private SimpleButton _spbtnDangKy;
        private Label _lblChuaCoTaiKhoan;
        private SimpleButton _spbtnDangNhap;
        private LinkLabel _llblQuenMatKhau;
        private TextBox _txtPassword;
        private TextBox _txtEmail;

        public _frmDangNhap()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmDangNhap));
            this._lblDangNhap = new System.Windows.Forms.Label();
            this._spbtnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this._lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this._spbtnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this._llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblDangNhap
            // 
            this._lblDangNhap.AutoSize = true;
            this._lblDangNhap.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._lblDangNhap.ForeColor = System.Drawing.Color.Black;
            this._lblDangNhap.Location = new System.Drawing.Point(111, 127);
            this._lblDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblDangNhap.Name = "_lblDangNhap";
            this._lblDangNhap.Size = new System.Drawing.Size(163, 40);
            this._lblDangNhap.TabIndex = 15;
            this._lblDangNhap.Text = "Đăng Nhập";
            // 
            // _spbtnDangKy
            // 
            this._spbtnDangKy.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnDangKy.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnDangKy.Appearance.Options.UseFont = true;
            this._spbtnDangKy.Appearance.Options.UseForeColor = true;
            this._spbtnDangKy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnDangKy.Location = new System.Drawing.Point(42, 439);
            this._spbtnDangKy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnDangKy.Name = "_spbtnDangKy";
            this._spbtnDangKy.Size = new System.Drawing.Size(281, 44);
            this._spbtnDangKy.TabIndex = 14;
            this._spbtnDangKy.Text = "Đăng Ký";
            this._spbtnDangKy.Click += new System.EventHandler(this._spbtnDangKy_Click);
            // 
            // _lblChuaCoTaiKhoan
            // 
            this._lblChuaCoTaiKhoan.AutoSize = true;
            this._lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblChuaCoTaiKhoan.Location = new System.Drawing.Point(119, 403);
            this._lblChuaCoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblChuaCoTaiKhoan.Name = "_lblChuaCoTaiKhoan";
            this._lblChuaCoTaiKhoan.Size = new System.Drawing.Size(155, 23);
            this._lblChuaCoTaiKhoan.TabIndex = 13;
            this._lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            // 
            // _spbtnDangNhap
            // 
            this._spbtnDangNhap.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnDangNhap.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnDangNhap.Appearance.Options.UseFont = true;
            this._spbtnDangNhap.Appearance.Options.UseForeColor = true;
            this._spbtnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnDangNhap.Location = new System.Drawing.Point(42, 347);
            this._spbtnDangNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnDangNhap.Name = "_spbtnDangNhap";
            this._spbtnDangNhap.Size = new System.Drawing.Size(281, 44);
            this._spbtnDangNhap.TabIndex = 12;
            this._spbtnDangNhap.Text = "Đăng Nhập";
            // 
            // _llblQuenMatKhau
            // 
            this._llblQuenMatKhau.AutoSize = true;
            this._llblQuenMatKhau.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._llblQuenMatKhau.Location = new System.Drawing.Point(119, 305);
            this._llblQuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._llblQuenMatKhau.Name = "_llblQuenMatKhau";
            this._llblQuenMatKhau.Size = new System.Drawing.Size(136, 23);
            this._llblQuenMatKhau.TabIndex = 11;
            this._llblQuenMatKhau.TabStop = true;
            this._llblQuenMatKhau.Text = "Quên mật khẩu?";
            this._llblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llblQuenMatKhau_LinkClicked);
            // 
            // _txtPassword
            // 
            this._txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.ForeColor = System.Drawing.Color.Gray;
            this._txtPassword.Location = new System.Drawing.Point(42, 249);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtPassword.Multiline = true;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(281, 44);
            this._txtPassword.TabIndex = 10;
            this._txtPassword.Text = "Nhập Password";
            this._txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtEmail
            // 
            this._txtEmail.BackColor = System.Drawing.Color.White;
            this._txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmail.ForeColor = System.Drawing.Color.Gray;
            this._txtEmail.Location = new System.Drawing.Point(42, 185);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtEmail.Multiline = true;
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(281, 44);
            this._txtEmail.TabIndex = 9;
            this._txtEmail.Text = "Nhập Email";
            this._txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _frmDangNhap
            // 
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this._lblDangNhap);
            this.Controls.Add(this._spbtnDangKy);
            this.Controls.Add(this._lblChuaCoTaiKhoan);
            this.Controls.Add(this._spbtnDangNhap);
            this.Controls.Add(this._llblQuenMatKhau);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "_frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _spbtnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new _frmDangKy();
            frm.ShowDialog();
        }

        private void _llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new _frmKhoiPhucMatKhau();
            frm.ShowDialog();
        }
    }
}