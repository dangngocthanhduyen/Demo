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
    public partial class _frmKhoiPhucMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton _spbtnTiepTuc;
        private TextBox _txtNhapEmail;
        private Label _lblNhapEmail;
        private Label _lblKhoiPhucMatKhau;

        public _frmKhoiPhucMatKhau()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmKhoiPhucMatKhau));
            this._spbtnTiepTuc = new DevExpress.XtraEditors.SimpleButton();
            this._txtNhapEmail = new System.Windows.Forms.TextBox();
            this._lblNhapEmail = new System.Windows.Forms.Label();
            this._lblKhoiPhucMatKhau = new System.Windows.Forms.Label();
            this._llblQuayLai = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _spbtnTiepTuc
            // 
            this._spbtnTiepTuc.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnTiepTuc.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnTiepTuc.Appearance.Options.UseFont = true;
            this._spbtnTiepTuc.Appearance.Options.UseForeColor = true;
            this._spbtnTiepTuc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnTiepTuc.Location = new System.Drawing.Point(43, 403);
            this._spbtnTiepTuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnTiepTuc.Name = "_spbtnTiepTuc";
            this._spbtnTiepTuc.Size = new System.Drawing.Size(281, 44);
            this._spbtnTiepTuc.TabIndex = 16;
            this._spbtnTiepTuc.Text = "Tiếp Tục";
            this._spbtnTiepTuc.Click += new System.EventHandler(this._spbtnTiepTuc_Click);
            // 
            // _txtNhapEmail
            // 
            this._txtNhapEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtNhapEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNhapEmail.ForeColor = System.Drawing.Color.Gray;
            this._txtNhapEmail.Location = new System.Drawing.Point(43, 300);
            this._txtNhapEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtNhapEmail.Multiline = true;
            this._txtNhapEmail.Name = "_txtNhapEmail";
            this._txtNhapEmail.Size = new System.Drawing.Size(281, 44);
            this._txtNhapEmail.TabIndex = 15;
            this._txtNhapEmail.Text = "Nhập Email";
            this._txtNhapEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lblNhapEmail
            // 
            this._lblNhapEmail.AutoSize = true;
            this._lblNhapEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNhapEmail.Location = new System.Drawing.Point(50, 245);
            this._lblNhapEmail.Name = "_lblNhapEmail";
            this._lblNhapEmail.Size = new System.Drawing.Size(263, 23);
            this._lblNhapEmail.TabIndex = 14;
            this._lblNhapEmail.Text = "Nhập Email để nhận Mã xác nhận";
            // 
            // _lblKhoiPhucMatKhau
            // 
            this._lblKhoiPhucMatKhau.AutoSize = true;
            this._lblKhoiPhucMatKhau.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._lblKhoiPhucMatKhau.ForeColor = System.Drawing.Color.Black;
            this._lblKhoiPhucMatKhau.Location = new System.Drawing.Point(41, 182);
            this._lblKhoiPhucMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblKhoiPhucMatKhau.Name = "_lblKhoiPhucMatKhau";
            this._lblKhoiPhucMatKhau.Size = new System.Drawing.Size(283, 40);
            this._lblKhoiPhucMatKhau.TabIndex = 13;
            this._lblKhoiPhucMatKhau.Text = "Khôi Phục Mật Khẩu";
            // 
            // _llblQuayLai
            // 
            this._llblQuayLai.AutoSize = true;
            this._llblQuayLai.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._llblQuayLai.Location = new System.Drawing.Point(143, 358);
            this._llblQuayLai.Name = "_llblQuayLai";
            this._llblQuayLai.Size = new System.Drawing.Size(71, 23);
            this._llblQuayLai.TabIndex = 34;
            this._llblQuayLai.TabStop = true;
            this._llblQuayLai.Text = "Quay lại";
            this._llblQuayLai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llblQuayLai_LinkClicked);
            // 
            // _frmKhoiPhucMatKhau
            // 
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this._llblQuayLai);
            this.Controls.Add(this._spbtnTiepTuc);
            this.Controls.Add(this._txtNhapEmail);
            this.Controls.Add(this._lblNhapEmail);
            this.Controls.Add(this._lblKhoiPhucMatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "_frmKhoiPhucMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi Phục Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _spbtnTiepTuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new _frmKhoiPhucMatKhau1();
            frm.ShowDialog();
        }

        private void _llblQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new _frmDangNhap();
            frm.ShowDialog();
        }
    }
}