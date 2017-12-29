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
    public partial class _frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton _spbtnTaoTaiKhoan;
        private CheckBox _chkNu;
        private CheckBox _chkNam;
        private Label _lblGioiTinh;
        private Label _lblNgaySinh;
        private Label _lblPassword;
        private Label _lblEmail;
        private Label _lblTenDangNhap;
        private DateEdit dateEdit;
        private Label _lblDangKy;
        private TextBox _txtPassword;
        private TextBox _txtEmail;
        private TextBox _txtTenDangNhap;

        public _frmDangKy()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmDangKy));
            this._spbtnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this._chkNu = new System.Windows.Forms.CheckBox();
            this._chkNam = new System.Windows.Forms.CheckBox();
            this._lblGioiTinh = new System.Windows.Forms.Label();
            this._lblNgaySinh = new System.Windows.Forms.Label();
            this._lblPassword = new System.Windows.Forms.Label();
            this._lblEmail = new System.Windows.Forms.Label();
            this._lblTenDangNhap = new System.Windows.Forms.Label();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this._lblDangKy = new System.Windows.Forms.Label();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this._llblQuayLai = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _spbtnTaoTaiKhoan
            // 
            this._spbtnTaoTaiKhoan.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnTaoTaiKhoan.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnTaoTaiKhoan.Appearance.Options.UseFont = true;
            this._spbtnTaoTaiKhoan.Appearance.Options.UseForeColor = true;
            this._spbtnTaoTaiKhoan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnTaoTaiKhoan.Location = new System.Drawing.Point(33, 435);
            this._spbtnTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnTaoTaiKhoan.Name = "_spbtnTaoTaiKhoan";
            this._spbtnTaoTaiKhoan.Size = new System.Drawing.Size(302, 44);
            this._spbtnTaoTaiKhoan.TabIndex = 32;
            this._spbtnTaoTaiKhoan.Text = "Tạo Tài Khoản";
            // 
            // _chkNu
            // 
            this._chkNu.AutoSize = true;
            this._chkNu.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkNu.Location = new System.Drawing.Point(272, 377);
            this._chkNu.Name = "_chkNu";
            this._chkNu.Size = new System.Drawing.Size(52, 27);
            this._chkNu.TabIndex = 31;
            this._chkNu.Text = "Nữ";
            this._chkNu.UseVisualStyleBackColor = true;
            // 
            // _chkNam
            // 
            this._chkNam.AutoSize = true;
            this._chkNam.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkNam.Location = new System.Drawing.Point(171, 376);
            this._chkNam.Name = "_chkNam";
            this._chkNam.Size = new System.Drawing.Size(65, 27);
            this._chkNam.TabIndex = 30;
            this._chkNam.Text = "Nam";
            this._chkNam.UseVisualStyleBackColor = true;
            // 
            // _lblGioiTinh
            // 
            this._lblGioiTinh.AutoSize = true;
            this._lblGioiTinh.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGioiTinh.Location = new System.Drawing.Point(29, 377);
            this._lblGioiTinh.Name = "_lblGioiTinh";
            this._lblGioiTinh.Size = new System.Drawing.Size(74, 23);
            this._lblGioiTinh.TabIndex = 29;
            this._lblGioiTinh.Text = "Giới tính";
            // 
            // _lblNgaySinh
            // 
            this._lblNgaySinh.AutoSize = true;
            this._lblNgaySinh.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNgaySinh.Location = new System.Drawing.Point(29, 332);
            this._lblNgaySinh.Name = "_lblNgaySinh";
            this._lblNgaySinh.Size = new System.Drawing.Size(83, 23);
            this._lblNgaySinh.TabIndex = 28;
            this._lblNgaySinh.Text = "Ngày sinh";
            // 
            // _lblPassword
            // 
            this._lblPassword.AutoSize = true;
            this._lblPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPassword.Location = new System.Drawing.Point(29, 285);
            this._lblPassword.Name = "_lblPassword";
            this._lblPassword.Size = new System.Drawing.Size(83, 23);
            this._lblPassword.TabIndex = 27;
            this._lblPassword.Text = "Password";
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblEmail.Location = new System.Drawing.Point(29, 232);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(51, 23);
            this._lblEmail.TabIndex = 26;
            this._lblEmail.Text = "Email";
            // 
            // _lblTenDangNhap
            // 
            this._lblTenDangNhap.AutoSize = true;
            this._lblTenDangNhap.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTenDangNhap.Location = new System.Drawing.Point(29, 189);
            this._lblTenDangNhap.Name = "_lblTenDangNhap";
            this._lblTenDangNhap.Size = new System.Drawing.Size(122, 23);
            this._lblTenDangNhap.TabIndex = 25;
            this._lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(162, 336);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(173, 20);
            this.dateEdit.TabIndex = 24;
            // 
            // _lblDangKy
            // 
            this._lblDangKy.AutoSize = true;
            this._lblDangKy.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._lblDangKy.ForeColor = System.Drawing.Color.Black;
            this._lblDangKy.Location = new System.Drawing.Point(111, 131);
            this._lblDangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblDangKy.Name = "_lblDangKy";
            this._lblDangKy.Size = new System.Drawing.Size(123, 40);
            this._lblDangKy.TabIndex = 23;
            this._lblDangKy.Text = "Đăng Ký";
            // 
            // _txtPassword
            // 
            this._txtPassword.BackColor = System.Drawing.Color.White;
            this._txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.ForeColor = System.Drawing.Color.Gray;
            this._txtPassword.Location = new System.Drawing.Point(162, 285);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(173, 24);
            this._txtPassword.TabIndex = 22;
            // 
            // _txtEmail
            // 
            this._txtEmail.BackColor = System.Drawing.Color.White;
            this._txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmail.ForeColor = System.Drawing.Color.Gray;
            this._txtEmail.Location = new System.Drawing.Point(162, 232);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(173, 24);
            this._txtEmail.TabIndex = 21;
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.BackColor = System.Drawing.Color.White;
            this._txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtTenDangNhap.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this._txtTenDangNhap.Location = new System.Drawing.Point(162, 189);
            this._txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(173, 24);
            this._txtTenDangNhap.TabIndex = 20;
            // 
            // _llblQuayLai
            // 
            this._llblQuayLai.AutoSize = true;
            this._llblQuayLai.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._llblQuayLai.Location = new System.Drawing.Point(158, 499);
            this._llblQuayLai.Name = "_llblQuayLai";
            this._llblQuayLai.Size = new System.Drawing.Size(71, 23);
            this._llblQuayLai.TabIndex = 33;
            this._llblQuayLai.TabStop = true;
            this._llblQuayLai.Text = "Quay lại";
            this._llblQuayLai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llblQuayLai_LinkClicked);
            // 
            // _frmDangKy
            // 
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this._llblQuayLai);
            this.Controls.Add(this._spbtnTaoTaiKhoan);
            this.Controls.Add(this._chkNu);
            this.Controls.Add(this._chkNam);
            this.Controls.Add(this._lblGioiTinh);
            this.Controls.Add(this._lblNgaySinh);
            this.Controls.Add(this._lblPassword);
            this.Controls.Add(this._lblEmail);
            this.Controls.Add(this._lblTenDangNhap);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this._lblDangKy);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtTenDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "_frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _llblQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new _frmDangNhap();
            frm.ShowDialog();
        }
    }
}